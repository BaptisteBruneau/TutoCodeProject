using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TutoCodeProject.Models;
namespace TutoCodeProject.Controllers
{
    public class AuthentificationController : Controller
    {
        // GET: Authentification
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            if(ModelState.IsValid)
            {
                EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
                if (empBL.IsValidUser(u))
                {
                    FormsAuthentication.SetAuthCookie(u.UserName, false);
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Le login ou le mot de passe est invalide");
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}