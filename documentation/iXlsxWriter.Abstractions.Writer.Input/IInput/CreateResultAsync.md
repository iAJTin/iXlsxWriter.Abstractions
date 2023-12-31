# IInput.CreateResultAsync method

Returns a new reference [`OutputResult`](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md) that complies with what is indicated in its configuration object. By default, this input will not be zipped.

```csharp
public Task<OutputResult> CreateResultAsync(IOutputResultConfig config = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| config | The output result configuration. |
| cancellationToken | A cancellation token that can be used by other objects or threads to receive notice of cancellation. |

## Return Value

A [`OutputResult`](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md) reference that contains the result of the operation, to check if the operation is correct, the Success property will be true and the Result property will contain the Result; Otherwise, the the Success property will be false and the Errors property will contain the errors associated with the operation, if they have been filled in.

The type of the return Result is [`IOutputResultConfig`](../../iXlsxWriter.Abstractions.Writer.Config/IOutputResultConfig.md), which contains the operation result

## See Also

* class [OutputResult](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md)
* interface [IOutputResultConfig](../../iXlsxWriter.Abstractions.Writer.Config/IOutputResultConfig.md)
* interface [IInput](../IInput.md)
* namespace [iXlsxWriter.Abstractions.Writer.Input](../../iXlsxWriter.Abstractions.Writer.md)

<!-- DO NOT EDIT: generated by xmldocmd for iXlsxWriter.Abstractions.Writer.dll -->
