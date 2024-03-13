using CleanArchitecture.Application.Models.Mail;

namespace CleanArchitecture.Application.Contracts.Infrastructure;

public interface IEmailService
{
    Task<bool> SendEmail(Email email);
}