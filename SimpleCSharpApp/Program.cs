using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int  Main(string[] args)
        {
            // Вывести пользователю простое сообщение.
            Console.WriteLine("***** My First C# Арр *****");
            Console.WriteLine("Hello World");
            Console.WriteLine();
            // Ожидать нажатия клавиши <Enter>, прежде чем завершить работу.

            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            ShowEnvironmentDetails();

            Console.ReadLine ();

            return -1;
        }
        
        static void ShowEnvironmentDetails ()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали,
            foreach (string drive in Environment.GetLogicalDrives())
            Console.WriteLine("Drive: {0}", drive); // Логические устройства
            Console.WriteLine("OS: {0}", Environment.OSVersion) ; // Версия
            // операционной системы
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount); // Количество процессоров
            Console.WriteLine (".NET Version: {0}",
            Environment.Version); // Версия платформы .NET
        }

    }
}
