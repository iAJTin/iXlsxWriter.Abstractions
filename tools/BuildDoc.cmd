@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\lib\iXlsxWriter\iXlsxWriter.Abstractions.Writer\bin\debug\netstandard2.0\iXlsxWriter.Abstractions.Writer.dll ..\documentation

PAUSE
