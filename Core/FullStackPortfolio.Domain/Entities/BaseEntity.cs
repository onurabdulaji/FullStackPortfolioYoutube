using FullStackPortfolio.Domain.Entities.IBase;
using FullStackPortfolio.Domain.Enums;

namespace FullStackPortfolio.Domain.Entities;

public abstract class BaseEntity : IBaseEntity
{
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Created;
        StatusAtTheMoment = true;
    }
    public Guid BaseId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DataStatus? Status { get; set; }
    public bool? StatusAtTheMoment { get; set; }
}
