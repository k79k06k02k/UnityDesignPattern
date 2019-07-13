using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Command
{
    public class CommandTester : MonoBehaviour
    {

        private void Start()
        {
            Waiter waiter = new Waiter();
            Chef chef = new Chef();
            CommandFriedRice commandFriedRice = new CommandFriedRice(chef);
            CommandSoup commandSoup = new CommandSoup(chef);

            waiter.SetOrder(commandFriedRice);
            waiter.SetOrder(commandSoup);
            waiter.SetOrder(commandSoup);
            waiter.SetOrder(commandFriedRice);
            waiter.CancelOrder(commandFriedRice);
            waiter.SetOrder(commandFriedRice);

            waiter.Notify();
        }

    }
}