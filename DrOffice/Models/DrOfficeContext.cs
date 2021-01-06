using Microsoft.EntityFrameworkCore;

namespace DrOffice.Models
{
  public class DrOfficeContext : DbContext
  {
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    
    public DrOfficeContext(DbContextOptions options) : base(options) { }
  }
}