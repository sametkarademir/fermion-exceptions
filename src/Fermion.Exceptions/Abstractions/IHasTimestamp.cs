namespace Fermion.Exceptions.Abstractions;

public interface IHasTimestamp
{
    DateTime Timestamp { get; }
}