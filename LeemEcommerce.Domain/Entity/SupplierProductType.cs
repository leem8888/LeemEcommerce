

namespace Ecommerce.Domain.Model;

public class SupplierProductType
{
    public Guid SupplierId { get; set; }
    public Guid ProductTypeId { get; set; }
    public virtual Supplier Supplier { get; set; }
    public virtual ProductType ProductType { get; set; }
}

