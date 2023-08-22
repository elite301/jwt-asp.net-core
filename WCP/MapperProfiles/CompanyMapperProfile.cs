using AutoMapper;
using WCP.Dtos;
using WCP.Models;

namespace WCP.MapperProfiles
{
    public class CompanyMapperProfile: Profile
    {
        public CompanyMapperProfile() {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
