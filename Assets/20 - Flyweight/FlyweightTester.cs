using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Flyweight
{
    public class FlyweightTester : MonoBehaviour
    {

        private void Start()
        {
            WebsiteFactory websiteFactory = new WebsiteFactory();

            WebsiteBase websiteBase = websiteFactory.GetWebsite("Website 1");
            websiteBase.Use(new User("User AA"));

            websiteBase = websiteFactory.GetWebsite("Website 1");
            websiteBase.Use(new User("User BB"));

            websiteBase = websiteFactory.GetWebsite("Website 1");
            websiteBase.Use(new User("User CC"));

            websiteBase = websiteFactory.GetWebsite("Website 2");
            websiteBase.Use(new User("User DD"));

            websiteBase = websiteFactory.GetWebsite("Website 2");
            websiteBase.Use(new User("User EE"));

            Debug.Log("網站實體: " + websiteFactory.GetCount());
        }

    }
}