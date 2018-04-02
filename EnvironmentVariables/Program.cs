using System;

namespace EnvironmentVariables
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("VAR = " + Environment.GetEnvironmentVariable("VAR", EnvironmentVariableTarget.User));
            Console.ReadKey();
        }
    }
}
