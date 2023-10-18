using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class SqDiff : IOperation
    {
        public string Name => "Разность квадратов";

        public string Description => "Вычитает из квадрата param1 квадрат param2";

        public double Calc(double param1, double param2)
        {
            return param1 * param1 - param2 * param2;
        }
    }
}
