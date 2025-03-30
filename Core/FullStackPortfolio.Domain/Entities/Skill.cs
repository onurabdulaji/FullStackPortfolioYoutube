namespace FullStackPortfolio.Domain.Entities;

public class Skill : BaseEntity
{
    public string? Title { get; set; }
    public int? Value { get; set; }
    public Skill()
    {
    }
    public Skill(string title, int value)
    {
        Title = title;
        Value = value;
    }
}
