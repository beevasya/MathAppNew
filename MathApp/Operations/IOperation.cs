using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    interface IOperation
    {
        double Calc(double param1, double param2);
        string Name { get; }
        string Description { get; }
    }
}
