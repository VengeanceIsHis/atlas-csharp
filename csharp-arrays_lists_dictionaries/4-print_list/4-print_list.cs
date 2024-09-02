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
            Console.Write(i + " ");
        }
        Console.WriteLine();
        return temp;
    }
}
