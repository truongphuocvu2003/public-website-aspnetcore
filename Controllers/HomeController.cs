using Microsoft.AspNetCore.Mvc;

namespace public_website_aspnetcore.Controllers;

[ApiController]
[Route("[controller]")]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Home page");
    }
}
