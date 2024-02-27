

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class UserEntity
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string SecurityKey { get; set; } = null!;
    public string? Phone { get; set; }
    public string? Biography { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Modified { get; set; }

    public int? AdressId { get; set; }
    public AdressEntity? Adress { get; set; }
}
