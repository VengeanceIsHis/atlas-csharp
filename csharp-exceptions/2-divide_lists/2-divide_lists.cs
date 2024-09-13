using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> temp = new List<int>();
        int result;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                
                result = list1[i] / list2[i];
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            if (i >= list1.Count)
            {
                Console.WriteLine("Out of range");
                
                continue; 
            }
            if (list2[i] == 0)
            {
                temp.Add(0);
            }
            temp.Add(result);      
        }
    }
}