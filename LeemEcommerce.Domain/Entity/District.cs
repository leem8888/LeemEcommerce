

namespace Ecommerce.Domain.Model;

public class District
{
    public string Name { get; set; }
    public string Code { get; set; }

    public string ProvinceCode { get; set; }
    public virtual Province Province { get; set; }
}

