using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
   
    public class HelloController : Controller
    {
        
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("/hello")]

        public IActionResult Welcome(string name)
        {
            ViewBag.person = name;
            return View();
        }
    }
}
