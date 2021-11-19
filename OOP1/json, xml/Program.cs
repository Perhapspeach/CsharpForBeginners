using System;
using System.Text.Json;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace json__xml
{
    abstract class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Hero : Character
    {
        public string Behavior { get; set; }

        public Hero(string name, string behavior) : base(name)
        {
            Behavior = behavior;
            Console.WriteLine(behavior);
        }
    }

    class BadGuy : Character
    {
        public string Behavior { get; set; }

        public BadGuy(string name, string behavior) : base(name)
        {
            Behavior = behavior;
            Console.WriteLine(behavior);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero("Witcher", "generous");

            hero.Display();

            var jsonHero = JsonConvert.SerializeObject(hero);
            System.Console.WriteLine(jsonHero);


            var badGuy = new BadGuy("Eredin", "psycho");

            badGuy.Display();

            var jsonBadGuy = JsonConvert.SerializeObject(badGuy);
            System.Console.Write(jsonBadGuy);

        }

    }
}
