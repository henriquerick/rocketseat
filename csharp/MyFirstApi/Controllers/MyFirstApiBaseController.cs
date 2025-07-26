using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Henrique Rick";

    [HttpGet("healthy")]
    public IActionResult Healthy()
    {
        return Ok("It's Working!!");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}

