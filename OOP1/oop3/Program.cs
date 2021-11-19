using System;

namespace oop3
{
    enum Color
    {
        Rad,
        black
    }
    class Vehicle
    {
        public int WheelSize { get; set; }

        public virtual void display()
        {
            Console.WriteLine($"Размер колес: {WheelSize}");
        }
    }
    class Track : Vehicle
    {
        public string Model { get; set; }
        public Color color;

        public override void display()
        {
            base.display();
            Console.WriteLine($"Цвет: {color} |{"Track"}");
        }
    }
    class Car : Vehicle
    {
        public string Model { get; set; }
        public Color color;

        public override void display()
        {
            base.display();
            Console.WriteLine($"Цвет: {color} |{"Car"}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();


            Track track = new Track();
            track.display();            

            Car car = new Car();
            car.display();


        }
    }
}
