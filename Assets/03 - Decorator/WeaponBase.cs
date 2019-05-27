using UnityEngine;

namespace DP.Decorator
{
    public abstract class WeaponBase
    {
        public abstract void AttackPower();
    }


    public class Sword : WeaponBase
    {
        public override void AttackPower()
        {
            Debug.Log("Sword");
        }
    }


    public class Knife : WeaponBase
    {
        public override void AttackPower()
        {
            Debug.Log("Knife");
        }
    }
}