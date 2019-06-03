using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Prototype
{
    public class WorkExp : ICloneable
    {
        public string date { get; set; }
        public string company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Resume : ICloneable
    {
        private string sex;
        private string age;
        private WorkExp workExp;


        public Resume()
        {
            workExp = new WorkExp();
        }

        public void SetInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExp(string date, string company)
        {
            workExp.date = date;
            workExp.company = company;
        }

        public void Display()
        {
            Debug.LogFormat("sex:{0}, age:{1}, workExp date:{2}, workExp company:{3}", sex, age, workExp.date, workExp.company);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Resume CloneDeep()
        {
            Resume resume = (Resume)Clone();
            resume.workExp = (WorkExp)workExp.Clone();
            return resume;
        }
    }
}