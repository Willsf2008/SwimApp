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

        static float fastestTime = 9999f;
        static string topSwimmer = "";
        
        static void OneSwimmer()
        {


            //Display.
           Console.WriteLine("Enter the swimmer's name:");
            
           string swimmerName = Console.ReadLine();
            
           Console.WriteLine($"Swimmer name: {swimmerName}");

            
            
            
            float totalTime = 0, average;

              for (int i = 0; i < 4; i++)

              {
                int minutes, seconds;
                int totalSeconds = 0;
                //Generate a random number between 1,4 incl. Generate number between 1,59 incl.
                Random randomNumber = new Random();
                minutes = randomNumber.Next(1, 4);
                seconds = randomNumber.Next(1, 59);
                totalSeconds = (minutes * 60) + seconds;
                Console.WriteLine($"Swimmer time {i+1}: {minutes} minutes {seconds} seconds \t\t  total time in seconds: {totalSeconds}");
                totalTime += totalSeconds;
                
                


              }
            float avgTime = (float)totalTime / 4;
            if (avgTime < fastestTime)
            {
                fastestTime = avgTime;
                topSwimmer = swimmerName;
            }

            string allocatedTeam = "Reserve";


            average = totalTime / 4;


            Console.WriteLine($"Swimmer average: {average} seconds");


            //Allocate swimmer a team
            if (average <= 160)
            {
                teamA.Add(swimmerName);
                allocatedTeam = "A";

            }
            else if (average <= 210)
            {
                teamB.Add(swimmerName);
                allocatedTeam = "B";
            }
            else
            {
                teamReserves.Add(swimmerName);
            }

            Console.WriteLine($"Team: {allocatedTeam}");
        }

        //method returns a string containing team lists
        static string createTeamList()
        {
            string teamlists = "The teams are: \n\nTeam A\n";


            //add teamA to teamList
            foreach(string swimmer in teamA)
            {
                teamlists += swimmer + "\t";
            }
            teamlists += $"\nwith {teamA.Count} team member(s)\n\nTeamB\n";

            //add teamB to teamList
            foreach (string swimmer in teamB)
            {
                teamlists += swimmer + "\t";
            }
            teamlists += $"\nwith {teamB.Count} team member(s)\n\nTeamReserves\n";
            
            //add teamReserves to teamList
            foreach (string swimmer in teamReserves)
            {
                teamlists += swimmer + "\t";
            }
            teamlists += $"\nwith {teamReserves.Count} team member(s)\n\n";

            

            return teamlists;

        }
        

        



        static void Main(string[] args)
        {
            string flag =  "";

            while (!flag.Equals("Stop"))
            {
                OneSwimmer();
                Console.WriteLine("Press enter to add another swimmer or type 'Stop' to end");
                flag = Console.ReadLine();
            }


            Console.WriteLine($"The fastest swimmer was {topSwimmer} with an average time os {fastestTime} seconds.");
            Console.WriteLine(createTeamList());


        }
        
          
    }
}