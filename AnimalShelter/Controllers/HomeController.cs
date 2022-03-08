using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter
{
  public class HomeController: Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}