using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class Calculation13 : IOperation
    {
        public string Name => "Вычисление (x^2 + y)/y";
        public string Description => "Вычисляет значение (x^2 + y)/y, где x = param1, y = param2. param2 должен быть не равен нулю";

        public double Calc(double param1, double param2)
        {
            if (param2 == 0)
                throw new Exception("param2 должен быть не равен нулю");
            return (Math.Pow(param1, 2) + param2) / param2;
        }
    }
}
