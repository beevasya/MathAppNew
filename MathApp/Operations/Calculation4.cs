using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class Calculation4 : IOperation
    {
        public string Name => "Вычисление x^3-y^2-(x*y)";
        public string Description => "Вычисляет значение x^3-y^2-(x*y), где x = param1, y = param2";

        public double Calc(double param1, double param2)
        {
            return Math.Pow(param1, 3) - Math.Pow(param2, 2) - param1 * param2;
        }
    }
}
