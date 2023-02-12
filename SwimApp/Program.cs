using System;
using System.Collections.Generic;

namespace SwimApp
{
    class Program
    {
        //global variables
        static List<string> teamA = new List<string>();
        static List<string> teamB = new List<string>();
        static List<string> teamReserves = new List<string>();
        
        static void OneSwimmer()
        {


            //Display.
           Console.WriteLine("Enter the swimmer's name:");
            
           string swimmerName = Console.ReadLine();
            
           Console.WriteLine($"Swimmer name: {swimmerName}");

            int totalTime = 0;
            
            
            float swimmerTime = 0, average;

              for (int i = 0; i < 4; i++)

              {
                int minutes, seconds;
                totalTime = 0;
                //Generate a random number between 1,4 incl. Generate number between 1,59 incl.
                Random randomNumber = new Random();
                minutes = randomNumber.Next(1, 4);
                seconds = randomNumber.Next(1, 59);
                totalTime = (minutes * 60) + seconds;
                Console.WriteLine($"Swimmer time {i+1}: {minutes},{seconds} in seconds: {totalTime}");
                swimmerTime += totalTime;
                
                


              }
            average = swimmerTime / 4;
            Console.WriteLine($"Swimmer average: {average} seconds");
            //Allocate swimmer a team
            if (average <= 160)
            {
                teamA.Add(swimmerName);

            }
            else if (average <= 210)
            {
                teamB.Add(swimmerName);
            }
            else
            {
                teamReserves.Add(swimmerName);
            }
                    
            
            
            


        }
        static void Main(string[] args)
        {
            
            
            


            OneSwimmer();
 



        }
        
          
    }
}