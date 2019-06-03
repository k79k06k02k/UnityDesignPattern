using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Prototype
{
    public class PrototypeTester : MonoBehaviour
    {
        private void Start()
        {
            Resume resumeA = new Resume();
            resumeA.SetInfo("man", "16");
            resumeA.SetWorkExp("1Y", "FB");

            Resume resumeB = resumeA.CloneDeep();
            resumeB.SetInfo("gril", "33");

            Resume resumeC = resumeA.CloneDeep();
            resumeC.SetWorkExp("4Y", "Google");


            resumeA.Display();
            resumeB.Display();
            resumeC.Display();
        }
    }
}