﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgorithmsLab_2
{
    class Program
    {
        static Func<double, double> func = t => t != 1 ? Math.Log(t) / (1 - Math.Pow(t, 2)) : 0;
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
        static ICollection<double> xs;
        static Program()
        {
            xs = GetXs();
        }
        static ICollection<double> GetXs()
        {
            List<double> xs = new List<double>();
            for (double i = 0.1; i <= 1; i = i + 0.1)
            {
                xs.Add(i);
            }
            return xs;
        }
        static double[] GetIntergal(ICollection<double> xs, IIntegral integral)
        {
            List<double> integ = new List<double>();
            foreach (double item in xs)
            {
                integ.Add(integral.GetIntegral(func, 0.1, item, 10e4));
            }
            return integ.ToArray();
        }

        static void Main(string[] args)
        {
            ICollection<double> xs = GetXs();
            Print(xs.ToArray(), GetIntergal(xs, new LeftIntegral()), GetIntergal(xs, new MiddleIntegral()), GetIntergal(xs, new RightIntegral()));
        }
    }
}