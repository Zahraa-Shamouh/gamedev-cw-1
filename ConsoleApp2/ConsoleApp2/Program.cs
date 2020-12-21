using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Ahmad";
            string SuperPower1 = "Steel Shiled";
            string SuperPower2 = "Night Vision";
            int Age = 15;
            float speed = 1.65f;

            string HeroName = "Ryu";
            float HeroHeight = 1.80f;
            int HeroAge = 18;
            string HeroSuperPower1 = "Night Vision";
            string HeroSuperPower2 = "Steel Shiled";

            Console.WriteLine("My name is {0}, my super powers are {1} and {2}. my age is {3} and my speed is {4}", characterName, SuperPower1, SuperPower2, Age, speed);
            Console.WriteLine("My name is {0}, my super powers are {1} and {2}. my age is {3} and my hight is {4}", HeroName, HeroSuperPower1, HeroSuperPower2, HeroAge, HeroHeight);
            int AgeDifference = HeroAge - Age;
            Console.WriteLine ("The Age difference is {0}", AgeDifference);

        }
    }
}
