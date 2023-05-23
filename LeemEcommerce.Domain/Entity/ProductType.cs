using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Entity;

namespace Ecommerce.Domain.Model;

public class ProductType : BaseModel
{
    public string Name { get; set; }
    public string Code { get; set; }
    public virtual ICollection<Product> Products { get; set; }
    public virtual ICollection<SupplierProductType> SupplierProductTypes { get; set; }
}
