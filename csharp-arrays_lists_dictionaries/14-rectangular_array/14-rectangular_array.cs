using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                {
                    Console.Write("1 ");
                }
                else
                {
                    if (j == 4)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                    Console.Write("0 ");
                    }
                }

            }
        }
    }
}