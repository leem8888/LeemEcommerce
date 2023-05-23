
namespace Ecommerce.Domain.Model;

public class Province
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string CountryCode { get; set; }
    public virtual Country Country { get; set; }
   
}
