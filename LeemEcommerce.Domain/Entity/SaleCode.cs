


namespace Ecommerce.Domain.Model;

public class SaleCode
{
    public string Code { get; set; }
    public int Percent { get; set; }
    public decimal MaxPrice { get; set; }
    public DateTime ValidUntil { get; set; }
}

