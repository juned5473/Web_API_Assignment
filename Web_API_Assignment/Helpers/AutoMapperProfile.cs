using AutoMapper;
using Web_API_Assignment.Models;

namespace Web_API_Assignment.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employeeees, EmployeeViewModel>().ReverseMap();
        }
    }
}
