using Microsoft.AspNetCore.Mvc;
namespace SmartShift.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase {
 [HttpPost("login")]
 public IActionResult Login()=> Ok(new { token="demo-token"});
}