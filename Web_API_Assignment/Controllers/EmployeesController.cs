using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Web_API_Assignment.Models;
using Web_API_Assignment.Repositories;

namespace Web_API_Assignment.Controllers
{
    [Authorize]
    [Route("api/employee")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _empRepository;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository IEmployeeRepository, IMapper mapper)
        {
            _empRepository = IEmployeeRepository;
            _mapper = mapper;
        }

        
        [HttpGet]
        public ActionResult Index()
        {
            var employees = _empRepository.GetAll();
            var empList = _mapper.Map<List<EmployeeViewModel>>(employees);
            return Ok(empList);
        }

       
        [HttpPost]
        public ActionResult Create(EmployeeViewModel emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employee = _mapper.Map<Employeeees>(emp);
                    _empRepository.InsertEmployee(employee);
                    _empRepository.Save();
                    return Ok(employee);
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again");

            }
            return Ok();
        }

      

        [HttpGet("{id}")]
        public ActionResult Edit(int id)
        {
            var employees = _empRepository.GetEmployeeByID(id);
            var employeeList = _mapper.Map<EmployeeViewModel>(employees);
            return Ok(employeeList);
        }
        [HttpPut("{id}")]
        
        public ActionResult Edit1(EmployeeViewModel emp)
        {
            int empId = emp.Id;
            var employeeList = _empRepository.GetEmployeeByID(empId);
            _mapper.Map(emp, employeeList);
            try
            {
                if (ModelState.IsValid)
                {

                    _empRepository.UpdateEmployee(employeeList);
                    _empRepository.Save();
                    return Ok(employeeList);
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again");
            }
            return Ok();
        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            try
            {
                Employeeees emp = _empRepository.GetEmployeeByID(id);
                _empRepository.DeleteEmployee(id);
                _empRepository.Save();
                return Ok(emp);

            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again");
            }
            return Ok();
        }



    }
}
