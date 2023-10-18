using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp.Operations
{
    class task_16 : IOperation
    {
        public string Name => "Вычисление √tan(x+y)/tan(x-y)";

        public string Description => "Вычисление √tan(x+y)/tan(x-y), где x - param1, а y - param2. Вычисляет тангенс угла в градусах";

        public double Calc(double param1, double param2)
        {
            if (Math.Tan((param1 + param2) * (Math.PI / 180)) < 0)
                throw new Exception("Попытка вычислить корень из отрицательного цисла");
            if ((param1 - param2) % 180 == 0)
                throw new DivideByZeroException();
            return (Math.Sqrt(Math.Tan((param1 + param2) * (Math.PI / 180))) / Math.Tan((param1 - param2) * (Math.PI / 180)));
        }
    }
}
