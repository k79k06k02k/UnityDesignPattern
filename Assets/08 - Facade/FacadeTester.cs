using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Facade
{
    public class FacadeTester : MonoBehaviour
    {
        private void Start()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}