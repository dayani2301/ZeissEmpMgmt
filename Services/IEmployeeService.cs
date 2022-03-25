using System.Collections.Generic;
using ZeissEmpMgmt.Model;

namespace ZeissEmpMgmt.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees(string? name);
        void Save(Employee employee);
    }
}
