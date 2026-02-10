using System.ComponentModel.DataAnnotations;

namespace Authservice.Domain.Entities.Role;

public class Role
{   
    // Validaciones para cada campo
    [Key]
    [MaxLength(16)]
    public string Id { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [MaxLength(255)]
    public string Description { get; set; }

    // Se va a utilizar para relacionarse con UserRole
    public ICollection<UserRole> UserRoles { get; set; }
}