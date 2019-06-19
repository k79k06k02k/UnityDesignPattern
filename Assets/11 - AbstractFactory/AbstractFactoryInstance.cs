using UnityEngine;

namespace DP.AbstractFactory
{
    public interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
    public class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }


    public interface IUser
    {
        void Insert();
        void Get();
    }
    public class SqlServerUser : IUser
    {
        public void Get()
        {
            Debug.Log("Get SqlServerUser");
        }

        public void Insert()
        {
            Debug.Log("Insert SqlServerUser");
        }
    }
    public class AccessUser : IUser
    {
        public void Get()
        {
            Debug.Log("Get AccessUser");
        }

        public void Insert()
        {
            Debug.Log("Insert AccessUser");
        }
    }


    public interface IDepartment
    {
        void Insert();
        void Get();
    }
    public class SqlServerDepartment : IDepartment
    {
        public void Get()
        {
            Debug.Log("Get SqlServerDepartment");
        }

        public void Insert()
        {
            Debug.Log("Insert SqlServerDepartment");
        }
    }
    public class AccessDepartment : IDepartment
    {
        public void Get()
        {
            Debug.Log("Get AccessDepartment");
        }

        public void Insert()
        {
            Debug.Log("Insert AccessDepartment");
        }
    }
}