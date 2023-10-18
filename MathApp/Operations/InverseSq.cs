using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class InverseSq : IOperation
    {
        public string Name => "Обратный квадрат";

        public string Description => "Делит param1 на квадрат param2";

        public double Calc(double param1, double param2)
        {
            if(param2 == 0)
            {
                throw new Exception($"param2 не может быть равен {param2}");
            }

            return param1 / param2 / param2;
        }
    }
}
