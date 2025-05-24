using Fermion.Exceptions.Models;

namespace Fermion.Exceptions.Abstractions;

public interface IHasValidationErrors
{
    IEnumerable<ValidationExceptionModel> Errors { get; }
}