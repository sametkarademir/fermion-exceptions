using Microsoft.Extensions.Logging;

namespace Fermion.Exceptions.Interfaces;

public interface IHasLogLevel
{
    LogLevel LogLevel { get; set; }
}