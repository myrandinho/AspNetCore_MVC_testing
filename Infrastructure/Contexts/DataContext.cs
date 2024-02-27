

using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<AdressEntity> Adresses { get; set; }
    public DbSet<UserEntity> Users { get; set; }
}
