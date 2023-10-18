using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class TanCheck: IOperation
    {
        public string Name => "Деление Tan(X) и Tan(Y)";

        public string Description => "Складывает Значение 1 и Значение 2 и выводит результат c проверкой введеных значений";

        public double Calc(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new Exception("Одно из значений должно быть больше 0");
            }

            if (y == 0)
            {
                throw new Exception("Параметр 2 не должен равняться 0, т.к. tg 0 будет = 0, а на нуль делить нельзя.");
            }
            return Math.Tan(Math.Round(x) / Math.Tan(Math.Round(y)));

        }
    }
}