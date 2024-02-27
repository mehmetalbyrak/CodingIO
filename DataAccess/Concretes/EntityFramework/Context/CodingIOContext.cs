using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework.Context;

public class CodingIOContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder
            .UseSqlServer("Server=localhost,1433;Database=CodingIO;" +
                          "User Id=SA;Password=reallyStrongPwd123;" +
                          "Trusted_Connection=false;TrustServerCertificate=True;" +
                          "MultiSubnetFailover=True"));  
    }

    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Category> Categories { get; set; }
}