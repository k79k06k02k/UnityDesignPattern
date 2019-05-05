

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
