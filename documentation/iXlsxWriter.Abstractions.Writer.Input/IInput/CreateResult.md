# IInput.CreateResult method

Returns a new reference [`OutputResult`](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md) that complies with what is indicated in its configuration object. By default, an [`IInput`](../IInput.md) will not be zipped.

```csharp
public OutputResult CreateResult(IOutputResultConfig config = null)
```

| parameter | description |
| --- | --- |
| config | The output result configuration. |

## Return Value

A [`OutputResult`](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md) reference that contains the result of the operation, to check if the operation is correct, the Success property will be true and the Value property will contain the value; Otherwise, the the Success property will be false and the Errors property will contain the errors associated with the operation, if they have been filled in.

The type of the return value is [`IOutputResultData`](../../iXlsxWriter.Abstractions.Writer.Operations.Results/IOutputResultData.md), which contains the operation result

## See Also

* class [OutputResult](../../iXlsxWriter.Abstractions.Writer.Operations.Results/OutputResult.md)
* interface [IOutputResultConfig](../../iXlsxWriter.Abstractions.Writer.Config/IOutputResultConfig.md)
* interface [IInput](../IInput.md)
* namespace [iXlsxWriter.Abstractions.Writer.Input](../../iXlsxWriter.Abstractions.Writer.md)

<!-- DO NOT EDIT: generated by xmldocmd for iXlsxWriter.Abstractions.Writer.dll -->