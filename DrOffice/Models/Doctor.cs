using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DrOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      //this.Courses = new HashSet<CourseStudent>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }

    //public ICollection<DoctorPatient> Doctors { get; }
  }
}
