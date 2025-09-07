using MemberAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Class model)
        {
            if (ModelState.IsValid)
            {
                // Handle form submission
                // e.g., save the model to the database
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
