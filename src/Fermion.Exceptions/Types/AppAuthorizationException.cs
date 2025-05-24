using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Types;

public class AppAuthorizationException : AppException
{
    public override string Code { get; set; } = "APP:AUTHORIZATION:1000";
    public override string? Details { get; set; } = "Unauthorized request. You do not have permission to access this resource.";
    public override LogLevel LogLevel { get; set; } = LogLevel.Error;
    public override int StatusCode { get; set; } = 403;

    public AppAuthorizationException() : base("Unauthorized request.")
    {
    }

    public AppAuthorizationException(string message) : base(message)
    {

    }

    public AppAuthorizationException(string message, Exception innerException) : base(message, innerException)
    {

    }
}