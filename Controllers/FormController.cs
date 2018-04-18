using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Http;

namespace SurveyForm.Controllers{
    public class SurveyForm : Controller{
        [HttpGet]
        [Route("")]
        public IActionResult index(){
            return View();
        }
        [HttpPost]
        [Route("dashboard")]
        public IActionResult dashboard(string name, string location, string language, string comment){
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment; 
            return View("dashboard");
        }
    }
}