﻿
using System.Collections.Generic;

using iTin.Core.ComponentModel;

namespace iXlsxWriter.Abstractions.Writer.Operations.Results;

/// <summary>
/// Specialization of <see cref="ResultBase{IResultData}"/> interface.<br/>
/// Represents result after insert an element in a document.
/// </summary>
public class ActionResult : ResultBase<IResultData>
{
    /// <summary>
    /// Returns a new <see cref="ActionResult"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="ActionResult"/> with specified detailed error.
    /// </returns>
    public new static ActionResult CreateErrorResult(string message, string code = "") =>
        CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

    /// <summary>
    /// Returns a new <see cref="ActionResult"/> with specified detailed errors collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <returns>
    /// A new invalid <see cref="ActionResult"/> with specified detailed errors collection.
    /// </returns>
    public new static ActionResult CreateErrorResult(IResultError[] errors) =>
        new()
        {
            Result = default,
            Success = false,
            Errors = (IResultError[])errors.Clone()
        };

    /// <summary>
    /// Returns a new <see cref="ActionResult"/> with specified detailed error.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="result">Response Result</param>
    /// <param name="code">Error code</param>
    /// <returns>
    /// A new invalid <see cref="ActionResult"/> with specified detailed errors collection.
    /// </returns>
    public new static ActionResult CreateErrorResult(string message, IResultData result, string code = "") =>
        CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

    /// <summary>
    /// Returns a new <see cref="ActionResult"/> with specified detailed errors collection.
    /// </summary>
    /// <param name="errors">A errors collection</param>
    /// <param name="result">Response Result</param>
    /// <returns>
    /// A new invalid <see cref="ActionResult"/> with specified detailed errors collection.
    /// </returns>
    public new static ActionResult CreateErrorResult(IResultError[] errors, IResultData result) =>
        new()
        {
            Result = result,
            Success = false,
            Errors = (IResultError[])errors.Clone()
        };

    /// <summary>
    /// Returns a new success result.
    /// </summary>
    /// <param name="result">Response Result</param>
    /// <returns>
    /// A new valid <see cref="ActionResult"/>.
    /// </returns>
    public new static ActionResult CreateSuccessResult(IResultData result) =>
        new()
        {
            Result = result,
            Success = true,
            Errors = new List<IResultError>()
        };

    /// <summary>
    /// Creates a new <see cref="ActionResult"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <returns>
    /// A new <see cref="ActionResult"/> instance for specified exception.
    /// </returns>
    public new static ActionResult FromException(System.Exception exception) =>
        FromException(exception, default);

    /// <summary>
    /// Creates a new <see cref="ActionResult"/> instance from known exception.
    /// </summary>
    /// <param name="exception">Target exception.</param>
    /// <param name="result">Response Result</param>
    /// <returns>
    /// A new <see cref="ActionResult"/> instance for specified exception.
    /// </returns>
    public new static ActionResult FromException(System.Exception exception, IResultData result) =>
        new()
        {
            Result = result,
            Success = false,
            Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
        };
}
