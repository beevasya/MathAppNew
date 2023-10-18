using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    internal class Pow : IOperation
    {
        public string Name => "Возведение в степень";

        public string Description => "Возводит значение из param1 в степень значения param2";

        public double Calc(double param1, double param2)
        {
            return Math.Pow(param1, param2);
        }
    }
}
