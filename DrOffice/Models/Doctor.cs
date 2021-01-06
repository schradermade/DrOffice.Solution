using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DrOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.Patients = new HashSet<DoctorPatient>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<DoctorPatient> Patients { get; set; }

  }
}
