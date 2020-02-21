using BusApplication.DAL;
using BusApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusApplication.Controllers
{
    public class BusAppController : Controller
    {
        // GET: BusApp
        BusRepository busRepository = new BusRepository();
        public ActionResult Index()
        {
            IEnumerable<Customer> userList = busRepository.UserDetailDisplay();
            return View(userList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.userName))
            {
                ModelState.AddModelError("userName", "Required");
            }
            if (string.IsNullOrEmpty(customer.userGender))
            {
                ModelState.AddModelError("userGender", "Required");
            }
            if (string.IsNullOrEmpty((customer.userPhone).ToString()))
            {
                ModelState.AddModelError("userPhone", "Required");
            }
            if (string.IsNullOrEmpty((customer.country).ToString()))
            {
                ModelState.AddModelError("country", "Required");
            }
            if (string.IsNullOrEmpty(customer.userId))
            {
                ModelState.AddModelError("userId", "Required");
            }
            if(string.IsNullOrEmpty(customer.userPassword))
            {
                ModelState.AddModelError("userPassword", "Required");
            }
            if(ModelState.IsValid)
            {
                TryUpdateModel(customer);
                busRepository.AddUser(customer);
                TempData["Message"] = "Welcome";

                return RedirectToAction("Login", "BusApp");
            }
            return View();
        }
        public ActionResult Demo()
        {
            return PartialView();
        }

        public ActionResult Login()
        {
            return View();

            /*Customer customer = new Customer();
            TryUpdateModel(customer);
            int count = busRepository.Check(customer);

            if (count==1)
            {
                TempData["Message"] = "Welcome";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }*/
        }
    }
}