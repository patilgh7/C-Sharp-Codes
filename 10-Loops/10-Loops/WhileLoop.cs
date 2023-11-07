using System;



class WhileLoopDemo
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

        }
    }

