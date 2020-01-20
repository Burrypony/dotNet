using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("***** Fun with type conversions *****") ;
            // Добавить две переменные типа short и вывести результат,
            short numbl = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}",numbl, numb2, Add(numbl, numb2));
            Console.ReadLine ();
            }
            static int Add (int x, int y)
            {
            return x + y;
                    }
    }
}
