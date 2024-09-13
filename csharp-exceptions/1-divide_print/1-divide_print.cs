using System;


class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
        }
        catch
        {
            return;
        }
        finally
        {
            return result;
        }
    }
}