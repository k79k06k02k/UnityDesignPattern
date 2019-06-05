using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Template
{
    public class ExamPaper
    {
        public void Test1()
        {
            Debug.Log("試題一答案: " + Answer1());
        }

        public void Test2()
        {
            Debug.Log("試題二答案: " + Answer2());
        }


        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }
    }


    public class StudentPaperA : ExamPaper
    {
        protected override string Answer1()
        {
            return "A";
        }

        protected override string Answer2()
        {
            return "C";
        }
    }

    public class StudentPaperB : ExamPaper
    {
        protected override string Answer1()
        {
            return "D";
        }

        protected override string Answer2()
        {
            return "A";
        }
    }
}