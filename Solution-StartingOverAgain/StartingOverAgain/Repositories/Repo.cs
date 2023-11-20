using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using StartingOverAgain.Contexts;

namespace StartingOverAgain.Repositories;

internal abstract class Repo<TEntity> where TEntity : class  //placeholder, TEntity
{
    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        return entity ?? null!;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        return await _context.Set<TEntity>().AnyAsync(expression);
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity) //lambda-expression
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    public virtual async Task<bool> DeleteAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
        return true!;
    }

}

