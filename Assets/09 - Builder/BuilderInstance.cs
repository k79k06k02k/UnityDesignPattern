using UnityEngine;

namespace DP.Builder
{
    public abstract class BuildBase
    {
        public abstract void SetupType();
        public abstract void SetupGroud();
        public abstract void SetupHeight();
    }

    public class BuildA : BuildBase
    {
        public override void SetupType()
        {
            Debug.Log("[BuildA] 類型: 台式三合院");
        }

        public override void SetupGroud()
        {
            Debug.Log("[BuildA] 佔地: 10公頃");
        }

        public override void SetupHeight()
        {
            Debug.Log("[BuildA] 高度: 5樓");
        }
    }

    public class BuildB : BuildBase
    {
        public override void SetupType()
        {
            Debug.Log("[BuildB] 類型: 歐式");
        }

        public override void SetupGroud()
        {
            Debug.Log("[BuildB] 佔地: 100公頃");
        }

        public override void SetupHeight()
        {
            Debug.Log("[BuildB] 高度: 3樓");
        }
    }


    public class BuildDirect
    {
        public void CreateBuild(BuildBase build)
        {
            build.SetupType();
            build.SetupGroud();
            build.SetupHeight();
        }
    }
}