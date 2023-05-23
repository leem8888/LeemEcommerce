using LeemEcommerce.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Model;
public class ChildComment : BaseModel
{
    [Required][MaxLength(200)][MinLength(5)] public string Username { get; set; }
    public bool IsAdmin { get; set; }
    public string Content { get; set; }
    public Guid CommentId { get; set; }
    public Comment Comment { get; set; } 
}


