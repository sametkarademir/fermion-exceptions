namespace Fermion.Exceptions.Interfaces;

public interface IHasCorrelationId
{
    string? CorrelationId { get; }
}