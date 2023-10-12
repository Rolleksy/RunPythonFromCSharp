# Execute Python files from within C# projects

`IronPython` nuget package has to be installed.
```
dotnet add package IronPython
```

This repo consists of class `RunPython.cs` which provides user with access to simple methods such as:

- `RunPythonFile()` - Executing Python file
- `RunPythonFileGetVar(string variable)` - Executing Python script, and getting `variable`
- `RunPythonFileGetVars(string[] variables)` - Executing Python script, and getting multiple `variables`
- `RunPythonFileArgs(List<string> args)` - Executing Python script with `args` arguments 
- `RunPythonFileArgsGetVar(List<string> args, string variable)` - Exucuting Python script with `args` arguments and getting `variable`
- `RunPythonFileArgsGetVars(List<string> args, string[] variables)` - Executing Python script with `args` arguments and getting `variables` 
