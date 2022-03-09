using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgorithmsLab_2
{
    class Program
    {
        static Func<double, double> func = t => t != 1 ? Math.Log(t) / (1 - Math.Pow(t, 2)) : 0;
        const double bottomBorder = 0.1;
        const double N = 10;
        static void Print(double[] x, double[] l, double[] m, double[] r)
        {
            Console.WriteLine("|-------|-------|-------|-------|-------|");
            Console.WriteLine("|   i   |   x   |  l_i  |  m_i  |  r_i  |");
            Console.WriteLine("|-------|-------|-------|-------|-------|");
            for (long i = 0; i < x.LongLength; i++)
            {
                Console.Write("|");
                Console.Write("{0,-7:F0}|", i);
                Console.Write(x[i] < 0 ? "{0,-7:F1}|" : " {0,-6:F1}|", x[i]);
                Console.Write(l[i] < 0 ? "{0,-7:F4}|" : " {0,-6:F4}|", l[i]);
                Console.Write(m[i] < 0 ? "{0,-7:F4}|" : " {0,-6:F4}|", m[i]);
                Console.Write(r[i] < 0 ? "{0,-7:F4}|" : " {0,-6:F4}|", r[i]);
                Console.WriteLine();
            }
            Console.WriteLine("|-------|-------|-------|-------|-------|");
        }
        private static ICollection<double> xs;
        static Program()
        {
            xs = GetXs();
        }
        static ICollection<double> GetXs()
        {
            List<double> xs = new List<double>();
            for (double i = bottomBorder; i <= 1; i = i + bottomBorder)
            {
                xs.Add(i);
            }
            return xs;
        }
        static double[] GetIntergal(IIntegral integral)
        {
            return GetIntegral(integral, N); 
        }
        static double[] GetIntegral(IIntegral integral, double h)
        {
            List<double> integ = new List<double>();
            foreach (double item in xs)
            {
                integ.Add(integral.GetIntegral(func, bottomBorder, item, h)); 
            }
            return integ.ToArray();
        }
        static double DoRunge(IIntegral integral, double topBorder, double h, double double_h)
        {
            return Math.Abs(integral.GetIntegral(func, bottomBorder, topBorder, h) - integral.GetIntegral(func, bottomBorder, topBorder, double_h)) / 3;
        }
        static double[] GetRunge(IIntegral integral)
        {
            return GetRunge(integral, N);
        }
        static double[] GetRunge(IIntegral integral, double h)
        {
            List<double> runge = new List<double>();
            foreach (double item in xs)
            {
                runge.Add(DoRunge(integral, item, h, h * 2));
            }
            return runge.ToArray();
        }
        static void Main(string[] args)
        {
            ICollection<double> xs = GetXs();
            Print(xs.ToArray(), GetIntergal(new LeftIntegral()), GetIntergal(new MiddleIntegral()), GetIntergal(new RightIntegral()));
            Print(xs.ToArray(), GetRunge(new LeftIntegral()), GetRunge(new MiddleIntegral()), GetRunge(new RightIntegral()));
        }
    }
}