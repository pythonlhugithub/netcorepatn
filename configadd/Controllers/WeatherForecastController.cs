using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
namespace configadd.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{


private IOptions<custom> custom;
private string verson;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IOptions<custom> custom, ILogger<WeatherForecastController> logger, string version)
    {
        _logger = logger;

       this.custom=custom;

        verson=version;

    }

    [HttpGet(Name = "GetWeatherForecast")]
    public String Get()
    {
     return this.custom.Value.ToString()+verson;
    }
}
