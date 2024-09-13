using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> temp = new List<int>();
        int length = 0;
        if (listLength > list1.Count)
        {
            length = list1.Count;
        }
        else if (listLength > list2.Count)
        {
            length = list2.Count;
        }
        else
        {
            length = listLength;
        }
        for (int i = 0; i < length; i++)
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
        Console.WriteLine(temp[0] + temp[1] + temp[2]);
        return temp;
    }
}