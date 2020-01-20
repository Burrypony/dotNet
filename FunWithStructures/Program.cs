using System;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****★ a First Look at Structures *****\n");
            // Создать начальную переменную типа Point.
            Point myPoint;
            Point p2 = new Point (50, 60);
            p2.Display();
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            // Скорректировать значения X и Y.
            myPoint.Increment();
            myPoint.Display();
            Console.ReadLine();
        }
        struct Point
        {
            // Поля структуры,
            public int X;
            public int Y;
            // Добавить 1 к позиции (X, Y) .

            public Point(int XPos, int YPos)
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
    }
}
