
using iTin.Core.ComponentModel;

using iXlsxWriter.Abstractions.Writer.Operations.Results;

namespace iXlsxWriter.Abstractions.Writer.Operations.Actions;

/// <summary>
/// Defines allowed actions for output result.
/// </summary>
public interface IOutputAction
{
    /// <summary>
    /// Synchronously executes this action for the output result specified in the <paramref name="data"/> parameter.
    /// </summary>
    /// <param name="data">Target output result data.</param>
    /// <returns>
    /// A <see cref="IResult"/> reference that contains action result.
    /// </returns>
    IResult Execute(IOutputResultData data);
}
