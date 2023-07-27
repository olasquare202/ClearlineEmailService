using ClearlineEmailService.Models;

namespace ClearlineEmailService.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
