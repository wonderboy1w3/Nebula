using Microsoft.EntityFrameworkCore;
using Nebula.Domain;
using Nebula.Domain.Enums;

namespace Nebula.DAL.Contexts;

public class NebulaDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseLazyLoadingProxies();

        string stringConnection = "Host=localhost; Port=5432; User Id=postgres; Database=NebulaDb; Password=root;";
        optionsBuilder.UseNpgsql(stringConnection);
    }

    public DbSet<Card> Cards { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Fluent API


        modelBuilder.Entity<User>()
            .HasMany(t => t.Cards)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId);

        modelBuilder.Entity<Card>()
            .HasOne(t => t.User)
            .WithMany(t => t.Cards);

        #endregion

        #region Seed Data
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "Iskandar", LastName = "Qodirov", Phone = "+998972350120", DateOfBirth = new DateTimeOffset(new DateTime(2006, 10, 13)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new User { Id = 2, FirstName = "Madiyor", LastName = "Odilov", Phone = "+998903638333", DateOfBirth = new DateTimeOffset(new DateTime(2005, 11, 04)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new User { Id = 3, FirstName = "Nodir", LastName = "Ollonazarov", Phone = "+998881813525", DateOfBirth = new DateTimeOffset(new DateTime(2004, 02, 20)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new User { Id = 4, FirstName = "Nurullo", LastName = "Nurmatov", Phone = "+998330022816", DateOfBirth = new DateTimeOffset(new DateTime(2003, 08, 16)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new User { Id = 5, FirstName = "Ravshanbek", LastName = "Isroilov", Phone = "+998902528196", DateOfBirth = new DateTimeOffset(new DateTime(2002, 08, 18)).UtcDateTime, CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, FirstName = "Avazbek", LastName = "Siddiqov", Phone = "+998973340334", Type = EmployeeType.Manager, DateOfBirth = new DateTimeOffset(new DateTime(1988, 04, 07)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new Employee { Id = 2, FirstName = "Muqimjon", LastName = "Mamadaliyev", Phone = "+998937349808", Type = EmployeeType.Accountant, DateOfBirth = new DateTimeOffset(new DateTime(1998, 07, 22)).UtcDateTime, CreatedAt = DateTime.UtcNow },
            new Employee { Id = 3, FirstName = "Abdualim", LastName = "Normurodov", Phone = "+998950642799", Type = EmployeeType.Administrator, DateOfBirth = new DateTimeOffset(new DateTime(2001, 11, 28)).UtcDateTime, CreatedAt = DateTime.UtcNow });
        #endregion
    }

}
