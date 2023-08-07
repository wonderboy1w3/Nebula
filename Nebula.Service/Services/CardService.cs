using AutoMapper;
using Nebula.Domain;
using Nebula.Service.Mappers;
using Nebula.DAL.Repositories;
using Nebula.DAL.IRepositories;
using Nebula.Service.DTOs.Users;
using Nebula.Service.Interfaces;
using Nebula.Service.DTOs.Cards;
using Microsoft.EntityFrameworkCore;

namespace Nebula.Service.Services;

public class CardService : ICardService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public CardService()
    {
        this.unitOfWork = new UnitOfWork();
        this.mapper = new Mapper(new MapperConfiguration(c => c.AddProfile<MappingProfile>()));
    }

    public async Task<CardResultDto> AddAsync(CardCreationDto dto)
    {
        Card card = this.mapper.Map<Card>(dto);

        var guid = Guid.NewGuid();
        long numberGuid = BitConverter.ToInt64(guid.ToByteArray(), 0);
        string cardNumber = $"8600{Math.Abs(numberGuid) % 1000000000000}";

        card.Number = cardNumber;
        await this.unitOfWork.CardRepository.CreateAsync(card);
        await this.unitOfWork.SaveAsync();

        var result = this.mapper.Map<CardResultDto>(card);
        return result;
    }

    public async Task<CardResultDto> ModifyAsync(CardUpdateDto dto)
    {
        Card existCard = await this.unitOfWork.CardRepository.SelectByIdAsync(dto.Id);
        if (existCard is null)
            return null; // Is not found

        var mappedCard = this.mapper.Map(dto, existCard);
        this.unitOfWork.CardRepository.Update(mappedCard);
        await this.unitOfWork.SaveAsync();

        var result = this.mapper.Map<CardResultDto>(mappedCard);
        return result;
    }

    public async Task<bool> RemoveAsync(long id)
    {
        Card existCard = await this.unitOfWork.CardRepository.SelectByIdAsync(id);
        if (existCard is null)
            return false; // Is not found

        this.unitOfWork.CardRepository.Delete(existCard);
        await this.unitOfWork.SaveAsync();
        return true;
    }

    public async Task<CardResultDto> GetByIdAsync(long id)
    {
        Card existCard = await this.unitOfWork.CardRepository.SelectByIdAsync(id);
        if (existCard is null)
            return null; // Is not found

        var result = this.mapper.Map<CardResultDto>(existCard);

        return result;
    }

    public async Task<IEnumerable<CardResultDto>> GetAllAsync()
    {
        var cards = await this.unitOfWork.CardRepository.SelectAll().ToListAsync();

        foreach(var item in cards)
        {
            User user = await this.unitOfWork.UserRepository.SelectByIdAsync(item.UserId);
            item.User = user;
        }

        var result = this.mapper.Map<IEnumerable<CardResultDto>>(cards);
        return result;
    }
}