using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ZeissEmpMgmt.Context;
using ZeissEmpMgmt.Model;

namespace ZeissEmpMgmt.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;
        public EmployeeService(EmpContext context)
        {
            _context = context;
        }
        public List<Employee> GetEmployees(string? name)
        {
            IQueryable<Employee> employees = _context.Employees.Include(x => x.Role).Include(y => y.Department);

            if (!string.IsNullOrEmpty(name))
            {
                return employees.Where(x => x.FirstName.ToUpper().Equals(name.ToUpper()) || x.LastName.ToUpper().Equals(name.ToUpper())).ToList<Employee>();
            }

            else
            {
                return employees.ToList();
            }
        }

        public void Save(Employee employee)
        {

            _context.Employees.Add(new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                RoleId = employee.RoleId,
                DepartmentId = employee.DepartmentId,
                CreatedAt = DateTime.Now
            });
            _context.SaveChanges();
        }
    }
}
