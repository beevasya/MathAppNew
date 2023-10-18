using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    class sinxaddsiny: IOperation
    {
        public string Name => "Сложение Sin(X) и Cos(Y)";

        public string Description => "Складывает Значение 1 и Значение 2 и выводит результат в радианах";

        public double Calc(double x, double y)
        {
            return Math.Sin(Math.Round(x) + Math.Cos(Math.Round(y)));
        }
    }
}

/*return Math.Tan(Math.Round(x) + Math.Tan(Math.Round(y)));
 */





