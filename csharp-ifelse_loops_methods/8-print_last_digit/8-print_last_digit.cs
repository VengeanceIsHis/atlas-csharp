using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        Console.Write(number % 10);
        return Math.Abs(number % 10);
    }
}

