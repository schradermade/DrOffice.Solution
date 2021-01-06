using Microsoft.AspNetCore.Mvc;
using DrOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrOffice.Controllers
{
  public class DoctorsController : Controller
  {
    private readonly DrOfficeContext _db;

    public DoctorsController(DrOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Doctor> model = _db.Doctors.ToList();
      return View(model);
    }
  }
}