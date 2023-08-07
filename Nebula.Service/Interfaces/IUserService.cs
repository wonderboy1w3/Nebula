using Nebula.Service.DTOs.Users;

namespace Nebula.Service.Interfaces;

public interface IUserService
{
    Task<UserResultDto> AddAsync(UserCreationDto dto);
    Task<UserResultDto> ModifyAsync(UserUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<UserResultDto> GetByIdAsync(long id);
    Task<IEnumerable<UserResultDto>> GetAllAsync();
}