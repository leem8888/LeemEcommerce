using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Model;

public class Supplier : BaseModel
{
    [Required][MaxLength(200)][MinLength(5)] public string Name { get; set; }
    public string? Logo { get; set; }
    public string? Code { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}


