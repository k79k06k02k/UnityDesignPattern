using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Strategy
{
    public abstract class CashBase
    {
        public abstract float AcceptCash(float money);
    }


    public class CashReturn : CashBase
    {
        private float m_condition;
        private float m_returnValue;


        public CashReturn(float condition, float returnValue)
        {
            m_condition = condition;
            m_returnValue = returnValue;
        }

        public override float AcceptCash(float money)
        {
            if (money >= m_condition)
            {
                return money - (int)(money / m_condition) * m_returnValue;
            }

            return money;
        }
    }

    public class CashRebate : CashBase
    {
        private float m_rate;


        public CashRebate(float rate)
        {
            m_rate = rate;
        }

        public override float AcceptCash(float money)
        {
            return money * m_rate;
        }
    }

    public class CashNormal : CashBase
    {
        public override float AcceptCash(float money)
        {
            return money;
        }
    }
}