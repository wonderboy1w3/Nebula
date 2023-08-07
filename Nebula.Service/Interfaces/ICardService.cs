using Nebula.Service.DTOs.Cards;

namespace Nebula.Service.Interfaces;

public interface ICardService
{
    Task<CardResultDto> AddAsync(CardCreationDto dto);
    Task<CardResultDto> ModifyAsync(CardUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<CardResultDto> GetByIdAsync(long id);
    Task<IEnumerable<CardResultDto>> GetAllAsync();
}
