using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 99; i++)
        {
            string hex = "0x" + i.ToString("X");
            Console.WriteLine(i + " " + "=" + " " + hex);
        }
    }
}