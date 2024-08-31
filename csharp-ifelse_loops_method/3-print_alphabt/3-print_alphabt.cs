using System;

class Program
{
    static void Main()
    {
        string result = "";
        for (int i = 97; i < 123; i++)
        {
            if (i == 113 || i == 101)
            {
                continue;
            }
            else
            {
                result += (char)i;
            }
        }
        Console.Write(result);
    }
}