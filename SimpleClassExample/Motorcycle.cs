using System;

namespace SimpleClassExample
{
    class Motorcycle
    {
// Новые члены для представления имени водителя,
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public int driverIntensity;
        public void PopAWheely ()
        {
            for (int i=0; i <= driverIntensity; i++)
                {
                    Console.WriteLine ("Yeeeeeee Haaaaaeewww ! " ) ;
                }
        }
        // Вернуть стандартный конструктор, который будет
        // устанавливать все члены данных в стандартные значения,
        public Motorcycle () {}
        // Специальный конструктор,
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}