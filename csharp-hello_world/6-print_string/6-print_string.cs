using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string first9Chars = str.Substring(0, 9);
		Console.WriteLine(str + str + str);
        Console.WriteLine(first9Chars);
        }
}