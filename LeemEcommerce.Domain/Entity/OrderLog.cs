using LeemEcommerce.Domain.Common;


namespace Ecommerce.Domain.Model;

public class OrderLog : BaseModel
{
    public string Status { get; set; } 
    public DateTime Timestamp { get; set; }
    public virtual Order Order { get; set; }
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
}

