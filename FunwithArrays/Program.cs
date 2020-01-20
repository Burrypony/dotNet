using System;

namespace FunwithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** FunWithArrays *****");
            SimpleArrays();
            Arraylnitialization();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            Console.ReadLine();
        }

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // Зубчатый многомерный массив (т.е. массив массивов).
            // Здесь мы имеем массив из 5 разных массивов,
            int[] [] myJagArray = new int [5] [ ] ;
            // Создать зубчатый массив.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray [i] = new int[i + 7];
            // Вывести все строки (помните, что каждый элемент имеет стандартное значение 0).
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[1].Length; j++)
                    Console.Write(myJagArray[1][j] + " ");
                Console.WriteLine();    
            }
            Console.WriteLine();
        }

        private static void RectMultidimensionalArray()
        {
            
            Console.WriteLine("=> Rectangular multidimensional array.");
            // Прямоугольный многомерный массив.
            int[,] myMatrix;
            myMatrix = new int [3,4];
            // Заполнить массив (3 * 4).
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] =i * j;
            // Вывести содержимое массива (3 * 4) .
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                System.Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            // Массив объектов может содержать все что угодно,
            object [] myObjects = new object [4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects [2] = new DateTime(1969, 3, 24);
            myObjects [3] = "Form & Void";
            foreach (object obj in myObjects)
            {
            // Вывести тип и значение каждого элемента в массиве.
            Console.WriteLine("Туре: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        private static void Arraylnitialization()
        {
            
            Console.WriteLine("=> Array Initialization.");
            // Синтаксис инициализации массива с использованием ключевого слова new.
            string[] stringArray = new string[]
            { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Синтаксис инициализации массива без использования ключевого слова new.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            // Инициализация массива с применением ключевого слова new и указанием размера.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        private static void SimpleArrays()
        {
         Console.WriteLine ( "=> Simple Array Creation.");
        // Создать и заполнить массив из трех целочисленных значений.
        int[] mylnts = new int [3] ;
        mylnts[0] = 100;
        mylnts[1] = 200;
        mylnts [2] = 300;
        // Вывести все значения.
        foreach(int i in mylnts)
            Console.WriteLine(i) ;
        Console.WriteLine ();
        }
    }
}
