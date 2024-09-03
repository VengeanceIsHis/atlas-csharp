using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("{0:P2}", percent);
        Console.WriteLine("{0:F2}", currency);
	}
}