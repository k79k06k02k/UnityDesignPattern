using UnityEngine;


public interface IGiveGift
{
    void GiveFlowers();
    void GiveChocolate();
}



public class Pursuit : IGiveGift
{
    public void GiveChocolate()
    {
        Debug.Log("Pursuit: Give Chocolate");
    }

    public void GiveFlowers()
    {
        Debug.Log("Pursuit: Give Flowers");
    }
}


public class ProxyGiveGift : IGiveGift
{
    private Pursuit m_pursuit;

    public ProxyGiveGift()
    {
        m_pursuit = new Pursuit();
    }

    public void GiveChocolate()
    {
        m_pursuit.GiveChocolate();
    }

    public void GiveFlowers()
    {
        m_pursuit.GiveFlowers();
    }
}