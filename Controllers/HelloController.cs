namespace HelloASPDotNET;

using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

[Route("/helloworld")]
public class HelloController : Controller
{

    //GET: <port>/helloworld/
      [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='bosnian'>Bosnian</option>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='french'>French</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

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
