﻿namespace FullStackPortfolio.Domain.Entities;

public class Stat : BaseEntity
{
    public int? Client { get; set; }
    public int? Project { get; set; }
    public int? Support { get; set; }
    public int? Worker { get; set; }
    public Stat()
    {

    }
    public Stat(int client, int project, int support, int worker)
    {
        Client = client;
        Project = project;
        Support = support;
        Worker = worker;
    }
}
