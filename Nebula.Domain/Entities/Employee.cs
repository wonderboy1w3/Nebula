using Nebula.Domain.Commons;
using Nebula.Domain.Enums;

namespace Nebula.Domain;

public class Employee : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public EmployeeType Type { get; set; }
}