using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Adapter
{
    public class AdapterTester : MonoBehaviour
    {
        private void Start()
        {
            PlayerNationalA playerNationalA = new PlayerNationalA();
            playerNationalA.Attack();
            playerNationalA.Defence();

            PlayerTranslator playerTranslator = new PlayerTranslator();
            playerTranslator.Attack();
            playerTranslator.Defence();
        }
    }
}