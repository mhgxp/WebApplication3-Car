using AutoMapper;
using Car.Entity;
using Car.Services;
using Microsoft.AspNetCore.Mvc;



namespace Car.DTO
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>();
        }
        
    }
}
