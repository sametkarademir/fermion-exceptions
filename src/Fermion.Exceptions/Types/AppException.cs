using Fermion.Exceptions.Abstractions;
using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Types;

public abstract class AppException :
    Exception,
    IHasCorrelationId,
    IHasErrorCode,
    IHasErrorDetails,
    IHasLogLevel,
    IHasStatusCode,
    IHasTimestamp
{
    public virtual string? CorrelationId { get; set; }
    public virtual string Code { get; set; } = "APP:GENERAL:1000";
    public virtual string? Details { get; set; } = "An error occurred in the application.";
    public virtual LogLevel LogLevel { get; set; } = LogLevel.Error;
    public virtual int StatusCode { get; set; } = 500;
    public virtual DateTime Timestamp { get; set; } = DateTime.UtcNow;

    protected AppException() : base("An error occurred in the application.")
    {
    }

    protected AppException(string? message) : base(message)
    {
    }

    protected AppException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public AppException WithData(string name, object value)
    {
        Data[name] = value;
        return this;
    }

    public AppException AppendData(IDictionary<string, object> data)
    {
        if (data.Count == 0)
        {
            return this;
        };

        foreach (var kvp in data)
        {
            Data[kvp.Key] = kvp.Value;
        }

        return this;
    }

    public AppException WithCode(string code)
    {
        Code = code;
        return this;
    }
    public AppException WithDetails(string details)
    {
        Details = details;
        return this;
    }
    public AppException WithLogLevel(LogLevel logLevel)
    {
        LogLevel = logLevel;
        return this;
    }

    public AppException WithStatusCode(int statusCode)
    {
        StatusCode = statusCode;
        return this;
    }

    public AppException WithCorrelationId(string correlationId)
    {
        CorrelationId = correlationId;
        return this;
    }
}