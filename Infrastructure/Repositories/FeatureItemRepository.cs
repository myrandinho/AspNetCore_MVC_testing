

using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class FeatureItemRepository(DataContext context) : BaseRepository<FeatureItemEntity>(context)
{
    private readonly DataContext _context = context;
}