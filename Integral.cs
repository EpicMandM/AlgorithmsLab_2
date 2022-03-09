using System;
namespace AlgorithmsLab_2
{
    class LeftIntegral : IIntegral
    {
        public double GetIntegral(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                sum += func(a + i * h);
            }
            return h * sum;

        }
    }
    class RightIntegral : IIntegral
    {
        public double GetIntegral(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += func(a + i * h);
            }
            return h * sum;
        }
    }
    class MiddleIntegral : IIntegral
    {
        public double GetIntegral(Func<double, double> func, double a, double b, double n)
        {
            double h = (b - a) / n;
            double sum = (func(a) + func(b)) / 2;
            for (int i = 1; i <= n - 1; i++)
            {
                sum += func(a + i * h);
            }
            return h * sum;
        }
    }
}
