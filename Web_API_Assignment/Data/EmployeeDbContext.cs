using Microsoft.EntityFrameworkCore;
using Web_API_Assignment.Models;

namespace Web_API_Assignment.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employeeees> Employeee { get; set; }
        public DbSet<LoginInfo> EmployeeInfo { get; set; }

    }
}
