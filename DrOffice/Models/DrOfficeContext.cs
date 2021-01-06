using Microsoft.EntityFrameworkCore;

namespace DrOffice.Models
{
  public class DrOfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    //public DbSet<DoctorPatient> DoctorPatient { get; set; }
    
    public DrOfficeContext(DbContextOptions options) : base(options) { }
  }
}