using Fluxeen.HexagonalEventDriven.Domain.Security.DTOs;
using Fluxeen.HexagonalEventDriven.Infraestructure.HttpManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fluxeen.HexagonalEventDriven.WebApi.Controllers.Security;

[Route("api/authentication")]
[ApiController]
[ApiVersion("1.0")]
public class AuthenticationController : BaseApiController<AuthenticationController>
{

    public AuthenticationController() { }

    [AllowAnonymous]
    [HttpPost, Route("login")]
    public ActionResult Authenticate([FromBody] UserLogin request)
    {
        var response = new Response<string>(true, "OK");
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(response.Update(false, "Los datos de entrada son inválidos", null));

            string token = "";
            request.Password = Infraestructure.Application.Security.Services.Security.GetSHA256(request.Password);

            //if (!_srvAuthentication.IsAuthenticated(request, out token))
            //    return BadRequest(response.Update(false, "Usuario o contraseña incorrectas.", null));

            response.Data = token;
            return Ok(response);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex.ToString());
            return Conflict(response.Update(false, ex.Message, null));
        }
    }

}
