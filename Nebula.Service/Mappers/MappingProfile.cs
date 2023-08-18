using AutoMapper;
using Nebula.Domain;
using Nebula.Service.DTOs.Cards;
using Nebula.Service.DTOs.Employees;
using Nebula.Service.DTOs.Users;

namespace Nebula.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User
        CreateMap<User, UserCreationDto>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<UserResultDto, User>().ReverseMap();

        // Employee
        CreateMap<Employee, EmployeeCreationDto>().ReverseMap();
        CreateMap<EmployeeUpdateDto, Employee>().ReverseMap();
        CreateMap<EmployeeResultDto, Employee>().ReverseMap();

        // Card
        CreateMap<Card, CardCreationDto>().ReverseMap();
        CreateMap<CardUpdateDto, Card>().ReverseMap();
        CreateMap<CardResultDto, Card>().ReverseMap();
    }
}
