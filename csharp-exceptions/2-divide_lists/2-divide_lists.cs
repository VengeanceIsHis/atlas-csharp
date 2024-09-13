using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> temp = new List<int>();
        int result = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    Console.WriteLine("Out of range");
                    temp.Add(0);
                    continue;
                }
                result = list1[i] / list2[i];
                temp.Add(result); 
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                temp.Add(0);
            }
                if (list2[i] == 0)
                {
                    temp.Add(0);
                }
                else
                {
                temp.Add(result);
                }
        }
        return temp;
    }
}