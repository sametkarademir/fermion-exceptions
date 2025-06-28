using Fermion.Exceptions.Models;

namespace Fermion.Exceptions.Interfaces;

public interface IHasValidationErrors
{
    IEnumerable<ValidationExceptionModel> Errors { get; }
}