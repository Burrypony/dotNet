using System;
using System.Linq;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverlnts();
            WhileLoopExample();
            DoWhileLoopExample();
            ExecutelfElseUsingConditionalOperator();
            SwitchExample();
            ExecutePatternMatchingSwitch();
        }

        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine ();
            object choice;
            // Стандартный оператор switch, в котором применяется
            // сопоставление с образцом с константами
            switch (userChoice)
            {
            case "1":
                choice = 5;
                break;

            case "2":
                choice = "Hi";
                break;

            case "3":
                choice = 2.5;
                break;

            default:
                choice = 5;
                break;
            }
            // Новый оператор switch, в котором применяется
            // сопоставление с образцом с типами
            switch (choice)
            {
            case int i:
            Console.WriteLine("Your choice is an integer.");
            // Выбрано целое число
            break;
            case string s:
            Console.WriteLine("Your choice is a string.");
            // Выбрана строка
            break;
            case decimal d:
            Console.WriteLine("Your choice is a decimal.");
            // Выбрано десятичное число
            break;
            default:
            Console.WriteLine("Your choice is something else");
            // Выбрано что-то другое
            break;
            }
            Console.WriteLine();  
        }

        private static void SwitchExample()
        {
            Console.WriteLine ("1 [C#]z 2 [VB]");
            Console.Write("Please pick your language preference: ");
            // Выберите предпочитаемый язык:
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);
            switch (n)
            {
            case 1:
            Console.WriteLine ("Good choice, C# is a fine language.");
            // Хороший выбор. C# - замечательный язык.
            break;
            case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            // VB: ООП, многопоточность и многое другое!
            break;
            default:
            Console.WriteLine("Well... good luck with that!");
            // Хорошо, удачи с этим!
            break;
            }
        }

        private static void ExecutelfElseUsingConditionalOperator()
        {
            
        string stringData = "";
        Console.WriteLine(stringData.Length > 0
            ? "string is greater than 0 characters"
            : "string is not greater than 0 characters");
        Console.WriteLine();
        }

        private static void DoWhileLoopExample()
        {
            string userlsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userlsDone = Console.ReadLine () ;
            }
            while(userlsDone.ToLower() != "yes"); //Обратите внимание на точку с запятой!
        }

        private static void WhileLoopExample()
        {
            string userlsDone = "";
            // Проверить копию строки в нижнем регистре,
            while(userlsDone.ToLower() != "yes")
            {
                Console.WriteLine ( "In while loop");
                Console.Write("Are you done? [yes] [no]: "); // Запрос продолжения
                userlsDone = Console.ReadLine();
            }
        }

        private static void LinqQueryOverlnts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // Запрос LINQ!
            var subset = from i in numbers where i <= 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
                {
                Console.Write($" {i} ");
                }
        }

        private static void ForEachLoopExample()
        {
            string [] carTypes = {"Ford", "BMW", "Yugo", "Honda"};
            foreach (string c in carTypes)
            Console.WriteLine(c) ;
            int [ ] mylnts = { 10, 20, 30, 40 };
            foreach (int i in mylnts)
            Console.WriteLine(i);
        }

        private static void ForLoopExample()
        {
            // Обратите внимание, что переменная i видима только в контексте цикла for.
            for(int i=0; i < 4; i++)
            {
            Console.WriteLine("Number is: {0} ", i);
            }
            // Здесь переменная i больше видимой не будет.
        }
    }
}
