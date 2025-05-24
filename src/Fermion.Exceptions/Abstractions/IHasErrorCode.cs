namespace Fermion.Exceptions.Abstractions;

public interface IHasErrorCode
{
    string? Code { get; }
}