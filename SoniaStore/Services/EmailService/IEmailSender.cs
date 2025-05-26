using SoniaStore.Services.EmailService;

namespace SoniaStore.Services.EmailService;

public interface IEmailSender
{
    Task SendEmailAsync(Message message);
}
