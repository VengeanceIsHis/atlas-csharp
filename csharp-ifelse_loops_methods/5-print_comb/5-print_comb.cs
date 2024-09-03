using System;

class Program
{
    static void Main()
    {
       
        string output = "";

        for (int i = 0; i < 100; i++)
        {
          
            string formattedNumber = i < 10 ? $"0{i}" : i.ToString();
            
            output += formattedNumber + (i < 99 ? ", " : "\n");
        }
        
        Console.Write(output);
    }
}