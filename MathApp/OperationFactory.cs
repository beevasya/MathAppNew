using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class OperationFactory
    {
        static OperationFactory Instance { get; set; }
        List<OperationsEnum> Operations;
        public OperationFactory()
        {
            Operations = new List<OperationsEnum>();
            Operations.Add(new OperationsEnum() { Id = 0, Operation = new Operations.Add() });
            Operations.Add(new OperationsEnum() { Id = 1, Operation = new Operations.Sqrt() });
            Operations.Add(new OperationsEnum() { Id = 2, Operation = new Operations.SqDiff() });
            Operations.Add(new OperationsEnum() { Id = 3, Operation = new Operations.Pow() });
            Operations.Add(new OperationsEnum() { Id = 4, Operation = new Operations.sinxaddsiny() });
            Operations.Add(new OperationsEnum() { Id = 6, Operation = new Operations.SumWithIncrement0p1() });
            Operations.Add(new OperationsEnum() { Id = 8, Operation = new Operations.task_07() });
            Operations.Add(new OperationsEnum() { Id = 10, Operation = new Operations.InverseSq() });
            Operations.Add(new OperationsEnum() { Id = 12, Operation = new Operations.TwoMinusXPerThreePlusY() });
            Operations.Add(new OperationsEnum() { Id = 14, Operation = new Operations.Calculation13()});
            Operations.Add(new OperationsEnum() { Id = 15, Operation = new Operations.TanCheck() });
            Operations.Add(new OperationsEnum() { Id = 17, Operation = new Operations.task_16() });
        }
        public static List<OperationsEnum> GetOperations()
        {
            if (Instance == null)
                Instance = new OperationFactory();
            return Instance.Operations;
        }
    }
}
