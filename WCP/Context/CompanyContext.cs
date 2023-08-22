using Microsoft.EntityFrameworkCore;
using WCP.Models;

namespace WCP.Context
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
