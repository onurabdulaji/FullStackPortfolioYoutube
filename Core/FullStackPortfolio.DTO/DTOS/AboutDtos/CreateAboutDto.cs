﻿using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.DTO.Configuration;

namespace FullStackPortfolio.DTO.DTOS.AboutDtos;

public class CreateAboutDto : BaseDTO<CreateAboutDto , About>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? Birthday { get; set; }
    public int? Age { get; set; }
    public string? Website { get; set; }
    public string? Degree { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? City { get; set; }
    public bool? IsFreelanceAvailable { get; set; }
}
