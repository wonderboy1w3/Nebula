using Nebula.DAL.Contexts;
using Nebula.DAL.IRepositories;
using Nebula.Domain;

namespace Nebula.DAL.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly NebulaDbContext dbContext;
    public UnitOfWork()
    {
        this.dbContext = new NebulaDbContext();
        CardRepository = new Repository<Card>(dbContext);
        UserRepository = new Repository<User>(dbContext);
        EmployeeRepository = new Repository<Employee>(dbContext);
    }

    public IRepository<Card> CardRepository { get; }
    public IRepository<User> UserRepository { get; }
    public IRepository<Employee> EmployeeRepository { get; }

    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }

    public async Task SaveAsync()
    {
        await this.dbContext.SaveChangesAsync();
    }
}
