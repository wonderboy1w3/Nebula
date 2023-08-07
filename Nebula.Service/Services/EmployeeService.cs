using AutoMapper;
using Nebula.DAL.IRepositories;
using Nebula.DAL.Repositories;
using Nebula.Service.DTOs.Employees;
using Nebula.Service.Interfaces;
using Nebula.Service.Mappers;

namespace Nebula.Service.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public EmployeeService()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new Mapper(new MapperConfiguration(c => c.AddProfile<MappingProfile>()));
    }

    public Task<EmployeeResultDto> AddAsync(EmployeeCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EmployeeResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeResultDto> ModifyAsync(EmployeeUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }
}
