using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Web_API_Assignment.Data;
using Web_API_Assignment.Models;

namespace Web_API_Assignment.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
     
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
            
        }

        public void DeleteEmployee(int Id)
        {
            var emp = _context.Employeee.Find(Id);
            _context.Employeee.Remove(emp!);
        }

        public List<Employeeees> GetAll()
        {
            return _context.Employeee.ToList();
        }

        public Employeeees GetEmployeeByID(int Id)
        {
            return _context.Employeee.Where(x => x.Id == Id).FirstOrDefault()!;
        }

        public void InsertEmployee(Employeeees emp)
        {
            _context.Employeee.Add(emp);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employeeees emp)
        {
            _context.Employeee.Update(emp);
        }

        
    }
}
