using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Environment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Інформація про вхідні аргументи командної стрічки
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }
            ShowEnvironmentDetalis();
            Console.ReadLine();
        }

        static void ShowEnvironmentDetalis()
        {
            //Інформація про дискові пристрої, про ОС, та версії
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Is 64-bit operation system? {0}",Environment.Is64BitOperatingSystem);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("User domain name: {0}", Environment.UserDomainName);
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("Number of processor: {0}",Environment.ProcessorCount );
            Console.WriteLine(".NET Version: {0}",Environment.Version);

        }
    }
}
