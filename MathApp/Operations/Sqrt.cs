using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class Sqrt : IOperation
    {
        public string Name => "Квадратный корень";

        public string Description => "Вычисляет значение квадратного корня из param1. param1 должен быть положительным числом";

        public double Calc(double param1, double param2)
        {
            if (param1 < 0)
                throw new Exception("param1 должен быть больше 0");
            return Math.Sqrt(param1);
        }
    }
}
