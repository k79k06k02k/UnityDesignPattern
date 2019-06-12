using System.Collections.Generic;
using UnityEngine;

namespace DP.Builder
{
    public abstract class BuildBase
    {
        protected BuildProduct buildProduct = new BuildProduct();

        public abstract void SetupType();
        public abstract void SetupGroud();
        public abstract void SetupHeight();

        public BuildProduct GetProduct()
        {
            return buildProduct;
        }
    }

    public class BuildA : BuildBase
    {
        public override void SetupType()
        {
            buildProduct.AddPart("[BuildA] 類型: 台式三合院");
        }

        public override void SetupGroud()
        {
            buildProduct.AddPart("[BuildA] 佔地: 10公頃");
        }

        public override void SetupHeight()
        {
            buildProduct.AddPart("[BuildA] 高度: 5樓");
        }
    }

    public class BuildB : BuildBase
    {
        public override void SetupType()
        {
            buildProduct.AddPart("[BuildB] 類型: 歐式");
        }

        public override void SetupGroud()
        {
            buildProduct.AddPart("[BuildB] 佔地: 100公頃");
        }

        public override void SetupHeight()
        {
            buildProduct.AddPart("[BuildB] 高度: 3樓");
        }
    }

    public class BuildProduct
    {
        private List<string> m_parts = new List<string>();

        public void AddPart(string part)
        {
            m_parts.Add(part);
        }

        public void Show()
        {
            Debug.Log("--------------------------------------------------------------------------------");
            for (int i = 0; i < m_parts.Count; i++)
            {
                Debug.Log(m_parts[i]);
            }
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