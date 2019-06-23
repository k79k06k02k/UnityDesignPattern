using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.State
{
    public class Work
    {
        public int Time { get; set; }
        public bool WorkFinish { get; set; }

        private WorkStateBase m_workStateBase;

        public void SetState(WorkStateBase state)
        {
            m_workStateBase = state;
        }

        public void Handler()
        {
            m_workStateBase.Handler(this);
        }
    }


    public abstract class WorkStateBase
    {
        public abstract void Handler(Work work);
    }
    public class WorkStateA : WorkStateBase
    {
        public override void Handler(Work work)
        {
            if (work.Time > 10)
            {
                Debug.Log("To WorkStateB");
                work.SetState(new WorkStateB());
                work.Handler();
            }
            else
            {
                Debug.Log("Keep WorkStateA");
            }
        }
    }
    public class WorkStateB : WorkStateBase
    {
        public override void Handler(Work work)
        {
            if (work.Time > 15)
            {
                Debug.Log("To WorkStateC");
                work.SetState(new WorkStateC());
                work.Handler();
            }
            else
            {
                Debug.Log("Keep WorkStateB");
            }
        }
    }
    public class WorkStateC : WorkStateBase
    {
        public override void Handler(Work work)
        {
            if (work.WorkFinish)
            {
                Debug.Log("WorkFinish");
            }
        }
    }
}