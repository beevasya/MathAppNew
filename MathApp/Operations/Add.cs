using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class Add : IOperation
    {
        public string Name => "Сложение";

        public string Description => "Складывает param1 и param2";

        public double Calc(double param1, double param2)
        {
            return param1 + param2;
        }
    }
}
