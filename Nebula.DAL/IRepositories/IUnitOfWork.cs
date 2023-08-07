using Nebula.Domain;

namespace Nebula.DAL.IRepositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Card> CardRepository { get; }
    IRepository<User> UserRepository { get; }
    IRepository<Employee> EmployeeRepository { get; }
    Task SaveAsync();
}
