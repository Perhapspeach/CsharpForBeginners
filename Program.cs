using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст:   ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 17) 
            {
                Console.WriteLine("Введите имя:       ");
            }
             else
            {
                Console.WriteLine("Брысь !!!");
            }
        }
    
    }
}
