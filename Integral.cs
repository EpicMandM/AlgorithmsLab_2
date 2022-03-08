using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLab_2
{
    static class Integral
    {
        public static double LeftSquare(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 0; i <= n-1; i++)
            {
                sum += func(a + i * h);
            }
            return h*sum;

        }

        public static double RightSquare(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += func(a + i * h);
            }
            return h * sum;
        }

        public static double MiddleSquare(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = (func(a) + func(b)) /2;
            for (int i = 1; i <= n-1; i++)
            {
                sum += func(a + i * h);
            }
            return h * sum;
        }
    }
}
