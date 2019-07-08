using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Bridge
{
    public class BridgeTester : MonoBehaviour
    {

        private void Start()
        {
            MobileBrandBase mobileBrandBase = new MobileBrandA();

            mobileBrandBase.SetSoftwave(new MobileSoftwareGame());
            mobileBrandBase.Run();

            mobileBrandBase.SetSoftwave(new MobileSoftwareAddressList());
            mobileBrandBase.Run();



            mobileBrandBase = new MobileBrandB();

            mobileBrandBase.SetSoftwave(new MobileSoftwareGame());
            mobileBrandBase.Run();

            mobileBrandBase.SetSoftwave(new MobileSoftwareAddressList());
            mobileBrandBase.Run();
        }

    }
}