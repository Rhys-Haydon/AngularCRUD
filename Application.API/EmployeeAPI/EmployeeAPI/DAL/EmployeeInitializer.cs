using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using EmployeeAPI.Models;

namespace EmployeeAPI.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{FirstName = "John", LastName = "Doe", EmpCode = "TST", Position = "AO4", Office = "Test1"}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}