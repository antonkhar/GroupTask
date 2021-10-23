using System;
/*Создать абстрактный класс Vehicle (транспортное средство). На его основе реализовать 
классы Plane (самолет), Саг (автомобиль) и Ship (корабль). Классы должны иметь 
возможность задавать и получать координаты и параметры средств передвижения (цена, скорость, год выпуска и т. п.) с помощью свойств. Для самолета должна быть определена 
высота, для самолета и корабля — количество пассажиров, для корабля — порт приписки. 
Динамические характеристики задать с помощью методов. */
namespace GroupTaskNext1._1
{
    abstract class Vehicle
    {
        private double coordinateX, coordinateY, speed;
        public string Name { get; set; }
        public uint Price { get; set; }
        public uint Year { get; set; }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }
        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public void SpeedMethod(double Speed)
        {
           speed = Speed;
        }
        public void CoordinateMethod(double x, double y)
        {
            coordinateX = x;
            coordinateY = y;
        }
        /// <summary>
        /// объявляем тип переменных для характеристик
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="year"></param>
        /// <param name="speed"></param>
        /// <param name="cordinateA"></param>
        /// <param name="cordinateB"></param>

        public Vehicle (string name, uint price, uint year, double speed, double cordinateA, double cordinateB)
        {
            Name = name;
            Price = price;
            Speed = speed;
            Year = year;
            CoordinateX = cordinateA;//Методами
            CoordinateY = cordinateB;
        }
        /// <summary>
        /// Заполняем класс vehicle характеристиками 
        /// </summary>
        public abstract void Display();

        public abstract override bool Equals(object obj);

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
    class Plane : Vehicle
    {
        public uint Hight { get; set; }
        public uint People { get; set; }
        public Plane (string name, uint price, uint year, double speed, double cordinateA, double cordinateB, uint hight, uint people)
        : base(name,price,year,speed,cordinateA,cordinateB)
        {
            Hight = hight;
            People = people;
        }

        public override void Display()
        {
            Console.WriteLine("Имя: " + Name + " Цена: " + Price + " Скорость: " + Speed + " Год: " + Year + " Координаты: " + CoordinateX + ";" + CoordinateY + " Кол-во людей: " + People + " Высота: " + Hight);
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Plane m = (Plane)obj;
            return (Price == m.Price && Name == m.Name && Speed == m.Speed && CoordinateX == m.CoordinateX && CoordinateY == m.CoordinateY && People == m.People && Hight == m.Hight);
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
    /// <summary>
    /// Присваивание отличительных характеристик для класса plane
    /// </summary>
    class Car : Vehicle
    {

        public Car(string name, uint price, uint year, double speed, double cordinateA, double cordinateB)
        : base(name, price, year, speed, cordinateA, cordinateB)
        {

        }
        public override void Display()
        {
            Console.WriteLine("Имя: " + Name + " Цена: " + Price + " Скорость: " + Speed + " Координаты: " + CoordinateX + ";" + CoordinateY);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Car m = (Car)obj;
            return (Price == m.Price && Name == m.Name && Speed == m.Speed && CoordinateX == m.CoordinateX && CoordinateY == m.CoordinateY);
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
    /// <summary>
    /// Присваивание отличительных характеристик для класса car
    /// </summary>
    class Ship : Vehicle
    {
        public string Port { get; set; }
        public uint People { get; set; }
        public Ship(string name, uint price, uint year, double speed, double cordinateA, double cordinateB, string port, uint people)
        : base(name, price, year, speed, cordinateA, cordinateB)
        {
            Port = port;
            People = people;
        }

        public override void Display()
        {
            Console.WriteLine("Имя: " + Name + " Цена: " + Price + " Скорость: " + Speed + " Координаты: " + CoordinateX + ";" + CoordinateY + " Кол-во людей: " + People + " Порт: " + Port);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Ship m = (Ship)obj;
            return (Price == m.Price && Name == m.Name && Speed == m.Speed && CoordinateX == m.CoordinateX && CoordinateY == m.CoordinateY && People == m.People && Port == m.Port);
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
    /// <summary>
    /// Присваивание отличительных характеристик для класса ship
    /// </summary>
}
