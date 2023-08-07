using Nebula.Domain.Commons;
using System.Collections;

namespace Nebula.Domain;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public ICollection<Card> Cards { get; set; }
}