using Nebula.Domain.Enums;
using Nebula.Service.DTOs.Users;

namespace Nebula.Service.DTOs.Cards;

public class CardResultDto
{
    public long Id { get; set; }
    public string Number { get; set; }
    public DateTime ExpireDate { get; set; }
    public CardType Type { get; set; }
    public UserResultDto User { get; set; }
}