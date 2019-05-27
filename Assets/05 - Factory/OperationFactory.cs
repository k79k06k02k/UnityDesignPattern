using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Factory
{
    public interface IOperationFactory
    {
        OperationBase CreateOperation(float numberA, float numberB);
    }


    public class OperationAddFactory : IOperationFactory
    {
        public OperationBase CreateOperation(float numberA, float numberB)
        {
            return new OperationAdd(numberA, numberB);
        }
    }

    public class OperationSubFactory : IOperationFactory
    {
        public OperationBase CreateOperation(float numberA, float numberB)
        {
            return new OperationSub(numberA, numberB);
        }
    }

    public class OperationMulFactory : IOperationFactory
    {
        public OperationBase CreateOperation(float numberA, float numberB)
        {
            return new OperationMul(numberA, numberB);
        }
    }

    public class OperationDivFactory : IOperationFactory
    {
        public OperationBase CreateOperation(float numberA, float numberB)
        {
            return new OperationDiv(numberA, numberB);
        }
    }
}