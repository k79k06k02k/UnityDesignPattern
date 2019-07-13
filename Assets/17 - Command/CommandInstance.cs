using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Command
{
    public class Waiter
    {
        protected List<CommandBase> m_commands = new List<CommandBase>();


        public void SetOrder(CommandBase command)
        {
            m_commands.Add(command);
            Debug.LogFormat("增加訂單:{0} 時間:{1}", command.ToString(), DateTime.Now);
        }

        public void CancelOrder(CommandBase command)
        {
            m_commands.Remove(command);
            Debug.LogFormat("取消訂單:{0} 時間:{1}", command.ToString(), DateTime.Now);
        }

        public void Notify()
        {
            for (int i = 0; i < m_commands.Count; i++)
            {
                m_commands[i].Excute();
            }
        }
    }


    public abstract class CommandBase
    {
        protected Chef m_chef;

        public CommandBase(Chef chef)
        {
            m_chef = chef;
        }

        public abstract void Excute();
    }
    public class CommandFriedRice : CommandBase
    {
        public CommandFriedRice(Chef chef) : base(chef)
        {
        }

        public override void Excute()
        {
            m_chef.CookingFriedRice();
        }
    }
    public class CommandSoup : CommandBase
    {
        public CommandSoup(Chef chef) : base(chef)
        {
        }

        public override void Excute()
        {
            m_chef.CookingSoup();
        }
    }


    public class Chef
    {
        public void CookingFriedRice()
        {
            Debug.Log("煮炒飯");
        }

        public void CookingSoup()
        {
            Debug.Log("煮湯");
        }
    }
}