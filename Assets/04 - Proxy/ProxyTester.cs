using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Proxy
{
    public class ProxyTester : MonoBehaviour
    {
        private void Start()
        {
            ProxyGiveGift proxy = new ProxyGiveGift();

            proxy.GiveChocolate();
            proxy.GiveFlowers();
        }
    }
}