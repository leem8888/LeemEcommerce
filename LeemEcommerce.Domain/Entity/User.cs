using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Model;

public class User : BaseModel
{
    [Required][MaxLength(250)][MinLength(3)] public string Username { get; set; }
    [Required][MaxLength(250)][MinLength(6)] public string Password { get; set; }
    [MaxLength(100)][MinLength(3)] public string LastName { get; set; }
    [Required][MaxLength(100)][MinLength(3)] public string FirstName { get; set; }
    public DateTime? BirthDay { get; set; }
    public GenderEnum? Gender { get; set; }
    public string? AvatarUrl { get; set; }
    [Required] public UserStatusEnum Status { get; set; }
    public string Role { get; set; }
}


