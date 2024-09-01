using System;

Class Line
{
    public static void PrintLine(int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
            Console.WriteLine("_");
            }
            else
            {
                Console.Write("_");
            }
        }
    }
}