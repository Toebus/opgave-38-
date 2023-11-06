using Microsoft.AspNetCore.Mvc;
using ValidateTheNameModelBinding.Models;

namespace ValidateTheNameWebApplication.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new { nameIsValid = false, showNameEvaluation = false });
        }

        [HttpPost]
        public IActionResult ValidateName(PersonDTO person)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", new {nameIsValid = false, showNameEvaluation = true });
            }

            return View("Index", new { nameIsValid = true, showNameEvaluation = true });


        }

       
    }
}
