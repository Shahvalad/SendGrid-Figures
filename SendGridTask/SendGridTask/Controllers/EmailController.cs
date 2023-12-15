using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SendGridTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail(string To, string Subject, string Name)
        {
            MessageSender.ExecuteAsync(To, Subject, Name).Wait();
            return Ok("Email Sent");
        }
    }
}
