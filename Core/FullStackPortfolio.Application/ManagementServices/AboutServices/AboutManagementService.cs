using FullStackPortfolio.Domain.Entities;
using FullStackPortfolio.Domain.Repositories.IUnitOfWorks;
using FullStackPortfolio.DTO.DTOS.AboutDtos;
using Mapster;

namespace FullStackPortfolio.Application.ManagementServices.AboutServices;

public class AboutManagementService : IAboutManagementService
{
    private readonly IUnitOfWork _unitOfWork;

    public AboutManagementService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAbout(CreateAboutDto createAboutDto)
    {
        var newAbout = createAboutDto.Adapt<About>();

        await _unitOfWork.GetAboutWriteRepository.CreateAbout(newAbout);
        await _unitOfWork.SaveAsync();
    }

    public async Task<IList<AboutDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var allAbouts = await _unitOfWork.GetAboutReadRepository.GetAllAboutsAsync();
        return allAbouts.Adapt<IList<AboutDto>>();
    }
}
