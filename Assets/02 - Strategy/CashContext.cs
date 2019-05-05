
public enum CashType
{
    Normal,
    Rebate,
    Return
}

public class CashContext
{
    private CashBase m_cashBase;

    public CashContext(CashType cashType)
    {
        switch (cashType)
        {
            case CashType.Normal:
                m_cashBase = new CashNormal();
                break;

            case CashType.Rebate:
                m_cashBase = new CashRebate(0.8f);
                break;

            case CashType.Return:
                m_cashBase = new CashReturn(300, 100);
                break;
        }
    }

    public float GetResult(float money)
    {
        return m_cashBase.AcceptCash(money);
    }
}
