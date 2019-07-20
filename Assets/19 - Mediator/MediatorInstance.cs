using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Mediator
{
    public abstract class CountryMediatorBase
    {
        public abstract void Declare(string message, CountryBase country);
    }
    public class CountryMediatorA : CountryMediatorBase
    {
        private USA m_countryUSA;
        public USA countryUSA { set { m_countryUSA = value; } }

        private Taiwan m_countryTaiwan;
        public Taiwan countryTaiwan { set { m_countryTaiwan = value; } }

        public override void Declare(string message, CountryBase country)
        {
            if (country == m_countryUSA)
            {
                m_countryUSA.ShowMessage(message);
            }
            else
            {
                m_countryTaiwan.ShowMessage(message);
            }
        }
    }



    public abstract class CountryBase
    {
        protected CountryMediatorBase m_mediator;

        public CountryBase(CountryMediatorBase mediator)
        {
            m_mediator = mediator;
        }
    }
    public class USA : CountryBase
    {
        public USA(CountryMediatorBase mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            m_mediator.Declare(message, this);
        }

        public void ShowMessage(string message)
        {
            Debug.Log("USA: " + message);
        }
    }
    public class Taiwan : CountryBase
    {
        public Taiwan(CountryMediatorBase mediator) : base(mediator)
        {
        }

        public void Declare(string message)
        {
            m_mediator.Declare(message, this);
        }

        public void ShowMessage(string message)
        {
            Debug.Log("Taiwan: " + message);
        }
    }
}