using Microsoft.EntityFrameworkCore;
using WebApi.Models;



namespace WebApi.Controllers
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
