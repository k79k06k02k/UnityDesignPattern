using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Factory
{
    public abstract class OperationBase
    {
        public float numberA { get; set; }
        public float numberB { get; set; }


        public OperationBase(float numberA, float numberB)
        {
            this.numberA = numberA;
            this.numberB = numberB;
        }

        public abstract float GetResult();
    }


    public class OperationAdd : OperationBase
    {
        public OperationAdd(float numberA, float numberB) : base(numberA, numberB)
        {
        }

        public override float GetResult()
        {
            return numberA + numberB;
        }
    }

    public class OperationSub : OperationBase
    {
        public OperationSub(float numberA, float numberB) : base(numberA, numberB)
        {
        }

        public override float GetResult()
        {
            return numberA - numberB;
        }
    }

    public class OperationMul : OperationBase
    {
        public OperationMul(float numberA, float numberB) : base(numberA, numberB)
        {
        }

        public override float GetResult()
        {
            return numberA * numberB;
        }
    }

    public class OperationDiv : OperationBase
    {
        public OperationDiv(float numberA, float numberB) : base(numberA, numberB)
        {
        }

        public override float GetResult()
        {
            return numberA / numberB;
        }
    }
}