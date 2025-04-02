using FullStackPortfolio.DTO.DTOS.AboutDtos;

namespace FullStackPortfolio.Application.Services;

public interface IAboutService
{
    Task<CreateAboutDto> CreateAboutAsync(CreateAboutDto createAboutDto); 
    Task<IList<AboutDto>> GetAllAboutAsync();
}
