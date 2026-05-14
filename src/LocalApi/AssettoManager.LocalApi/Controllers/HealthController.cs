using Microsoft.AspNetCore.Mvc;

namespace AssettoManager.LocalApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HealthController : ControllerBase
{
    [Route("status")]
    [HttpGet]
    public IActionResult Get() => Ok("healthy");
}