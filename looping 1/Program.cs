using System;

namespace looping_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // {
            //byte age = 13;
            //if (age >= 18)
            //{
            //    Console.WriteLine("Вам уже можно работать");
            //}
            //else if (age >= 14)
            //{
            //    Console.WriteLine("Вам можно работать");
            //    Console.WriteLine("Но лучше учиться");
            //}
            //else
            //{
            //    Console.WriteLine("Вам лучше еще учиться");
            //}
            //string productCategory = "alkohol";
            //switch (productCategory)
            //{
            //    case "alkohol" when age >= 14 && age < 18:
            //        Console.WriteLine("Вам еще мало лет");
            //        break;
            //    case "alkohol" when age >= 18:
            //    case "milk":
            //        Console.WriteLine("Приятной покупки");
            //        break;

            //    default:
            //        Console.WriteLine("Возьмите конфеты");
            //        break;
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //   for (int j = 0; j < 4; j++)
            //   {
            //        Console.Write("[]");
            //   }
            //    Console.WriteLine();

            //}
            //bool isBoiled = false;
            //int  timer = 0;
            //while (!isBoiled)
            //{
            //    Console.Write("[ ]");
            //    if (timer==20)
            //    {
            //        break;
            //    }

            //    if(timer==100)
            //    {
            //        isBoiled = true;
            //    }
            //    timer ++;
            //    if (timer > 10)
            //    {
            //        Console.Write("[X]");
            //        continue;
            //    }
            //}
            //Console.WriteLine();  
            //Console.WriteLine("вода вскипела");   
            //Console.WriteLine("Введите число от 1 до 10");
            //string answer = Console.ReadLine();
            //bool success = int.TryParse(answer, out int value);
            //if (value >= 1 && value<=10)
            //{
            //    Console.Write("Вы ввели "+ value);
            //}


            //bool success = false;
            //Console.WriteLine("Введите число от 1 до 10");
            //do
            //{
            //    string answer = Console.ReadLine();
            //    success = int.TryParse(answer, out int value);
            //    if (value >= 1 && value <= 10)
            //    {
            //        Console.WriteLine("Вы ввели " + value);
            //    }
            //    if (!success)
            //    {
            //        Console.WriteLine("Вы ввели не число");
            //    }

            //} while (!success);

                      

            string[] names = new string[13];
            names[0]="ivan";
            names[1] = "mark";
            names[2] = "kolya";
            names[3] = "maks";
            names[4] = "evgen";
            names[5] = "sergey";

            Console.WriteLine("Введите ваше имя");
            names[6] = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                  Console.WriteLine (names[i]);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }





            



        }
    }
}
    

