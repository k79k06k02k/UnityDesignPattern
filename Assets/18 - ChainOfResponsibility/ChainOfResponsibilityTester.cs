using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.ChainOfResponsibility
{
    public class ChainOfResponsibilityTester : MonoBehaviour
    {

        private void Start()
        {
            ManagerA managerA = new ManagerA("管理者 A 級");
            ManagerB managerB = new ManagerB("管理者 B 級");
            ManagerC managerC = new ManagerC("管理者 C 級");

            managerC.SetSuperior(managerB);
            managerB.SetSuperior(managerA);

            managerC.Request(7);
            Debug.Log("--------------------------------------");

            managerC.Request(13);
            Debug.Log("--------------------------------------");

            managerC.Request(22);
            Debug.Log("--------------------------------------");

            managerC.Request(50);
            Debug.Log("--------------------------------------");
        }

    }
}