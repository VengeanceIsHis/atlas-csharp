using System;


class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch
        {
            return;
        }
        finally
        {
            Console.WriteLine(a + " " + / + " " + b + " " + result);
        }
    }
}