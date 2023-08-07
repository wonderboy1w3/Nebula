using Microsoft.EntityFrameworkCore;
using Nebula.DAL.Contexts;
using Nebula.DAL.IRepositories;
using Nebula.Domain.Commons;

namespace Nebula.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly NebulaDbContext dbContext;
    public Repository(NebulaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task CreateAsync(T entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        await this.dbContext.Set<T>().AddAsync(entity);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        this.dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        this.dbContext.Set<T>().Remove(entity);
    }

    public async Task<T> SelectByIdAsync(long id)
        => await this.dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

    public IQueryable<T> SelectAll()
        => this.dbContext.Set<T>().AsNoTracking().AsQueryable();
}
