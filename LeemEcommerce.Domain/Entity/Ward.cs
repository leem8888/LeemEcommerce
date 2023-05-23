

namespace Ecommerce.Domain.Model;

public class Ward
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string DistrictCode { get; set; }
    public virtual District District { get; set; }
}

