using FullStackPortfolio.DTO.DTOS.AboutDtos;
using MediatR;

namespace FullStackPortfolio.Application.Features.MediatR.AboutsSlice.CreateAbout.Commands;

public class CreateAboutCommand : IRequest<CreateAboutDto>
{
    public CreateAboutDto CreateAboutDto { get; set; }
    public CreateAboutCommand(CreateAboutDto createAboutDto)
    {
        CreateAboutDto = createAboutDto ?? throw new ArgumentNullException(nameof(createAboutDto));
    }
}
