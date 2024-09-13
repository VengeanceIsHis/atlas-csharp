using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> temp = new List<int>();
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
                else
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