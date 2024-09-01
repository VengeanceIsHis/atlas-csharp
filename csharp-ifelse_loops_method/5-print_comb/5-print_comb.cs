using System;

class Program
{
    static void main()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i < 10)
            {
                Console.Write("0" + i + ", ");
            }
            else if (i == 99)
            {
                Console.WriteLine("99");
            }
            else
            {
                Console.Write(i + ", ");
            }
        }
    }
}