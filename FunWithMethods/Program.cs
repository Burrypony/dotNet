using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console . WriteLine ("***** Fun with Methods *****\n");
            string strl = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1} ", strl, str2);
            SwapStrings(ref strl, ref str2);
            Console.WriteLine("After: {0}f {1} ", strl, str2);

            #region Ref locals and params
            string [] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> Use Simple Return");
            Console.WriteLine("Before: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            var output = SimpleReturn(stringArray, pos);
            output = "new";
            Console.WriteLine("After: {0}, {1}, {2} ", stringArray[0],
            stringArray[1], stringArray[2]);
            #endregion

            DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);

            Console.ReadLine();
        }

        private static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Сохранить старые цвета для их восстановления после вывода сообщения.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Установить новые цвета и вывести сообщение.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Восстановить предыдущие цвета.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }

        public static void SwapStrings (ref string si, ref string s2)
        {
            string tempStr = si;
            si = s2;
            s2 = tempStr;
        }

        public static string SimpleReturn(string[] strArray, int position)
        {
            return strArray[position];
        }
    }
}
