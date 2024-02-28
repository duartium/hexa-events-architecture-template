using System.Text.Json;
using Fluxeen.HexagonalEventDriven.Infraestructure.MainContext;
using Microsoft.AspNetCore.Mvc;

namespace Fluxeen.HexagonalEventDriven.WebApi.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        private readonly BGEstructurasDbContext bGEstructurasDbContext;
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger, BGEstructurasDbContext dbContext)
        {
            _logger = logger;
            bGEstructurasDbContext = dbContext;
        }

        [HttpGet("r01", Name = "r01")]
        public List<R01> GetTables()
        {
            return [.. bGEstructurasDbContext.R01s];
        }

        [HttpGet("users", Name = "users")]
        public List<Usuario> GetUsers()
        {
            return [.. bGEstructurasDbContext.Usuarios];
        }

        [HttpGet("roles", Name = "roles")]
        public List<Role> GetToles()
        {
            return [.. bGEstructurasDbContext.Roles];
        }

        [HttpPost("r01")]
        public ActionResult<R01> CreateTable([FromBody] R01 r01)
        {
            var json = JsonSerializer.Serialize(r01);
            _logger.LogInformation($"table: {json}");
            var newRegister = bGEstructurasDbContext.R01s.Add(r01);
            bGEstructurasDbContext.SaveChanges();

            return Created($"api/test/r01/{newRegister.Entity.Id}", newRegister.Entity);
        }
    }
}