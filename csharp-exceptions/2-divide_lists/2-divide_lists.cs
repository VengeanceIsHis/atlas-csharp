using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> temp = new List<int>();
        int length = 0;
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
                else if (i < list2.Count)
                {
                    int result = list1[i] / list2[i];

                    
                    temp.Add(result);
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                temp.Add(0);
                continue;
            }

        }
        return temp;
    }
}