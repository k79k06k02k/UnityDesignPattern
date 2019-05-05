

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
