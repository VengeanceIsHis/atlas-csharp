using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
           
            string formattedNumber = i < 10 ? $"0{i}" : i.ToString();
            
            Console.Write(formattedNumber + (i < 99 ? ", " : "\n"));
        }
    }
}