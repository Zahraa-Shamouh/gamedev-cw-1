using System;

namespace ConsoleApp2
{
    class Program
    {
        static double playerSpeed;
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
            string HeroSuperPower1 = "Steel Shiled";
            string HeroSuperPower2 = "Night Vision";

            Console.WriteLine("My name is {0}, my super powers are {1} and {2}. My age is {3} and my speed is {4}", characterName, SuperPower1, SuperPower2, Age, speed);
            Console.WriteLine("My name is {0}, my super powers are {1} and {2}. My age is {3} and my hight is {4}", HeroName, HeroSuperPower1, HeroSuperPower2, HeroAge, HeroHeight);
          
            int AgeDifference = HeroAge - Age;
            Console.WriteLine ("The Age difference is {0}", AgeDifference);

            //Bonus
            if (SuperPower1 == HeroSuperPower1)
            {
                Console.WriteLine("{0} and {1} has the same super power", characterName, HeroName);
            }

            SetSpped(2.5);
            Console.WriteLine("The current player speed is: " + GetSpeed());
            characterPower(); 
         
        }//end main. 

        static void SetSpped(double NewSpeed)
        {
            playerSpeed = NewSpeed; 
        }

        static double GetSpeed()
        {
            return playerSpeed; 
        }

        static void characterPower ()
        {
            int[] characterPowerValue = { 100, 200, 390, 300, 290 };
            if (characterPowerValue[0] > characterPowerValue[2])
                Console.WriteLine(" character power value 1 is greater"); 
            else if (characterPowerValue[0] < characterPowerValue[2])
                Console.WriteLine(" character power value 3 is greater");
            else
                Console.WriteLine(" character power value 1 and 3 are equal");
        }

    }
}
