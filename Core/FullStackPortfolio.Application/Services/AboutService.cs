using FullStackPortfolio.Application.ManagementServices.AboutServices;
using FullStackPortfolio.DTO.DTOS.AboutDtos;

namespace FullStackPortfolio.Application.Services;

public class AboutService : IAboutService
{
    private readonly IAboutManagementService _aboutManagementService;

    public AboutService(IAboutManagementService aboutManagementService)
    {
        _aboutManagementService = aboutManagementService;
    }

    public async Task<bool> CreateAboutAsync(CreateAboutDto createAboutDto)
    {
        await _aboutManagementService.CreateAbout(createAboutDto);
        if (createAboutDto.Email is null) return false;
        return true;
    }

    public async Task<IList<AboutDto>> GetAllAboutAsync()
    {
        var list = await _aboutManagementService.GetAllAsync();
        return list;
    }

    async Task<CreateAboutDto> IAboutService.CreateAboutAsync(CreateAboutDto createAboutDto)
    {
        await _aboutManagementService.CreateAbout(createAboutDto);
        return createAboutDto;
    }
}
