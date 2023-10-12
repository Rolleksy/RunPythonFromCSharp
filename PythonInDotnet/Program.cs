using IronPython.Hosting;
namespace PythonInDotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToPYFile = "PathToYourPythonFile";
            List<string> arguments = new List<string>
            {
                "List", "Of", "Your", "Arguments"
            };
            RunPython rp = new RunPython(pathToPYFile);
        }
    }
}