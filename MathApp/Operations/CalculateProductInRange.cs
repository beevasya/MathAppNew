using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class CalculateProductInRange : IOperation
    {
        public string Name => "Произведение элементов с шагом 1";
        public string Description => "Вычисляет произведения элементов с x по y с шагом 1, где x = param1, y = param2. param2 должен быть больше или равен param1";

        public double Calc(double param1, double param2)
        {
            if (param2 < param1)
                throw new Exception("param2 должен быть больше или равен param1");

            double product = 1;

            for (var i = param1; i <= param2; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
