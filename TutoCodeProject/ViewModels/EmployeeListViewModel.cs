using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutoCodeProject.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> EmployeesList { get; set; }
        public string UserName { get; set; }
    }
}