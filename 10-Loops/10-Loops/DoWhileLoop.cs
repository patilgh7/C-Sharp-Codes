using System;



class DoWhileLoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0; 
            
            while(Start <= UserTarget)
        {
             Console.Write(Start + " ");
             Start = Start + 2;
        }

        string UserChoice = "";

        do
        {
            Console.WriteLine("Do you want to continue - Yes or No ? ");

            UserChoice = Console.ReadLine();

            if (UserChoice != "Yes" && UserChoice != "No")
            {
                Console.WriteLine("Invalid choice , Please Say Yes or No ");

            }
        } while (UserChoice != "Yes" && UserChoice != "No");

           

    }

   
       
    }

