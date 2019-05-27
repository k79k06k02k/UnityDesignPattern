using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.SimpleFactory
{
    public class SimpleFactoryTester : MonoBehaviour
    {
        public float numberA = 3;
        public float numberB = 5;

        private void Start()
        {
            OperationBase operationBase = OperationFactory.CreateOperate(OperationType.Add, numberA, numberB);
            float result = operationBase.GetResult();

            Debug.Log("OperationType Add: " + result);
        }
    }
}