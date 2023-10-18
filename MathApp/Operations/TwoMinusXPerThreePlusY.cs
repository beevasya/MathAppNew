using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp.Operations
{
    internal class TwoMinusXPerThreePlusY : IOperation
    {
        public string Name => "Параметрическое отношение";

        public string Description => "Считает отношение параметров: из 2 вычесть значение param1; к 3 прибавить param2";

        public double Calc(double param1, double param2)
        {
            var denominator = (3 + param2);

            if(denominator == 0)
            {
                throw new Exception($"param2 не может быть равен {param2}");
            }

            return (2 - param1) / denominator;
        }
    }
}
