using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TutoCodeProject.DataAccessLayer;

namespace TutoCodeProject.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployee()
        {
            SalesERPDAL salesDAL = new SalesERPDAL();
            return salesDAL.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDAL = new SalesERPDAL();
            salesDAL.Employees.Add(e);
            salesDAL.SaveChanges();
            return e;
        }

        public bool IsValidUser(UserDetails u)
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(u.UserName) && !string.IsNullOrEmpty(u.Password))
                isValid = u.UserName.Equals("Admin") && u.Password.Equals("Admin") ? true : false;

            return isValid;
        }
    }
}