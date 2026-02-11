using System;
using static System.Console;

namespace esVettori2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[] numeri = new int[30];

			Write("Vettore di 30 numeri casuali compresi tra 1 e 100: ");

			for (int i = 0; i < numeri.Length; i++)
			{
				numeri[i] = rnd.Next(0, 101);
				Write($"{numeri[i]} ");
			}

			WriteLine("\n");
			Write("Numeri doppi trovati: ");

			for (int j = 0; j < numeri.Length - 1; j++)
			{
				for (int k = j + 1; k < numeri.Length; k++)
				{
					if (numeri[j] == numeri[k] * 2)
					{
						Write($" {numeri[j]} {numeri[k]} / ");
					}
					else if (numeri[k] == numeri[j] * 2)
					{
						Write($" {numeri[k]} {numeri[j]} / ");
					}
				}
			}
		}
	}
}