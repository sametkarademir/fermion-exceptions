using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Abstractions;

public interface IHasLogLevel
{
    LogLevel LogLevel { get; set; }
}