

using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class UserRepository(DataContext context) : BaseRepository<UserEntity>(context)
{
    private readonly DataContext _context = context;

    public override async Task<ResponsResult> GetAllAsync()
    {
        try
        {
            IEnumerable<UserEntity> result = await _context.Users
                .Include(i => i.Adress)
                .ToListAsync();

            return ResponseFactory.Ok(result);

        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    public override async Task<ResponsResult> GetOneAsync(Expression<Func<UserEntity, bool>> predicate)
    {
        try
        {
            var result = await _context.Set<UserEntity>()
                .Include(i => i.Adress)
                .FirstOrDefaultAsync(predicate);
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
