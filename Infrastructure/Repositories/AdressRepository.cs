

using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class AdressRepository(DataContext context) : BaseRepository<AdressEntity>(context)
{
    private readonly DataContext _context = context;
}