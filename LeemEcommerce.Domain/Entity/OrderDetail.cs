using LeemEcommerce.Domain.Common;
using LeemEcommerce.Domain.Entity;

namespace Ecommerce.Domain.Model;

public class OrderDetail : BaseModel
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

