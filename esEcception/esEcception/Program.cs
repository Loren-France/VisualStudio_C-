using System;
using System.Collections.Generic;


namespace esEcception
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Inserire il dividendo: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Inserire il divisore: ");
			int num2 = int.Parse(Console.ReadLine());
			Calcolatrice calcolatrice = new Calcolatrice(num1, num2);
			double result = calcolatrice.Dividi(num1, num2);
			Console.WriteLine($"Risultato della divisione: {result}");
		}
	}
}
