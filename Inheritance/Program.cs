using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird eagle = new Bird();

            eagle.legNum = 2;
            eagle.canFly = true;
            eagle.isNocturnal = false;
            eagle.noise = "kaww";
            eagle.runningSpeed = 22;
            Console.WriteLine($"The Eagle has {eagle.legNum} legs and makes the {eagle.noise} sound. Eagles rarely run, but when they do, its {eagle.runningSpeed} mph");
            Console.WriteLine($"The fact that eagles can fly is {eagle.canFly} and nocturnal is {eagle.isNocturnal}. ");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile lizard  = new Reptile();
            lizard.noise = "hss";
            lizard.runningSpeed = 12;
            lizard.fangCount = 1;
            lizard.coldBlood = true;
            lizard.legNum = 4;
            lizard.liveInSwamp = true;
            Console.WriteLine($"Lizards have {lizard.legNum} legs and have a fang count of {lizard.fangCount}.");
            Console.WriteLine($"Although quiet, lizards make the {lizard.noise} noise when provoked. Lizards run at a whopping {lizard.runningSpeed}.");
            Console.WriteLine($"The fact that lizards live in swamps as cold-blooded monsters is { lizard.coldBlood}");

            
        }   
    }
}
