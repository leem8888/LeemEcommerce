using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeemEcommerce.Domain.Entity;

[Table(TableNameConstants.Categories)]
public class Category : BaseModel
{
    [Required][MaxLength(200)][MinLength(5)] public string Name { get; set; }
    [MaxLength(1064)] public string? ImageUrl { get; set; }
    [MaxLength(1064)] public string? Url { get; set; }
    public bool IsActive { get; set; }
    public virtual ICollection<Product> Product { get; set; }
}
