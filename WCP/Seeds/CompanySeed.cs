using WCP.Context;
using WCP.Models;

namespace WCP.Seeds
{
    public static class CompanySeed
    {
        public static void Seed(this CompanyContext dbContext)
        {
            if (dbContext.Employees.Any() || dbContext.Departments.Any()) return;

            dbContext.Employees.AddRange(
                new Employee { Name = "Rs", Birthday = new DateTime(1994, 5, 6), Department = new Department { Name = "Head" } },
                new Employee { Name = "HS", Birthday = new DateTime(1996, 5, 24), Department = new Department { Name = "Office" } }
            );

            dbContext.SaveChanges();
        }
    }
}
