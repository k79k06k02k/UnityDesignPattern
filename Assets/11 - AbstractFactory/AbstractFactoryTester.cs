using UnityEngine;

namespace DP.AbstractFactory
{
    public class AbstractFactoryTester : MonoBehaviour
    {
        private void Start()
        {
            //IFactory factory = new SqlServerFactory();
            IFactory factory = new AccessFactory();

            IUser user = factory.CreateUser();
            user.Insert();
            user.Get();

            IDepartment department = factory.CreateDepartment();
            department.Insert();
            department.Get();
        }
    }
}