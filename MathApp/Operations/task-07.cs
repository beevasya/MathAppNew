using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    //x-y-x*y+x^2+y^2
    class task_07 : IOperation
    {
        public string Name => "Вычисление x-y-x*y+x^2+y^2";

        public string Description => "Вычисляет x-y-x*y+x^2+y^2, где x- param1, а y - param2";

        public double Calc(double param1, double param2)
        {
            return (param1 - param2 - param1 * param2 + param1 * param1 + param2 * param2);
        }
    }
}
