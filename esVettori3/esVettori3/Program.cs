using System;
using static System.Console;

namespace esVettori3
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] numeri = new float[99];
			float somma = 0;
			bool control;
			int c = 0;

			WriteLine("Programma che legge una sequenza di numeri e cerca una coppia di numeri con rapporto uguale al primo numero immesso");
			WriteLine();
			WriteLine("Inserire i numeri in esame, terminazione della lettura se somma di essi maggiore di 50 o sono più di 100 numeri");
			WriteLine();

			foreach (int i in numeri)
			{
				numeri[i] = 0;
			}

			while (somma <= 50 && c!=100)
			{
				float n;
				do
				{
					Write("Inserire un numero: ");
					control = float.TryParse(ReadLine(), out n);
				}
				while (!control || n == 0);

				somma += n;
				numeri[c] = n;

				c++;
			}
			if (numeri[2] == 0)
			{
				WriteLine("Sono stati inseriti meno di 3 numeri, conclusione del programma");
			}
			else
			{
				for (int j = 0; j < numeri.Length; j++)
				{
					for (int k = 0;  k < numeri.Length; k++)
					{
						if (j != k && numeri[j] / numeri[k] == numeri[0]) 
						{
							WriteLine($"Il rapporto tra {numeri[j]} e {numeri[k]} è uguale a {numeri[0]}");
						}
					}
				}
			}
		}
	}
}