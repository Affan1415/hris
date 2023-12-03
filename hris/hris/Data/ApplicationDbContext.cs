using hris.Models.Authenticaton.login;
using hris.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


    public DbSet<loginmodel> LoginTable { get; set; }
    public DbSet<EmployeeData> EmployeeData { get; set; }
    public DbSet<ProjectData> ProjectData { get; set; }

    public DbSet<ExpenseDataModel> ExpenseData { get; set; }

    public DbSet<NotificationDataModel> NotificationData { get; set; }


}
