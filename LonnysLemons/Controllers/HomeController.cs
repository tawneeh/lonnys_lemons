using Microsoft.AspNetCore.Mvc;

namespace LonnysLemons.Controllers
{

  public class HomeController : Controller
  {

    [HttpGet("/")] // decorator 
    public ActionResult Index() // must match .cshtml file name 
    {
      return View();
    }
  }
}