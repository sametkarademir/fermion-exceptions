namespace Fermion.Exceptions.Abstractions;

public interface IHasCorrelationId
{
    string CorrelationId { get; }
}