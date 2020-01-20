using System;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            DefaultDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStringWithTryParse();
        }

        private static void ParseFromStringWithTryParse()
        {
            Console.WriteLine ("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b));
            {
            Console.WriteLine("Value of b: {0}", b); // Вывод значения b
            }
            string value = "Hello";
            if (double.TryParse(value, out double d) )
            {
            Console.WriteLine ("Value of d: {0}", d) ; // Вывод значения d
            }
            else
            {
            // Преобразование потерпело неудачу
            Console.WriteLine("Failed to convert the input ({0}) to a double",value);
            }
            Console .WriteLine () ;
        }

        private static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine ("Value of b: {0} ", b) ; // Вывод значения b
            double d = double. Parse (" 99. 884 ");
            Console.WriteLine ("Value of d: {0} ", d) ; // Вывод значения d
            int i = int. Parse ( "8") ;
            Console.WriteLine ("Value of l: {0}", i) ; // Вывод значения i
            char c = Char. Parse ( "w" ) ;
            Console.WriteLine ("Value of c: { о } " , c) ; // Вывод значения с
            Console.WriteLine();
        }

        private static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ( 'a' ) : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation(’?'): {0}",
            char.IsPunctuation('?'));
            Console.WriteLine();
        }

        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine ( "Max of int: {0}", int.MaxValue);
            Console.WriteLine ( "Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.Negativelnfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }

        private static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // Ключевое слово int языка C# - это в действительности сокращение для
            // типа System.Int32, который наследует от System.Object следующие члены:
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals (23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString () = {0}", 12.ToString());
            Console.WriteLine("12.GetType () = {0}", 12.GetType ());
            Console.WriteLine();
        }

        private static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables: ");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            System.Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);


        }

        private static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int mylnt = default;
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations: ");
            int myInt = 0;
            string myString;
            myString = "my String";

            bool b1 = true, b2 = false, b3 = b1;

            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
        }
    }
}
