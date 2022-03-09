using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLab_2
{
    interface IIntegral
    {
        double GetIntegral(Func<double, double> func, double a, double b, double n);
    }
}
