

using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public abstract class BaseRepository<TEntity>(DataContext context) where TEntity : class
{
    private readonly DataContext _context = context;


    public virtual async Task<ResponsResult> CreateOneAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return ResponseFactory.Ok(entity);

        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
        
    }


    public virtual async Task<ResponsResult> GetAllAsync()
    {
        try
        {
            var result = await _context.Set<TEntity>().ToListAsync();
            return ResponseFactory.Ok(result);

        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }

    }

    public virtual async Task<ResponsResult> GetOneAsync(Expression<Func<TEntity, bool>> predicate)
    {
        try
        {
            var result = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            if (result == null)
                return ResponseFactory.NotFound();
                    return ResponseFactory.Ok(result);

        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }

    }
}
