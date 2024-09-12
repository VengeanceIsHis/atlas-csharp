using System;
using System.Collections.Generic;


class List

{
    public static int SafePrint(List<int> myList, int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            try
            {
                Console.Write(myList[i]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Write("Error index out of range");
            }
            catch (Exception ex)
            {
                Console.Write($"Unexpected error: {ex.Message}");
            }
            result++;
        }
    }
}