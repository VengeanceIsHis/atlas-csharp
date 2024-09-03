using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastdigit = Math.Abs(number % 10);
        Console.Write("The last digit of" + " ");
        Console.Write(number + " " + "is" + " " + lastdigit + " ");
        if (lastdigit < 6 && lastdigit != 0)
        {
            Console.WriteLine("and is less than 6 and not 0");
        }
        else if (lastdigit == 0)
        {
            Console.WriteLine("and is 0");
        }
        else
        {
            Console.WriteLine("and is greater than 5");
        }
    }
}