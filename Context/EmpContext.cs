using Microsoft.EntityFrameworkCore;
using System;
using ZeissEmpMgmt.Model;

namespace ZeissEmpMgmt.Context
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin" },
                new Role() { Id = 2, Name = "Developer" },
                new Role() { Id = 3, Name = "Scrum Master" },
                new Role() { Id = 4, Name = "QA" });

            modelBuilder.Entity<Department>().HasData(
                 new Role() { Id = 1, Name = "IT" },
                 new Role() { Id = 2, Name = "Infra" },
                 new Role() { Id = 3, Name = "Facilities" },
                 new Role() { Id = 4, Name = "Security" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    EmpId = 1,
                    FirstName = "Shailesh",
                    LastName = "Dayani",
                    CreatedAt = DateTime.Now,
                    DepartmentId = 1,
                    RoleId = 2
                },
                new Employee()
                {
                    EmpId = 2,
                    FirstName = "Fname1",
                    LastName = "LName1",
                    CreatedAt = DateTime.Now,
                    DepartmentId = 1,
                    RoleId = 3
                },
                new Employee()
                {
                    EmpId = 3,
                    FirstName = "FName4",
                    LastName = "LName4",
                    CreatedAt = DateTime.Now,
                    DepartmentId = 3,
                    RoleId = 4
                },
                new Employee()
                {
                    EmpId = 4,
                    FirstName = "FName2",
                    LastName = "LName2",
                    CreatedAt = DateTime.Now,
                    DepartmentId = 4,
                    RoleId = 1
                },
                new Employee()
                {
                    EmpId = 5,
                    FirstName = "FName3",
                    LastName = "LName3",
                    CreatedAt = DateTime.Now,
                    DepartmentId = 1,
                    RoleId = 4
                }
                );

        }
    }
}
