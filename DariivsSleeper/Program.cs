using System;

namespace DariivsSleeper.cs
{
    class Program 
    {


        static void Main(string[] args)
        {
            Warrior Darii = new Warrior("Darii", 2000, 240, 50);

            Warrior Slipper = new Warrior("Slipper", 2000, 240, 50);  
            
            Battle.StartFight(Darii, Slipper);

            Console.ReadLine();
        }
    
    
    }
}