using UnityEngine;

namespace DP.Adapter
{
    public interface IPlayer
    {
        void Attack();
        void Defence();
    }

    public class PlayerNationalA : IPlayer
    {
        public void Attack()
        {
            Debug.Log("NationalA Attack");
        }

        public void Defence()
        {
            Debug.Log("NationalA Defence");
        }
    }

    public class PlayerNationalB : IPlayer
    {
        public void Attack()
        {
            Debug.Log("NationalB Attack");
        }

        public void Defence()
        {
            Debug.Log("NationalB Defence");
        }
    }

    public class PlayerTranslator : IPlayer
    {
        private PlayerForeignerA playerForeignerA = new PlayerForeignerA();

        public void Attack()
        {
            playerForeignerA.ForeignerAttack();
        }

        public void Defence()
        {
            playerForeignerA.ForeignerDefence();
        }
    }

    public class PlayerForeignerA
    {
        public void ForeignerAttack()
        {
            Debug.Log("Foreigner Attack");
        }

        public void ForeignerDefence()
        {
            Debug.Log("Foreigner Defence");
        }
    }
}