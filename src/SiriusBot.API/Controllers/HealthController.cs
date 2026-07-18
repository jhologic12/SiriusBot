using Microsoft.AspNetCore.Mvc;

namespace SiriusBot.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "ok",
            service = "SiriusBot API",
            timestamp = DateTime.UtcNow
        });
    }
}