using Nebula.Domain.Enums;

namespace Nebula.Service.DTOs.Cards;

public class CardUpdateDto
{
    public long Id { get; set; }
    public string Number { get; set; }
    public DateTime ExpireDate { get; set; }
    public CardType Type { get; set; }
    public long UserId { get; set; }
}
