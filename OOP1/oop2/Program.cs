using System;

namespace oop2
{
    class Vehicle
    {
        public string Model { get; set; }
        public int WheelSize { get; set; }
        public Vehicle(int wheelSize)
        {
            WheelSize = wheelSize;
        }
        public virtual void display()
        {
            Console.WriteLine($"Модель: {Model} | Размер колес:{WheelSize}");
        }
    }
    class Track : Vehicle
    {
        public string Color { get; set; }
        public Track(int wheelSize, string color) : base(wheelSize)
        {
            Color = color;
        }
        public override void display()
        {
            Console.WriteLine($"Модель:{"Trak"} | Размер колес:{WheelSize} | Цвет:{Color}");
        }
    }
    class Car : Vehicle
    {
        public string Color { get; set; }
        public Car(int wheelSize, string color) : base(wheelSize)
        {
            Color = color;
        }
        public override void display()
        {
            
            Console.WriteLine($"Модель:{"Car"} | Размер колес:{WheelSize} | Цвет:{Color}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle(500);
            vehicle1.display();

            Track vehikle1 = new Track(1000, "Синий");
            vehikle1.display();

            Car vehikle3 = new Car (2000, "Черный");
            vehikle1.display();

        }
    }
}
