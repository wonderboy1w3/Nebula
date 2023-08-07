using Nebula.Domain.Commons;
using Nebula.Domain.Enums;

namespace Nebula.Domain;

public class Card : Auditable
{
    public string Number { get; set; }
    public bool IsActive { get; set; }
    public DateTime ExpireDate { get; set; }
    public CardType Type { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}