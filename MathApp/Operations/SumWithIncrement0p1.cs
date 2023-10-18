using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class SumWithIncrement0p1 : IOperation
    {
        public string Name => "Сумма элементов с шагом 0.1";
        public string Description => "Вычисляет сумму элементов с param1 до param2 с шагом 0.1. param1 должен быть не больше param2.";
        public double Calc(double param1, double param2)
        {
            if (param1 > param2)
                throw new Exception("param1 должен быть не больше param2");
            double Result = 0;
            for (; param1 <= param2;)
            {
                Result += param1;
                param1 = Math.Round(param1 + 0.1, 15);
            }
            return Result;
        }
    }
}
