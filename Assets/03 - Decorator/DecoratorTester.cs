using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Decorator
{
    public class DecoratorTester : MonoBehaviour
    {
        private void Start()
        {
            Sword weapon = new Sword();

            AbilityFire abilityFire = new AbilityFire();
            abilityFire.SetWeapon(weapon);

            AbilityLong abilityLong = new AbilityLong();
            abilityLong.SetWeapon(abilityFire);

            AbilityRange abilityRange = new AbilityRange();
            abilityRange.SetWeapon(abilityLong);
            abilityRange.SetRange(30);

            abilityRange.AttackPower();
        }
    }
}