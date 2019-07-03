using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DP.Composite
{
    public class CompositeTester : MonoBehaviour
    {
        private void Start()
        {
            ConcreteCompany root = new ConcreteCompany("總公司");
            root.Add(new FinanceDepartment("總公司財務部門"));
            root.Add(new HRDepartment("總公司HR部門"));

            ConcreteCompany branchAmerican = new ConcreteCompany("美國分公司");
            branchAmerican.Add(new FinanceDepartment("美國分公司財務部門"));
            branchAmerican.Add(new HRDepartment("美國分公司HR部門"));
            root.Add(branchAmerican);

            ConcreteCompany branchCalifornia = new ConcreteCompany("加州辦事處");
            branchCalifornia.Add(new FinanceDepartment("加州辦事處財務部門"));
            branchCalifornia.Add(new HRDepartment("加州辦事處HR部門"));
            branchAmerican.Add(branchCalifornia);

            ConcreteCompany branchNewYork = new ConcreteCompany("紐約辦事處");
            branchNewYork.Add(new FinanceDepartment("紐約辦事處財務部門"));
            branchNewYork.Add(new HRDepartment("紐約辦事處HR部門"));
            branchAmerican.Add(branchNewYork);

            Debug.Log("組織結構：");
            root.Display(1);

            Debug.Log("職責：");
            root.LineOfDuty();
        }
    }
}