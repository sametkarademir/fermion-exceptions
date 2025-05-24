using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Types;

public class AppBusinessException : AppException
{
    public override string Code { get; set; } = "APP:BUSINESS:1000";
    public override string? Details { get; set; } = "An error occurred in the business logic of the application.";
    public override LogLevel LogLevel { get; set; } = LogLevel.Error;
    public override int StatusCode { get; set; } = 500;

    public AppBusinessException() : base("Incorrect exception")
    {
    }

    public AppBusinessException(string message) : base(message)
    {
    }

    public AppBusinessException(string message, Exception innerException) : base(message, innerException)
    {
    }
}