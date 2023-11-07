using System;



class Program
{
   static void Main(string[] args)
     {

        int[] Numbers = new int[3];


        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        Console.WriteLine("==========Using For Loop========== ");
        for(int i = 0; i < Numbers.Length;i++)
        {
            Console.WriteLine(Numbers[i]);

        }

        Console.WriteLine("==========Using While Loop========= ");

        int j = 0;

        while(j < Numbers.Length)
        {
            Console.WriteLine(Numbers[j]);
            j++;
        }

        Console.WriteLine("==========Using ForEach Loop======== ");

        foreach(int k in Numbers) 
        {
            Console.WriteLine(k);
        }


        Console.WriteLine("==========Use Break In For Loop========");

        for(int i = 0; i <=20; i++)
        {
            Console.WriteLine(i);
            if(i ==  10)
            {
                break;
         
            }

        }

        Console.WriteLine("=========Use Continue In For Loop========");

        Console.WriteLine("We are using continue here to print odd numbers");

        for(int i = 0; i <= 20; i++)
        {
            if(i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("=========Use Continue In For Loop========");

        Console.WriteLine("We are using continue here to print even numbers");

        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(i);
        }


        Console.WriteLine("Print Even and Odd Numbers ");

        Console.Write("\n");
        Console.WriteLine("Even Numbers Between 100 to 120 ");

        for (int i = 100; i <= 120; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Odd Numbers Between 100 to 120 ");

        for (int k = 100; k <=120; k++)
       {
            if(k % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(k);
            
       }


    }
}

