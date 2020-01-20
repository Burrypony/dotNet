using System;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ( "**** Fun with Enums *****");
            ЕmрТуре emp = ЕmрТуре.Contractor;
            AskForBonus(emp);
            // Выводит строку "emp is a Contractor".
            Console.WriteLine("emp is a {0}.", emp.ToString());

            ЕmрТуре e2 = ЕmрТуре.Contractor;
            // Эти типы являются перечислениями из пространства имен System.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();

            Console.ReadLine();
        }

        private static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType ());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Вывести строковое имя и ассоциированное значение,
            // используя флаг формата D (см. главу 3).
            for(int i=0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name : {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine ();
        }

        static void AskForBonus(ЕmрТуре е)
        {
            switch (е)
            {
                case ЕmрТуре.Manager:
                    Console.WriteLine("How about stock options instead?");
                    //He желаете ли взамен фондовые опционы?
                    break;
                case ЕmрТуре.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    // Вы должно быть шутите. . .
                    break;
                case ЕmрТуре.Contractor:
                    Console.WriteLine ("You already get enough cash...");
                    // Вы уже получаете вполне достаточно...
                    break;
                case ЕmрТуре.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    // Очень хорошо, сэр!
                    break;
            }
        }
        enum ЕmрТуре
        {
            Manager, // = О
            Grunt, // = 1
            Contractor, // = 2
            VicePresident // = 3
        }
    }
}
