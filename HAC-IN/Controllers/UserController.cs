using HAC_IN.Models;
using Microsoft.AspNetCore.Mvc;

namespace HAC_IN.Controllers
{
    public class UserController : Controller
    {
        // Methods

        // Create

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User u)
        {
            return RedirectToAction("Details", u);
        }

        // Read
        public IActionResult Details(User u)
        {
            return View(u);
        }

        // Update
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User u = new User();
            u.Huntid = id;
            u.Firstname = "Joshua";
            u.Lastname = "Applegarth";
            u.Phone = "3476758901";
            u.Email = "joshua.applegarth@outlook.com";
            u.Password = "qazQAZ1!";
            u.Role = "Admin";
            u.TAid = 0;
            u.TAdate = null;
            return View(u);
        }
        [HttpPost]
        public IActionResult Edit(User u)
        {
            return RedirectToAction("Details", u);
        }

        // Delete

    }
}
