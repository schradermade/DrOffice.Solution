using Microsoft.AspNetCore.Mvc;
using DrOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrOffice.Controllers
{
  public class PatientsController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}