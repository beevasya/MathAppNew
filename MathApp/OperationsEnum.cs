using MathApp.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class OperationsEnum
    {
        public int Id { set; get; }
        public string Name => Operation.Name;
        public string Description => Operation.Description;
        public IOperation Operation { get; set; }

    }
}
