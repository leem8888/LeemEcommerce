using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Model;

public class Rating : BaseModel
{
    [Required][MaxLength(200)][MinLength(5)] public string UserName { get; set; }
    public string? Comment { get; set; }
    public int Rate { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}

