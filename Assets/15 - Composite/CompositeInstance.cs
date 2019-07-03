using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Composite
{
    public abstract class Company
    {
        protected string m_name;

        public Company(string name)
        {
            m_name = name;
        }

        public abstract void Add(Company company);
        public abstract void Remove(Company company);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }

    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name) { }

        public override void Add(Company company) { }

        public override void Remove(Company company) { }

        public override void Display(int depth)
        {
            string result = string.Empty;
            for (int i = 0; i < depth; i++)
            {
                result += "-";
            }

            Debug.Log(result += m_name);
        }

        public override void LineOfDuty()
        {
            Debug.LogFormat("{0} 公司財務管理", m_name);
        }
    }
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name) { }

        public override void Add(Company company) { }

        public override void Remove(Company company) { }

        public override void Display(int depth)
        {
            string result = string.Empty;
            for (int i = 0; i < depth; i++)
            {
                result += "-";
            }

            Debug.Log(result += m_name);
        }

        public override void LineOfDuty()
        {
            Debug.LogFormat("{0} 員工招聘與教育訓練", m_name);
        }
    }
    public class ConcreteCompany : Company
    {
        private List<Company> m_companies = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            m_companies.Add(company);
        }

        public override void Remove(Company company)
        {
            m_companies.Remove(company);
        }


        public override void Display(int depth)
        {
            string result = string.Empty;
            for (int i = 0; i < depth; i++)
            {
                result += "-";
            }

            Debug.Log(result += m_name);


            for (int i = 0; i < m_companies.Count; i++)
            {
                m_companies[i].Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            for (int i = 0; i < m_companies.Count; i++)
            {
                m_companies[i].LineOfDuty();
            }
        }
    }
}
