using System;
using static System.Console;

namespace esVettori1
{
	class Program
	{
		static void Main(string[] args)
		{
			int length;
			bool control;

			Write("Inserisci la lunghezza del vettore: ");
			
			do
			{
				control = int.TryParse(ReadLine(), out length);
				if (!control || length <= 0)
				{
					Write("Spiacente, reinserire la lunghezza del vettore: ");
				}
			} 
			while (!control || length <= 0);

			int[] vettore = new int[length];

			for (int i = 0; i < length; i++)
			{
				WriteLine("Inserisci un numero: ");
				int number;

				do
				{
					control = int.TryParse(ReadLine(), out number);
					if (!control || number <= 0)
					{
						Write("Spiacente, reinserire la lunghezza del vettore: ");
					}
				}
				while (!control);

				vettore[i] = number;
			}


			foreach (int item in vettore)
			{
				WriteLine(item);
			}

			for (int j = 0; j < vettore.Length; j++)
			{
				for (int k = j + 1; k < vettore.Length; k++)
				{
					if (vettore[j] == vettore[k])
					{
						WriteLine("1");
						return;
					}
				}
			}

			WriteLine("0");

		}
	}
}