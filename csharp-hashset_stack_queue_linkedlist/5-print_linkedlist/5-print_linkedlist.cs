using System;
using System.Collections.Generic;


class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> result = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            result.AddLast(i);
        }
        return result;
    }
}