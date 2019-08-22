using ERMSApplication.DBModel;
using ERMSApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERMSApplication.Controllers
{
    public class AccountController : Controller
    {
        EnterpriseResourceMngtDBEntities objERMDBEntities = new EnterpriseResourceMngtDBEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            UserModel userModel = new UserModel();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                User objUser = new DBModel.User();
                objUser.CreatedOn = DateTime.Now;
                objUser.Firstname = userModel.Firstname;
                objUser.Lastname = userModel.Lastname;
                objUser.Email = userModel.Email;
                objUser.Password = userModel.Password;
                objERMDBEntities.Users.Add(objUser);
                objERMDBEntities.SaveChanges();
                userModel = new UserModel();
                userModel.SuccessMessage = "User is Successfully Registered!!";
                return View("Register");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}