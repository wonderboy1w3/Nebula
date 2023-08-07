


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Nebula.DAL.Contexts;
using Nebula.Domain;
using Nebula.Service.DTOs.Cards;
using Nebula.Service.Interfaces;
//using Nebula.Service.Services;

//ICardService cardService = new CardService();

//var result = await cardService.GetByIdAsync(1);



var context = new NebulaDbContext();

var query = $"SELECT * FROM \"Users\"";
var users = context.Users.FromSqlRaw(query).ToList();

users.ForEach(x => Console.WriteLine(x.FirstName));