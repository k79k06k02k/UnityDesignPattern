using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Bridge
{
    public abstract class MobileBrandBase
    {
        protected MobileSoftwareBase m_mobileSoftwareBase;

        public void SetSoftwave(MobileSoftwareBase soft)
        {
            m_mobileSoftwareBase = soft;
        }

        public abstract void Run();
    }
    public class MobileBrandA : MobileBrandBase
    {
        public override void Run()
        {
            Debug.Log("MobileBrandA Run");
            m_mobileSoftwareBase.Run();
        }
    }
    public class MobileBrandB : MobileBrandBase
    {
        public override void Run()
        {
            Debug.Log("MobileBrandB Run");
            m_mobileSoftwareBase.Run();
        }
    }


    public abstract class MobileSoftwareBase
    {
        public abstract void Run();
    }
    public class MobileSoftwareGame : MobileSoftwareBase
    {
        public override void Run()
        {
            Debug.Log("MobileSoftwareGame Run");
        }
    }
    public class MobileSoftwareAddressList : MobileSoftwareBase
    {
        public override void Run()
        {
            Debug.Log("MobileSoftwareAddressList Run");
        }
    }
}