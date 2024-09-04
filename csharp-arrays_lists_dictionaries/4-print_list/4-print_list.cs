using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> temp = new List<int>();

        for (int i = 0; i < size; i++)
        {
            temp.Add(i);
            if (i == size - 1)
            {
                Console.Write(i);
            }
            else
            {
            Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        return temp;
    }
}