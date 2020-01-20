using System;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclarelmplicitVars();
        }

        private static void DeclarelmplicitVars()
        {
            var mylnt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
        
            // Вывести имена лежащих в основе типов.
            Console.WriteLine($"mylnt is a: {mylnt.GetType () .Name}");
            // Вывод типа mylnt
            Console.WriteLine($"myBool is a: {myBool.GetType().Name}");
            // Вывод типа myBool
            Console.WriteLine($"myString is a: {myString.GetType().Name}") ;
            // Вывод типа myString
        
        }
    }
}
