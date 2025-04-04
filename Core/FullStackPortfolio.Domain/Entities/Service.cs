﻿namespace FullStackPortfolio.Domain.Entities;

public class Service : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public Service()
    {

    }
    public Service(string title, string description, string icon)
    {
        Title = title;
        Description = description;
        Icon = icon;
    }
}
