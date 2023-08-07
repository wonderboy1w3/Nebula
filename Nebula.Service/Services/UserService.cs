using AutoMapper;
using Nebula.DAL.IRepositories;
using Nebula.DAL.Repositories;
using Nebula.Service.DTOs.Users;
using Nebula.Service.Interfaces;
using Nebula.Service.Mappers;

namespace Nebula.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public UserService()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new Mapper(new MapperConfiguration(c => c.AddProfile<MappingProfile>()));
    }

    public Task<UserResultDto> AddAsync(UserCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserResultDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> ModifyAsync(UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }
}
