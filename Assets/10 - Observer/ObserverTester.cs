using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Observer
{
    public class ObserverTester : MonoBehaviour
    {

        private void Start()
        {
            TestObserver();

            Debug.Log("-------------------------------------------------------------------------------------");

            TestDelegate();
        }



        private void TestObserver()
        {
            SubjectA subjectA = new SubjectA();

            subjectA.Add(new ObserverA(subjectA));
            subjectA.Add(new ObserverB(subjectA));

            subjectA.status = "Set Status!";
            subjectA.Notify();
        }



        private delegate void EventHandler();
        private event EventHandler OnEventNotify;

        private void TestDelegate()
        {
            OnEventNotify += EventObserverA;
            OnEventNotify += EventObserverB;

            OnEventNotify.Invoke();
        }
        private void EventObserverA()
        {
            Debug.Log("EventObserverA Update!");
        }
        private void EventObserverB()
        {
            Debug.Log("EventObserverB Update!");
        }
    }
}