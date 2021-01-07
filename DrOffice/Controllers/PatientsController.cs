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
    private readonly DrOfficeContext _db;

    public PatientsController(DrOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Patient> model = _db.Patients.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Patient patient, int DoctorId)
    {
      _db.Patients.Add(patient);
      if (DoctorId != 0)
      {
        _db.DoctorPatient.Add(new DoctorPatient() { DoctorId = DoctorId, PatientId = patient.PatientId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisPatient = _db.Patients
          .Include(patient => patient.Doctors)
          .ThenInclude(join => join.Doctor)
          .FirstOrDefault(patient => patient.PatientId == id);
      return View(thisPatient);
    }

    public ActionResult Edit(int id)
    {
      var thisPatient = _db.Patients.FirstOrDefault(patients => patients.PatientId == id);
      ViewBag.DoctorId = new SelectList(_db.Doctors, "DoctorId", "Name");
      return View(thisPatient);
    }

    [HttpPost]
    public ActionResult Edit(Patient patient, int DoctorId)
    {
      if(DoctorId != 0)
      {
        _db.DoctorPatient.Add(new DoctorPatient() {DoctorId = DoctorId, PatientId = patient.PatientId});
      }
      
      _db.Entry(patient).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
