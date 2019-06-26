using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Memento
{
    public class MementoTester : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            player.ShowLog();

            PlayerCaretaker playerCaretaker = new PlayerCaretaker();
            playerCaretaker.PlayerMemo = player.CreateMemo();

            player.Die();
            player.ShowLog();

            player.Recovery(playerCaretaker.PlayerMemo);
            player.ShowLog();
        }
    }
}