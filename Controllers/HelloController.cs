namespace HelloASPDotNET;

using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{


      [HttpGet]
        public IActionResult Index()
        {
        
            return View();

        }

//GET: <port>/hello/welcome
    [HttpPost]
    public IActionResult Welcome(string name = "World", string language = "english")
    {
        return Content(CreateMessage(name,language),"text/html");
    }
       public static string CreateMessage(string name, string language)
     {
         string helloTranslation = "";
         switch (language)
         {
             case "french":
                 helloTranslation = "Bonjour ";
                 break;
             case "spanish":
                 helloTranslation = "Hola ";
                 break;
             case "bosnian":
                 helloTranslation = "Zdravo ";
                 break;
             case "vietnamese":
                 helloTranslation = "Xin Chao ";
                 break;
             case "english":
                 helloTranslation = "Hello ";
                 break;
         }
         string returnStr = $"<h1>{helloTranslation}, {name}!</h1>";
         return returnStr;

     }
}
