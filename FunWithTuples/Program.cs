using System;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var samples = FillTheseValues () ;
            Console.WriteLine($"Int is: {samples.a}") ;
            Console.WriteLine ($"Stnng is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");
            
            
            var name = SplitNames("Philip F Japikse") ;
            System.Console.WriteLine(name);


            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");


            Point p = new Point (7,5);
            var pointValues = p.Deconstruct();
            Console.WriteLine ($"X is: {pointValues.XPos}") ;
            Console.WriteLine ($"Y is: {pointValues.YPos}");

        }

        static (int a,string b,bool c) FillTheseValues ()
        {
            return (9, "Enjoy your string.",true);
        }

        static (string first, string middle, string last) SplitNames(string fullName)
        {
        // Действия, необходимые для расщепления полного имени,
        return ("Philip", "F", "Japikse");
        }

        struct Point
        {
        // Поля структуры,
        public int X;
        public int Y;
        // Специальный конструктор,
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
        public (int XPos, int YPos) Deconstruct() => (X, Y) ;
        }
    }
}
