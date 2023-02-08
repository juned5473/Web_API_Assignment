using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Web_API_Assignment.Models;

namespace Web_API_Assignment.Repositories
{
    public interface IEmployeeRepository 
    {

         List<Employeeees> GetAll();
        Employeeees GetEmployeeByID(int empId);
        void InsertEmployee(Employeeees emp);
        void DeleteEmployee(int empId);
        void UpdateEmployee(Employeeees emp);
        void Save();

       
    
    }
}
