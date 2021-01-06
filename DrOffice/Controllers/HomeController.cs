using Microsoft.AspNetCore.Mvc;
using DrOffice.Models;
using System.Collections.Generic;

namespace DrOffice.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}