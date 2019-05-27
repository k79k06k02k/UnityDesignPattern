using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Factory
{
    public class FactoryTester : MonoBehaviour
    {
        private void Start()
        {
            OperationAddFactory factory = new OperationAddFactory();
            OperationBase operation = factory.CreateOperation(3, 5);
            float result = operation.GetResult();

            Debug.Log("OperationType Add: " + result);
        }
    }
}