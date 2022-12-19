using CleanArchitectureSample.Core.Interfaces;

namespace CleanArchitectureSample.Infrastructure.ThirdPartiesApis;

public class MailJetEmailProvider : IEmailSender
{
    public async Task SendEmailAsync(string to, string @from, string subject, string body)
    {
        throw new NotImplementedException();
    }
}