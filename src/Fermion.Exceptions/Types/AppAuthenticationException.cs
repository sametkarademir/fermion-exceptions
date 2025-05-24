using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Types;

public class AppAuthenticationException : AppException
{
    public override string Code { get; set; } = "APP:AUTHENTICATION:1000";
    public override string? Details { get; set; } = "Authentication failed. Please check your credentials.";
    public override LogLevel LogLevel { get; set; } = LogLevel.Error;
    public override int StatusCode { get; set; } = 401;

    public AppAuthenticationException() : base("Authentication failed.")
    {
    }

    public AppAuthenticationException(string message) : base(message)
    {

    }

    public AppAuthenticationException(string message, Exception innerException) : base(message, innerException)
    {

    }
}