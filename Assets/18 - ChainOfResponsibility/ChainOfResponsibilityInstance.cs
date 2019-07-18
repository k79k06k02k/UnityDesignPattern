using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.ChainOfResponsibility
{
    public abstract class ManagerBase
    {
        protected string m_name;
        protected ManagerBase m_superior;


        public ManagerBase(string name)
        {
            m_name = name;
        }

        public void SetSuperior(ManagerBase superior)
        {
            m_superior = superior;
        }

        public abstract void Request(int value);
    }

    public class ManagerA : ManagerBase
    {
        public ManagerA(string name) : base(name)
        {
        }

        public override void Request(int value)
        {
            if (value < 100)
            {
                Debug.Log("Request: " + m_name);
            }
            else if (m_superior != null)
            {
                Debug.Log("Superior Request: " + m_name);
                m_superior.Request(value);
            }
        }
    }
    public class ManagerB : ManagerBase
    {
        public ManagerB(string name) : base(name)
        {
        }

        public override void Request(int value)
        {
            if (value < 20)
            {
                Debug.Log("Request: " + m_name);
            }
            else if (m_superior != null)
            {
                Debug.Log("Superior Request: " + m_name);
                m_superior.Request(value);
            }
        }
    }
    public class ManagerC : ManagerBase
    {
        public ManagerC(string name) : base(name)
        {
        }

        public override void Request(int value)
        {
            if (value < 10)
            {
                Debug.Log("Request: " + m_name);
            }
            else if (m_superior != null)
            {
                Debug.Log("Superior Request: " + m_name);
                m_superior.Request(value);
            }
        }
    }
}