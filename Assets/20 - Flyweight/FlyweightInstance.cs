using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Flyweight
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }


    public abstract class WebsiteBase
    {
        protected string m_name;

        public WebsiteBase(string name)
        {
            m_name = name;
        }

        public abstract void Use(User user);
    }
    public class WebsiteInstance : WebsiteBase
    {
        public WebsiteInstance(string name) : base(name)
        {
        }

        public override void Use(User user)
        {
            Debug.LogFormat("網站名稱:{0}, 使用者:{1}", m_name, user.Name);
        }
    }


    public class WebsiteFactory
    {
        private Hashtable m_flyweights = new Hashtable();


        public WebsiteBase GetWebsite(string key)
        {
            if (m_flyweights.ContainsKey(key) == false)
            {
                m_flyweights.Add(key, new WebsiteInstance(key));
            }

            return (WebsiteInstance)m_flyweights[key];
        }

        public int GetCount()
        {
            return m_flyweights.Count;
        }
    }
}