using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Builder
{
    public class BuilderTester : MonoBehaviour
    {

        private void Start()
        {
            BuildDirect buildDirect = new BuildDirect();

            BuildBase build = new BuildA();
            buildDirect.CreateBuild(build);

            build = new BuildB();
            buildDirect.CreateBuild(build);
        }

    }
}