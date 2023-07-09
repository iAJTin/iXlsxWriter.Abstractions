
using System.IO;

namespace iXlsxWriter.Abstractions.Writer.Operations.Results;

/// <summary>
/// Defines generic result data
/// </summary>
public interface IResultData
{
    /// <summary>
    /// Gets or sets a value 
    /// </summary>
    /// <value>
    /// 
    /// </value>
    Stream InputStream { get; set; }

    /// <summary>
    /// Gets or sets a value 
    /// </summary>
    /// <value>
    /// 
    /// </value>
    Stream OutputStream { get; set; }
}
