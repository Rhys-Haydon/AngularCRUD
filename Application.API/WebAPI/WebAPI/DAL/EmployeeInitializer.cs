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

            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();


        }
    }
}