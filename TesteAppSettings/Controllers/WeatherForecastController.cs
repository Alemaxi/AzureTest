using Microsoft.AspNetCore.Mvc;
using TesteAppSettings.Config;

namespace TesteAppSettings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly TestData _testData;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, TestData testData)
        {
            _logger = logger;
            _testData = testData;
        }

        [HttpGet]
        public Task<string> Get()
        {
            return Task.FromResult(_testData.TestString!);
        }
    }
}
