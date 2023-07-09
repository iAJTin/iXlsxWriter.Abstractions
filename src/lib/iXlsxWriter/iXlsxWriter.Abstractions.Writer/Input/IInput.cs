
using System.IO;
using System.Threading.Tasks;
using System.Threading;

using iTin.Core.ComponentModel;
using iTin.Core.ComponentModel.Results;

using iXlsxWriter.Abstractions.Writer.Config;
using iXlsxWriter.Abstractions.Writer.Operations.Results;

namespace iXlsxWriter.Abstractions.Writer.Input;

/// <summary>
/// Defines a generic input
/// </summary>
public interface IInput
{
    /// <summary>
    /// Gets or sets the input object.
    /// </summary>
    /// <value>
    /// The input.
    /// </value>
    object Input { get; set; }

    /// <summary>
    /// Gets input type.
    /// </summary>
    /// <value>
    /// An value indicating type of the input.
    /// </value>
    KnownInputType InputType { get; }

    /// <summary>
    /// Returns a new reference <see cref="OutputResult"/> that complies with what is indicated in its configuration object. By default, an <see cref="IInput"/> will not be zipped.
    /// </summary>
    /// <param name="config">The output result configuration.</param>
    /// <returns>
    /// <para>
    /// A <see cref="OutputResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the return value is <see cref="IOutputResultData"/>, which contains the operation result
    /// </para>
    /// </returns>
    OutputResult CreateResult(IOutputResultConfig config = null);

    /// <summary>
    /// Saves this input into a file.
    /// </summary>
    /// <param name="outputPath">The output path. The use of the <b>~</b> character is allowed to indicate relative paths, and you can also use <b>UNC</b> path.</param>
    /// <param name="options">Save options</param>
    /// <returns>
    /// <para>
    /// A <see cref="BooleanResult"/> which implements the <see cref="IResult"/> interface reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the return value is <see cref="bool"/>, which contains the operation result
    /// </para>
    /// </returns>
    IResult SaveToFile(string outputPath, SaveOptions options = null);

    /// <summary>
    /// Convert this input into a stream object.
    /// </summary>
    /// <returns>
    /// A <see cref="Stream"/> that represents a input file.
    /// </returns>
    Stream ToStream();


    /// <summary>
    /// Returns a new reference <see cref="OutputResult"/> that complies with what is indicated in its configuration object. By default, this input will not be zipped.
    /// </summary>
    /// <param name="config">The output result configuration.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// <para>
    /// A <see cref="OutputResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Result</b> property will contain the Result; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the return Result is <see cref="IOutputResultConfig"/>, which contains the operation result
    /// </para>
    /// </returns>
    Task<OutputResult> CreateResultAsync(IOutputResultConfig config = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Saves this input into a file asynchronously.
    /// </summary>
    /// <param name="outputPath">The output path. The use of the <b>~</b> character is allowed to indicate relative paths, and you can also use <b>UNC</b> path.</param>
    /// <param name="options">Save options</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// <para>
    /// A <see cref="BooleanResult"/> which implements the <see cref="IResult"/> interface reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the return value is <see cref="bool"/>, which contains the operation result
    /// </para>
    /// </returns>
    Task<IResult> SaveToFileAsync(string outputPath, SaveOptions options = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Convert this input into a stream object asynchronously.
    /// </summary>
    /// <returns>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// A <see cref="Stream"/> that represents this input file.
    /// </returns>
    Task<Stream> ToStreamAsync(CancellationToken cancellationToken = default);
}
