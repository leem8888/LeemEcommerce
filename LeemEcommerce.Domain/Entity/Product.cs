using Ecommerce.Domain.Model;
using LeemEcommerce.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace LeemEcommerce.Domain.Entity;

public class Product : BaseModel
{
    [Required][MaxLength(200)][MinLength(5)] public string Name { get; set; }
    [Required][MaxLength(200)][MinLength(5)] public string Slug { get; set; }
    [MaxLength(100)][MinLength(5)] public string? SortDescription { get; set; }
    [MaxLength(1000)][MinLength(5)] public string? Description { get; set; }
    public string? ConditionProducts { get; set; }
    public object? Configuration { get; set; }
    public ICollection<string>? SpecialFeatures { get; set; }
    public Guid? SupplierId { get; set; }
    public virtual Supplier Supplier { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal? SalePrice { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
}
