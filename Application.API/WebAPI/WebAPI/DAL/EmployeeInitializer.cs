using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Services.Description;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{FirstName = "John", LastName = "Doe", EmpCode = "TST", Position = "Test", Office = "Test 3"}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();


        }
    }
}