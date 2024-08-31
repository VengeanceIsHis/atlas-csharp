using System;

class Program
{
    static void Main()
    {
        string result = "";
        for (int i = 97; i < 123; i++)
        {
            result += (char)i;
        }
        Console.WriteLine(result);
    }
}