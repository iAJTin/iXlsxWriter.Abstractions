@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\bin\debug\netstandard2.0\iXlsxWriter.Abstractions.Writer.dll ..\documentation

PAUSE
