using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        
        // GET: /helloworld/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
            "<input type='text' name='name' />" +
            "<select name='language'> <option value='Hello'>English</option> <option value='Bonjour'>French</option>\" <option value='Hola'>Spanish</option>\"<option value='Ni Hao'>Mandarin</option>\"<option value='Ciao'>Italian</option>\" </select>" +

            "<input type='submit' value='Greet Me!' />" +
            "</form>";
            return Content(html, "text/html");
        }
        //GET: /helloworld/welcome
        //POST: /helloworld/welcome
        //[HttpPost("welcome")]
        //[HttpGet("welcome/{name?}")]
        //public IActionResult Welcome(string name, string language)
        //{


        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}
        [HttpPost("welcome")]
        [HttpGet("welcome/{name?}/{language?}")]
        public IActionResult CreateMessage(string name = "Patrick", string language = "Sup")
        {

           // string html = "<h1>{language}" + "{name}!</h1>";
            return Content($"<h1>{language}, {name}!</h1>", "text/html");
            //string hello = "";
            //switch (language)
            //{
            //    case "English":
            //        hello = "hello ";
            //        break;
            //    case "French":
            //        hello = "Bonjour ";
            //        break;
            //    case "Spanish":
            //        hello = "Hola ";
            //        break;
            //    case "Mandarin":
            //        hello = "Ni Hao";
            //        break;
            //    case "Italian":
            //        hello = "Ciao";
            //        break;

            //}
            //return hello + name;
        }
    }
}
