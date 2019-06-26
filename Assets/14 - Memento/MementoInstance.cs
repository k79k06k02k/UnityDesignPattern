using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Memento
{
    public class Player
    {
        private int m_hp = 100;
        private int m_atk = 20;

        public PlayerMemo CreateMemo()
        {
            return new PlayerMemo(m_hp, m_atk);
        }

        public void Recovery(PlayerMemo playerMemo)
        {
            m_hp = playerMemo.Hp;
            m_atk = playerMemo.Atk;
        }

        public void Die()
        {
            m_hp = 0;
            m_atk = 0;
        }

        public void ShowLog()
        {
            Debug.LogFormat("[PlayerMemo]  Hp:{0}, Atk:{1}", m_hp, m_atk);
        }
    }

    public class PlayerMemo
    {
        public int Hp { get; set; }
        public int Atk { get; set; }

        public PlayerMemo(int hp, int atk)
        {
            Hp = hp;
            Atk = atk;
        }
    }

    public class PlayerCaretaker
    {
        public PlayerMemo PlayerMemo { get; set; }
    }
}