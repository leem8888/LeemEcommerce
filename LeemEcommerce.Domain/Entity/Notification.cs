using LeemEcommerce.Domain.Common;

namespace Ecommerce.Domain.Model;

public class Notification : BaseModel
{
    public string GroupName { get; set; }
    public Guid? UserId { get; set; }
    public bool Seen { get; set; }
    public object MetaData { get; set; }
    public string EventName { get; set; }
}

