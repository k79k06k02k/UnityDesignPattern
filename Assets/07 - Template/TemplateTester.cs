using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Template
{
    public class TemplateTester : MonoBehaviour
    {
        private void Start()
        {
            StudentPaperA studentPaperA = new StudentPaperA();
            studentPaperA.Test1();
            studentPaperA.Test2();

            StudentPaperB studentPaperB = new StudentPaperB();
            studentPaperB.Test1();
            studentPaperB.Test2();
        }
    }
}