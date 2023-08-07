using Nebula.Service.DTOs.Employees;

namespace Nebula.Service.Interfaces;

public interface IEmployeeService
{
    Task<EmployeeResultDto> AddAsync(EmployeeCreationDto dto);
    Task<EmployeeResultDto> ModifyAsync(EmployeeUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<EmployeeResultDto> GetByIdAsync(long id);
    Task<IEnumerable<EmployeeResultDto>> GetAllAsync();
}
