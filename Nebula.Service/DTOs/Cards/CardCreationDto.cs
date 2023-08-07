using Nebula.Domain.Enums;

namespace Nebula.Service.DTOs.Cards;

public class CardCreationDto
{
    public CardType Type { get; set; }
    public long UserId { get; set; }
}
