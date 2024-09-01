using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
            Console.WriteLine("\\");
            }
            else
            {
                Console.Write("\\");
            }
        }
    }
}