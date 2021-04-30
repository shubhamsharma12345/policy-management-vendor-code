using PolicyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PolicyManagement.Controllers
{
    public class PolicyController : Controller
    {
        PolicyContext db = new PolicyContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserRole)
        {
            if (UserRole == "Admin")
            {
                return RedirectToAction("PolicyAdminLogin");
            }
            else if (UserRole == "Vendor")
            {
                return RedirectToAction("VendorLogin");
            }
            else if (UserRole == "User")
            {
                return RedirectToAction("UserLogin");
            }
           
            return View();
        }
        //[Authorize]
        public ActionResult PolicyAdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PolicyAdminLogin(SystemAdmin admin)
        {
            if (ModelState.IsValid)
            {
                var searchAdmin = db.PolicyAdmins.Where(x => x.UserId.Equals(admin.UserId) && x.Password.Equals(admin.Password)).FirstOrDefault();
                if (searchAdmin != null)
                {
                    FormsAuthentication.SetAuthCookie(admin.UserId, true);
                    return RedirectToAction("AdminHomePage");
                }
                else
                {
                    ViewBag.LoginMessage = "Unregistered Admin or Wrong Credentials";
                }
            }
            return RedirectToAction("AdminHomePage");
        }

        public ActionResult PolicyAdminRegister()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PolicyAdminRegister(PolicyAdmin admin)
        {  
            db.PolicyAdmins.Add(admin);
            db.SaveChanges();
            ViewBag.AdminRegistration = "Registration Successful.";
            return View();
        }





        public ActionResult SystemAdminLogin()
        {
            return View();
        }
        public ActionResult VendorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VendorLogin(SystemAdmin admin)
        {
            if (ModelState.IsValid)
            {
                var searchAdmin = db.PolicyVendors.Where(x => x.PolicyVendorRegNo.Equals(admin.UserId) && x.Password.Equals(admin.Password)).FirstOrDefault();
                //&& x.VendorStatus==1).FirstOrDefault();

                if (searchAdmin != null)
                {
                    FormsAuthentication.SetAuthCookie(admin.UserId, true);
                    return RedirectToAction("PolicyVendorHome");
                }
                else 
                {
                    ViewBag.LoginMessage = "Your account hasn't been verified yet";
                }
            }
            return View();

        }
        public ActionResult VerifiedMsg()
        {
            return View();
        }
        public ActionResult PolicyVendorRegister()
        {

            return View();
        }

        [HttpPost]
        public ActionResult PolicyVendorRegister(PolicyVendor vendor)
        {
            vendor.VendorStatus = 0;
            db.PolicyVendors.Add(vendor);
            db.SaveChanges();
            ViewBag.VendorRegister = "Registration Successful.";
            return RedirectToAction("VerifiedMsg");
        }
        public ActionResult PolicyVendorHome()
        {
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        public ActionResult PolicyUserRegister()
        {

            return View();
        }

        public ActionResult AdminHomePage()
        {
            var vendors = db.PolicyVendors.ToList();
            return View(vendors);
            
        }
        public ViewResult Details(string id)
        {
            PolicyVendor vendor =
              db.PolicyVendors.Where(x => x.PolicyVendorRegNo == id).SingleOrDefault();
            return View(vendor);
        }

        public ActionResult Edit(string id)
        {
            PolicyVendor vendor = db.PolicyVendors.Where(
              x => x.PolicyVendorRegNo == id).SingleOrDefault();
            return View(vendor);
        }
        [HttpPost]
        public ActionResult Edit(PolicyVendor model)
        {
            PolicyVendor vendor = db.PolicyVendors.Where(
              x => x.PolicyVendorRegNo == model.PolicyVendorRegNo).SingleOrDefault();
            if (vendor != null)
            {
                db.Entry(vendor).CurrentValues.SetValues(model);
                //Console.WriteLine("adasasdasdasadsa");
                db.SaveChanges();
                return RedirectToAction("AdminHomePage");
            }
            return View(model);
        }
    }
}
