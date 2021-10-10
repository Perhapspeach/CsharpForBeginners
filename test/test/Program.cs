using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");  
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            double number3 = number1 / number2;
            double number4 = number1 % number2;
            int numInt = Convert.ToInt32(number3);
            
            
            Console.WriteLine("Выберите действие: + , -, /, * " );
            string select= Console.ReadLine();
            switch (select)
            {
                case "+":
                Console.WriteLine(number1 + number2);
                break;

                case "-":
                    Console.WriteLine(number1 - number2);
                    break;

                case "/":
                    
                    if (number2==0)
                    {   
                      Console.WriteLine("на ноль делить нельзя!");
                    }                   
                      Console.WriteLine($"Целое:{numInt} Остаток: {number4}");
                                            
                     break;

                case "*":
                    Console.WriteLine(number1 * number2);
                    break;

                 
            }
            
            
        }
    }
}
