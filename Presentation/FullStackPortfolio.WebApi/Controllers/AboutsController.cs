using FullStackPortfolio.Application.Features.MediatR.AboutsSlice.CreateAbout.Commands;
using FullStackPortfolio.DTO.DTOS.AboutDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FullStackPortfolio.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AboutsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAbout([FromBody] CreateAboutDto createAboutDto)
    {
        var command = new CreateAboutCommand(createAboutDto);
        var response = await _mediator.Send(command);
        return Ok(response);
    }

}

































//[HttpPost] Boyle yaparsek Dto api de gosterilir
//    public async Task<IActionResult> CreateAbout([FromBody] CreateAboutCommand createAboutCommand)
//    {
//        var response = await _mediator.Send(createAboutCommand);
//        return Ok(response);
//    }