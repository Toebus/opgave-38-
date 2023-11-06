using Microsoft.AspNetCore.Mvc;

namespace ValidateTheNameWebApplication.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View(
                "Index",
                new
                {
                    nameIsValid = false,
                    showNameEvaluation = false
                });
        }

        [HttpPost]
        public IActionResult ValidateName(string name) { 
            bool nameValidationResult = NameIsValid(name);
            return View(
                "Index",
                new
                {
                    nameIsValid = nameValidationResult,
                    showNameEvaluation = true
                });
        }

        private Boolean NameIsValid(string name){
            //Insert logic for name validation here, and return the correct boolean value true/false
            return true;
        }
    }
}
