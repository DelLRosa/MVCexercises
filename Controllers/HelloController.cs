namespace HelloASPDotNET;
using Microsoft.AspNetCore.Mvc;


public class HelloController : Controller
{

    //GET: <port>/helloworld/
   [HttpGet]
   [Route("/helloworld")]
    public IActionResult Index()
    {
        string html = "<form method='post' action='/helloworld/welcome'>" +
         "<input type='text' name='name' />" +
         "<input type='submit' value='Greet Me!' />" +
         "</form>";
        return Content(html, "text/html");
    }

//GET: <port>/hello/welcome
    [HttpPost]
    [Route("/helloworld/welcome")]
    public IActionResult Welcome(string name = "World")
    {
        return Content("<h1>Welcome to my app, "+name+"!</h1>", "text/html");
    }

}
