using Nebula.Domain.Enums;

namespace Nebula.Service.DTOs.Employees;

public class EmployeeCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public EmployeeType Type { get; set; }
}
