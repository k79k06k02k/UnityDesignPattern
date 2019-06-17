
using System.Collections.Generic;
using UnityEngine;

namespace DP.Observer
{
    public class SubjectBase
    {
        private IList<ObserverBase> m_observers = new List<ObserverBase>();
        public string status { get; set; }

        public void Add(ObserverBase observer)
        {
            m_observers.Add(observer);
        }

        public void Remove(ObserverBase observer)
        {
            m_observers.Remove(observer);
        }

        public void Notify()
        {
            for (int i = 0; i < m_observers.Count; i++)
            {
                m_observers[i].Update();
            }
        }
    }
    public class SubjectA : SubjectBase
    {
    }


    public abstract class ObserverBase
    {
        protected SubjectBase m_subject { get; set; }

        public ObserverBase(SubjectBase subject)
        {
            m_subject = subject;
        }
        public abstract void Update();
    }
    public class ObserverA : ObserverBase
    {
        public ObserverA(SubjectBase subject) : base(subject) { }

        public override void Update()
        {
            Debug.Log("ObserverA Update: " + m_subject.status);
        }
    }
    public class ObserverB : ObserverBase
    {
        public ObserverB(SubjectBase subject) : base(subject) { }

        public override void Update()
        {
            Debug.Log("ObserverB Update: " + m_subject.status);
        }
    }
}