using FullStackPortfolio.DTO.DTOS.AboutDtos;

namespace FullStackPortfolio.Application.ManagementServices.AboutServices;

public interface IAboutManagementService
{
    // Write
    Task CreateAbout(CreateAboutDto createAboutDto);

    // Read
    Task<IList<AboutDto>> GetAllAsync(CancellationToken cancellationToken = default);
}
