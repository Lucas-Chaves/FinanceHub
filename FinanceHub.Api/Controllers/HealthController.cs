using FinanceHub.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceHub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly IHealthService _healthService;

    public HealthController(IHealthService healthService)
    {
        _healthService = healthService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_healthService.GetStatus());
    }

    [HttpGet("version")]
    public IActionResult Version()
    {
        return Ok(_healthService.GetVersion());
    }
}