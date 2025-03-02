using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HRMS.Models;

namespace HRMS.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

public DbSet<HRMS.Models.Level> Level { get; set; } = default!;

public DbSet<HRMS.Models.Department> Department { get; set; } = default!;

public DbSet<HRMS.Models.Employee> Employee { get; set; } = default!;

public DbSet<HRMS.Models.Cultivation> Cultivation { get; set; } = default!;

public DbSet<HRMS.Models.Attendance> Attendance { get; set; } = default!;

public DbSet<HRMS.Models.Recruitment> Recruitment { get; set; } = default!;
}
