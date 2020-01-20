using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine ("***** Fun with Class Types *****\n");
            // Создать объект Car по имени Chuck co скоростью 10 миль в час.
            Car chuck = new Car () ;
            chuck.PrintState () ;
            // Создать объект Car по имени Mary co скоростью 0 миль в час.
            Car тагу = new Car("Mary");
            тагу.PrintState () ;
            // Создать объект Car по имени Daisy со скоростью 75 миль в час.
            Car daisy = new Car ("Daisy", 75);
            daisy.PrintState();
            // Разместить в памяти и сконфигурировать объект Саг.
            Car myCar = new Car () ;
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            // Увеличить скорость автомобиля в несколько раз и вывести новое состояние,
            for (int i = 0; i <= 10; i++)
            {
                myCar.Speedup(5);
                myCar.PrintState ();
            }

            Motorcycle me = new Motorcycle();
            me.PopAWheely();

            Motorcycle c = new Motorcycle (5) ;
            c.SetDriverName ( "Tiny") ;
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name); // Выводит пустое значение name!

            Console.ReadLine();
        }
    }
}
