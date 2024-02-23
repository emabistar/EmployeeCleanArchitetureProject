using System;
using DomainEmployee.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ArchitectureEmployee.Data
{
	public class EmployeeContext:DbContext
	{





        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get;  set; }
         //solution to run migration on cml
        // Setup your project as startup
       // dotnet ef migrations add InitialCreate --project ArchitectureEmployee --startup-project BackendEmployeeAPi
    }
}

