using FullStackPortfolio.Application.Services;
using FullStackPortfolio.DTO.DTOS.AboutDtos;
using MediatR;

namespace FullStackPortfolio.Application.Features.MediatR.AboutsSlice.CreateAbout.Commands;

public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, CreateAboutDto>
{
    private readonly IAboutService _aboutService;

    public CreateAboutCommandHandler(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<CreateAboutDto> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        var createdAboutDto = await _aboutService.CreateAboutAsync(request.CreateAboutDto);
        return createdAboutDto;
    }
}
