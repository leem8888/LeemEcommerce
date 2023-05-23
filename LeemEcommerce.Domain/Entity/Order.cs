using LeemEcommerce.Domain.Common;


namespace Ecommerce.Domain.Model;

public class Order : BaseModel
{
    public Order()
    {
        OrderLogs = new HashSet<OrderLog>();
        OrderDetails = new HashSet<OrderDetail>();
    }
    public string OrderCode { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ProvinceCode { get; set; }
    public virtual Province Province { get; set; }
    public string DistrictCode { get; set; }
    public virtual District District { get; set; }
    public string Address { get; set; }
    public string Note { get; set; }
    public string CustomerName { get; set; }
    public string SaleCode { get; set; }
    public virtual SaleCode Sale { get; set; }
    public decimal Price { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
    public string Status { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<OrderLog> OrderLogs { get; set; }
}


