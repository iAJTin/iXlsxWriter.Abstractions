@ECHO OFF
CLS

..\src\.nuget\nuget Pack iXlsxWriter.Abstractions.1.0.2.nuspec -NoDefaultExcludes -NoPackageAnalysis -OutputDirectory ..\deployment\nuget 

pause

