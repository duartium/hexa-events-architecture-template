using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Fluxeen.HexagonalEventDriven.WebApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class BaseApiController<T> : ControllerBase where T : BaseApiController<T>
{
    //private IMediator _mediator;
    //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    private ILogger<T> _logger;
    protected IMapper _mapper;
    public IConfiguration _configuration;


    protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>();
    protected IConfiguration Configuration => _configuration ??= HttpContext.RequestServices.GetService<IConfiguration>();

}
