using System;
using System.Threading;

class ArrayPractice
{
    static void Main(string[] args)
    {

        int TotalCoffeeCost = 0;

        Start:
        Console.WriteLine("\n 1.small \n 2.medium \n 3.large \n");
        int UserChoice = int.Parse(Console.ReadLine());

        switch(UserChoice)
        {
            case 1: 
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your Choice {0} is invalid ", UserChoice);
                break;
        }

        Decide:
        Console.WriteLine("Do you want another coffee - Yes or No");
        string UserDecision = Console.ReadLine();

        switch(UserDecision.ToLower())
        {
            case "yes":
                goto Start;
            case "no":
                break;
            default :
                Console.WriteLine("Your choice is invalid {0} ", UserDecision);
                goto Decide;
        }

        Console.WriteLine("Bill Amount : {0}rs. ", UserChoice);
    }
}

