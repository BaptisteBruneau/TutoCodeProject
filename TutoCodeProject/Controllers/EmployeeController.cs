using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutoCodeProject.Models;
using TutoCodeProject.ViewModels;

namespace TutoCodeProject.Controllers
{
    public class EmployeeController : Controller
    {
        /// <summary>
        /// Envoi la liste des salariés à la vue Index.cshtml
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            EmployeeListViewModel empListVM = new EmployeeListViewModel();
            List<EmployeeViewModel> employeesListVM = new List<EmployeeViewModel>();

            foreach(Employee emp in new EmployeeBusinessLayer().GetEmployee())
            {
                EmployeeViewModel empVM = new EmployeeViewModel();
                empVM.EmployeeName = string.Format("{0} {1}", emp.Lastname, emp.FirstName);
                empVM.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 10000)
                    empVM.SalaryColor = "yellow";
                employeesListVM.Add(empVM);
            }

            empListVM.EmployeesList = employeesListVM;

            return View("Index", empListVM);
        }

        /// <summary>
        /// Appelle la vue "CreateEmployee"
        /// </summary>
        /// <returns></returns>
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        /// <summary>
        /// Permet de sauvegarder un employé ou revenir à la page d'accueil
        /// </summary>
        /// <param name="e">Employé à enregistrer</param>
        /// <param name="BtnSubmit">Action souhaité</param>
        /// <returns>Soit le salarié enregistré, soit reviens à la page d'accueil</returns>
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch(BtnSubmit)
            {
                case "Enregistrer":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
                        empBL.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                        //Demander à Emilien pourquoi le RedirectToAction ne garde pas les message alors que le return View oui? Qu'est ce qui est différent?
                        return View("CreateEmployee");
                case "Annuler":
                    return RedirectToAction("Index");
                default:
                    return new EmptyResult();
            }
            
        }
    }
}