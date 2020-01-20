using System;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
        }

        private static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = String.Concat(s1 + s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        private static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            // Значение firstName.
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            // Длина firstname.
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            // firstName в верхнем регистре.
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower ());
            // firstName в нижнем регистре.
            Console.WriteLine("firstName contains the letter у?:{0}",firstName.Contains("y"));
            // Содержит ли firstName букву у?
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            // firstName после замены.
            Console.WriteLine() ;
        }
    }
}
