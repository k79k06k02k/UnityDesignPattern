using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Mediator
{
    public class MediatorTester : MonoBehaviour
    {

        private void Start()
        {
            CountryMediatorA countryMediatorA = new CountryMediatorA();

            USA usa = new USA(countryMediatorA);
            Taiwan taiwan = new Taiwan(countryMediatorA);

            countryMediatorA.countryUSA = usa;
            countryMediatorA.countryTaiwan = taiwan;

            usa.Declare("Hello");
            taiwan.Declare("Hey");
        }

    }
}