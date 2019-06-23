using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.State
{
    public class StateTester : MonoBehaviour
    {
        private void Start()
        {
            Work work = new Work();
            work.Time = 9;
            work.WorkFinish = false;
            work.SetState(new WorkStateA());

            work.Time = 10;
            work.Handler();

            work.Time = 13;
            work.Handler();

            work.Time = 17;
            work.Handler();

            work.Time = 20;
            work.WorkFinish = true;
            work.Handler();
        }
    }
}