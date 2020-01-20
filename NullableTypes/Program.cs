using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader ();
            // Получить значение int из "базы данных",
            int? i = dr.GetIntFromDatabase () ;
            if (i.HasValue)
                Console.WriteLine("Value of ' i' is: {0}", i.Value);
            // вывод значения переменной i
            else
                Console.WriteLine("Value of 'i' is undefined.");
            // значение переменной i не определено
            // Получить значение bool из "базы данных",
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine("Value of ’b' is: {0}", b.Value);
            // вывод значения переменной b
            else
                Console.WriteLine("Value of ’b’ is undefined.");
            // значение переменной b не определено
            Console.ReadLine();
        }

        class DatabaseReader
        {
            // Поле данных типа, допускающего null,
            public int? numencValue = null;
            public bool? boolValue = null;
            // Обратите внимание на возвращаемый тип, допускающий null,
            public int? GetIntFromDatabase ()
                { return numencValue; }
            // Обратите внимание на возвращаемый тип, допускающий null,
            public bool? GetBoolFromDatabase ()
                { return boolValue; }
        }

    }
}
