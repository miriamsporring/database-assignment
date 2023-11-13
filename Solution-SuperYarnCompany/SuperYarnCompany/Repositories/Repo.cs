using Microsoft.EntityFrameworkCore;
using SuperYarnCompany.Context;
using System.Linq.Expressions;

internal abstract class Repo<TEntity> where TEntity : class //placeholder, TEntity
{
    private readonly DataContext _context;

    protected Repo(DataContext context) //tar emot nånting utifrån som kan användas här inne - dependency injection
    {
        _context = context;
    }


    //Create
    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    //Read - Get - hämta en
    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression) //lambda-expression
    {
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        return entity ?? null!;
    }

    //hämta alla

    public virtual async Task<IEnumerable<TEntity>> GetAllAscync()
    {
        var entities = await _context.Set<TEntity>().ToListAsync();
        return entities ?? null!;
    }

    //Update
    public virtual async Task<TEntity> UpdateAsync(TEntity entity) //lambda-expression
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    //Delete
    public virtual async Task<bool> DeleteAsync(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
        return true!;
    }



    //EXISTS - Ingår inte i CRUD med är bra att ha
    public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression) //lambda-expression
    {
        var exists = await _context.Set<TEntity>().AnyAsync(expression);
        return exists;
    }
}


