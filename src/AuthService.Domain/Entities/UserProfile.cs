// Estas librerias nos ayudan para manejar la base de datos
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthService.Domain.Entities.UserProfile;

public class UserProfile
{
    [Key]
    [MaxLength(16)]
    public string Id { get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = string.Empty;

    public string ProfilePictureUrl { get; set; }
    public string Bio { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    public User User { get; set; } = null;
}