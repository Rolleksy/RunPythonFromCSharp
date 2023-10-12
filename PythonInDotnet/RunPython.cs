using IronPython.Hosting;


namespace PythonInDotnet
{
    /// <summary>
    /// Class was created in order to abstract way to run Python scripts from within C#/.Net using IronPython library.
    /// User can execute, pass arguments, receive returned variables. Methods explained below.
    /// 
    /// This class contains methods for:
    /// - Simply executing Python file - RunPythonFile()
    /// - Executing Python script, and getting variable - RunPythonFileGetVar(string variable)
    /// - Executing Python script, and getting multiple variables - RunPythonFileGetVars(string[] variables)
    /// - Executing Python script with arguments - RunPythonFileArgs(List<string> args)
    /// - Exucuting Python script with arguments and getting variable - RunPythonFileArgsGetVar(List<string> args, string variable)
    /// - Executing Python script with arguments and getting variables - RunPythonFileArgsGetVars(List<string> args, string[] variables)
    /// </summary>
    public class RunPython
    {
        string pathToFile = string.Empty;

        public RunPython(string pathToFile)
        {
            this.pathToFile = pathToFile;
        }

        public void RunPythonFile()
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile(pathToFile, scope);
        }

        public dynamic RunPythonFileGetVar(string variable)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile(pathToFile, scope);

            dynamic result = scope.GetVariable(variable);
            return result;
        }
        public dynamic RunPythonFileGetVars(string[] variables)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();

            engine.ExecuteFile(pathToFile, scope);
            dynamic[] dynamics = new dynamic[variables.Length];
            int i = 0;
            foreach ( var variable in variables )
            {
                dynamics[i] = RunPythonFileGetVar(variable);
                i++;
            }
            return dynamics;
        }

        public void RunPythonFileArgs(List<string> args)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            engine.GetSysModule().SetVariable("argv", args.ToArray());
            engine.ExecuteFile(pathToFile, scope);

        }

        public dynamic RunPythonFileArgsGetVar(List<string> args, string variable)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            engine.GetSysModule().SetVariable("argv", args.ToArray());
            engine.ExecuteFile(pathToFile, scope);
            dynamic result = scope.GetVariable(variable);
            return result;
        }

        public dynamic RunPythonFileArgsGetVars(List<string> args, string[] variables)
        {
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            engine.GetSysModule().SetVariable("argv", args.ToArray());
            engine.ExecuteFile(pathToFile, scope);
            dynamic[] dynamics = new dynamic[variables.Length];
            int i = 0;
            foreach (var variable in variables)
            {
                dynamics[i] = RunPythonFileGetVar(variable);
                i++;
            }
            return dynamics;
        }
    }
}
 