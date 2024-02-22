using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxeen.HexagonalEventDriven.Infraestructure.Application.Security.Models;

public class VerifyCodeResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}

public class ChangePasswordResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}