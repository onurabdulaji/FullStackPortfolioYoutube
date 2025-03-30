using FullStackPortfolio.Domain.Enums;

namespace FullStackPortfolio.Domain.Entities.IBase;

public  interface IBaseEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DataStatus? Status { get; set; }
    public bool? StatusAtTheMoment { get; set; }
}
