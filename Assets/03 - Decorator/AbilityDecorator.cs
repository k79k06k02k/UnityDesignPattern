using UnityEngine;

namespace DP.Decorator
{
    public class AbilityDecorator : WeaponBase
    {
        private WeaponBase m_weapon;

        public void SetWeapon(WeaponBase weapon)
        {
            m_weapon = weapon;
        }

        public override void AttackPower()
        {
            if (m_weapon != null)
            {
                m_weapon.AttackPower();
            }
        }
    }


    public class AbilityFire : AbilityDecorator
    {
        public override void AttackPower()
        {
            base.AttackPower();

            Debug.Log("AbilityFire");
        }
    }

    public class AbilityLong : AbilityDecorator
    {
        private int m_size = 10;

        public override void AttackPower()
        {
            base.AttackPower();

            Debug.Log("AbilityLong: " + m_size);
        }
    }


    public class AbilityRange : AbilityDecorator
    {
        private int m_range;

        public override void AttackPower()
        {
            base.AttackPower();

            Debug.Log("AbilityRange: " + m_range);
        }

        public void SetRange(int range)
        {
            m_range = range;
        }
    }
}