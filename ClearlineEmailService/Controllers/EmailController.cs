using ClearlineEmailService.Models;
using ClearlineEmailService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClearlineEmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet]
        [Route("testEmail")]
        public IActionResult TestEmail()
        {
            var message = new Message(new string[]
               {  "olaoluwaesan.dev@gmail.com" }, "Test", "Now! I can send email using C# code");

            _emailService.SendEmail(message);
            return StatusCode(StatusCodes.Status200OK,
                new Response { Status = "Success", Message = "Email sent successfully" });
        }
    }
}
