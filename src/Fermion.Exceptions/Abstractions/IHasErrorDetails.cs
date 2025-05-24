namespace Fermion.Exceptions.Abstractions;

public interface IHasErrorDetails
{
    string? Details { get; }
}