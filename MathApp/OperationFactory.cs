﻿using System;
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
        }
        public static List<OperationsEnum> GetOperations()
        {
            if (Instance == null)
                Instance = new OperationFactory();
            return Instance.Operations;
        }
    }
}
