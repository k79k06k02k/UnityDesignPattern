using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Observer
{
    public class ObserverTester : MonoBehaviour
    {
        private void Start()
        {
            SubjectA subjectA = new SubjectA();

            subjectA.Add(new ObserverA(subjectA));
            subjectA.Add(new ObserverB(subjectA));

            subjectA.status = "Set Status!";
            subjectA.Notify();
        }
    }
}