using System;

namespace GroupTaskNext1._1
{
    class Demonstration
    {
        static void Main(string[] args)
        {
            uint temp; 
            Console.WriteLine("Сколько элементов транспорта вы хотите добавить в список?");
            temp = UInt32.Parse(Console.ReadLine());
            if (temp < 1 || temp > 3)
            {
                throw new QuantityTypesExcept();
            }
            Vehicle[] array = new Vehicle[temp];
            for (int i = 0; i<array.Length ; i++ )
            {
                Console.WriteLine("Какой вид транспорта вы хотите добавить? (можно добавить только по 1 элементу каждого вида (Машина, Корабль, Самолет");
                Console.WriteLine("1. Машина");
                Console.WriteLine("2. Корабль");
                Console.WriteLine("3. Самолет");
                temp = UInt32.Parse(Console.ReadLine());
                if (temp < 1 || temp > 3)
                {
                    throw new QuantityTypesExcept();
                }
                switch (temp)
                {
                    case (1):
                        Car car = new Car("Каен", 200000, 2005, 0, 0, 0);
                        Console.WriteLine("Транспорт успешно добавлен");
                        car.Display();
                        break;
                    case (2):
                        Ship ship = new Ship("Корабь", 1000000, 2020, 300, 100, 100, "Гавань", 25);
                        Console.WriteLine("Транспорт успешно добавлен");
                        ship.Display();
                        break;
                    case (3):
                        Plane plane = new Plane("Гагарин",500000000, 1999, 10000, 500, 500, 10000, 100);
                        Console.WriteLine("Транспорт успешно добавлен");
                        plane.Display();
                        break;
                    default:
                        throw new QuantityTypesExcept();
                }
            }
        }
    }
}
