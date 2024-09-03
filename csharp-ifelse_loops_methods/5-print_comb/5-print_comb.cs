using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
           
            if (i < 99)
            {
                Console.Write("{0:D2}, ", i);
            }
            else
            {
                Console.WriteLine("{0:D2}", i);
            }
        }
    }
}