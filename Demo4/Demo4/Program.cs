using System;

    class Program
    {
        static void Main(string[] args)
        {

        int i = 100;

        float f = 10554646446642.266F;

        long l = Convert.ToInt64(f);
        Console.WriteLine(l);

        string strNumber = "200";

        int k = int.Parse(strNumber);

        Console.WriteLine(k);



        string str = "100";

        int Result = 0;


        bool v = int.TryParse(str, out Result);

        Console.WriteLine(v);

    }
    }

