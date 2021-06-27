using System;

namespace C__Program
{
    class Program
    {
        static void Main(string[] args)
        { 
           Random numberGen = new Random();


            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice");

        
            while(roll1 != roll2)
            {
                Console.ReadKey();

                roll1 = numberGen.Next(1, 11);
                roll2 = numberGen.Next(1, 11);
                
                Console.WriteLine("You rolled a " + roll1 + " and a " + roll2);

                attempts++;
            }

                Console.WriteLine("It took you " + attempts + " attempts to roll a matching pair.");

            //Wait before closing
            Console.ReadKey();
        }
    }
}
