using Nebula.Domain.Enums;

namespace Nebula.Service.DTOs.Employees;

public class EmployeeResultDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public EmployeeType Type { get; set; }
}