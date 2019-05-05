using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyTester : MonoBehaviour
{
    public CashType cashType;
    public float money;

    private void Start()
    {
        CashContext cashContext = new CashContext(cashType);
        float result = cashContext.GetResult(money);

        Debug.Log(result);
    }
}
