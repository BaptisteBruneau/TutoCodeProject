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
    }
}