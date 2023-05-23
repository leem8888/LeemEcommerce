using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Model;

public class Comment : BaseModel
{
    public Guid? UserId { get; set; }
    [Required][MaxLength(200)][MinLength(5)] public string Username { get; set; }
    public bool IsAdmin { get; set; }
    public string Content { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
    public virtual ICollection<ChildComment> ChildComments { get; set; }
}


