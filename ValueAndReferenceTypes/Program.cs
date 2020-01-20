using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
            ValueTypeContainingRefType();
        }

        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Points p1 = new Points (10, 10);
            Points p2 = p1;
            // Вывести значения обеих переменных Point,
            p1.Display();
            p2.Display();
            //Изменить pl.X и снова вывести значения переменных.Значение р2.Х не изменилось.
            p1.X = 100;
            Console .WriteLine ( "\n=> Changed pl.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Создать первую переменную Rectangle.
            Console.WriteLine ("-> Creating r1");
            Rectangle r1 = new Rectangle ("First Rect", 10, 10, 50, 50);
            // Присвоить новой переменной Rectangle переменную rl.
            Console.WriteLine ("-> Assigning r2 to r1");
            Rectangle r2 = r1;
            // Изменить некоторые значения в r2.
            Console.WriteLine("-> Changing values of r2");
            r2. RectInfo. InfoString = "This is new info!";
            r2.RectBottom = 4444 ;
            // Вывести значения из обеих переменных Rectangle,
            r1. Display();
            r2 . Display();
        }


        struct Points
        {
            // Поля структуры,
            public int X;
            public int Y;
            // Добавить 1 к позиции (X, Y) .

            public Points(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public void Increment ()
            {
                X++; Y++;
            }
            
            // Вычесть 1 из позиции (X, Y) .
            public void Decrement ()
            {
                X--; Y--;
            }
            // Отобразить текущую позицию,
            public void Display ()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }
        class PointRef
        {
            public int X;
            public int Y;
            // Те же самые члены, что и в структуре Point. . .
            // Не забудьте изменить имя конструктора на PointRef!
            public PointRef(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            
            public void Increment ()
            {
                X++; Y++;
            }
            // Вычесть 1 из позиции (X, Y) .
            public void Decrement ()
            {
                X--; Y--;
            }
            // Отобразить текущую позицию,
            public void Display ()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }
        class ShapeInfo
        {
            public string InfoString;
            public ShapeInfo(string info)
            {
                InfoString = info;
            }
        }
        struct Rectangle
        {
            // Структура Rectangle содержит член ссылочного типа,
            public ShapeInfo RectInfo;
            public int RectTop, RectLeft, RectBottom, RectRight;
            public Rectangle(string info, int top, int left, int bottom, int right)
            {
                RectInfo = new ShapeInfo(info);
                RectTop = top; RectBottom = bottom;
                RectLeft = left; RectRight = right;
            }
            public void Display()
            {
                Console .WriteLine ("String = {0}, Top = {1}, Bottom = {2}, " +
                "Left = {3}, Right = {4}",
                RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
            }
        }
    }
}
