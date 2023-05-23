using System.ComponentModel.DataAnnotations;

namespace LeemEcommerce.Domain.Common;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime? CreatAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    [Required] public string CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}
