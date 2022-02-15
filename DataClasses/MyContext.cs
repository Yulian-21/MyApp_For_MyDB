using Microsoft.EntityFrameworkCore;
using System;

namespace MyADO.NetApp.DataClasses
{
    public class MyContext : DbContext
    {
        public const string ConnectionString = @"Data Source=CODLING;Initial Catalog=ITCompany;Integrated Security=True;TrustServerCertificate=True";//Trusted Connection =True;

        public DbSet<CEOs> CEOs { get; set; }
        public DbSet<ProjectManagers> ProjectManagers { get; set; }
        public DbSet<Ranks> Ranks { get; set; }
        public DbSet<RecruiteOffice> RecruiteOffice { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<WorkingMachine> WorkingMachine { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            
        }
    }
}
