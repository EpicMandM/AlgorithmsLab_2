using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgorithmsLab_2
{
    class Program
    {
        static void Print(double[] x, double[] l, double[] m, double[] r)
        {
            Console.WriteLine("|-------|-------|-------|-------|-------|");
            Console.WriteLine("|   i   |   x   |  l_i  |  m_i  |  r_i  |");
            Console.WriteLine("|-------|-------|-------|-------|-------|");
            for (long i = 0; i < x.LongLength; i++)
            {
                Console.Write("|");
                Console.Write("{0,-7:F2}|", i);
                Console.Write(x[i] < 0 ? "{0,-7:F2}|" : " {0,-6:F2}|", x[i]);
                Console.Write(l[i] < 0 ? "{0,-7:F2}|" : " {0,-6:F2}|", l[i]);
                Console.Write(m[i] < 0 ? "{0,-7:F2}|" : " {0,-6:F2}|", m[i]);
                Console.Write(r[i] < 0 ? "{0,-7:F2}|" : " {0,-6:F2}|", r[i]);
                Console.WriteLine();
            }
            Console.WriteLine("|-------|-------|-------|-------|");
        }
        static void Main(string[] args)
        {
        }
    }
}
