using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Facade
{
    public class Facade
    {
        private SubSystem1 m_subSystem1;
        private SubSystem2 m_subSystem2;
        private SubSystem3 m_subSystem3;

        public Facade()
        {
            m_subSystem1 = new SubSystem1();
            m_subSystem2 = new SubSystem2();
            m_subSystem3 = new SubSystem3();
        }

        public void MethodA()
        {
            m_subSystem1.SubMethod1();
            m_subSystem2.SubMethod2();
        }

        public void MethodB()
        {
            m_subSystem3.SubMethod3();
        }
    }

    public class SubSystem1
    {
        public void SubMethod1()
        {
            Debug.Log("SubMethod1");
        }
    }

    public class SubSystem2
    {
        public void SubMethod2()
        {
            Debug.Log("SubMethod2");
        }
    }

    public class SubSystem3
    {
        public void SubMethod3()
        {
            Debug.Log("SubMethod3");
        }
    }
}