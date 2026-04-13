using System;
using System.Collections.Generic;

namespace esOperatoreSIM
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CartaSIM sim = new CartaSIM(34836391524, 30);
			int n = 0;
			Console.Write("Inserire quante telefonate sono state fatte: ");
			n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.Write($"\nInserire la durata della telefonata {i + 1} in minuti: ");
				int durata = int.Parse(Console.ReadLine());
				Console.Write($"\nInserire il numero chiamato della telefonata {i + 1}: ");
				long numeroChiamato = long.Parse(Console.ReadLine());
				Telefonata chiamata = new Telefonata(durata, numeroChiamato);
				sim.AggiungiTelefonata(chiamata);
			}
			Console.WriteLine("\nCarta SIM:");
			Console.WriteLine(sim.Stampa2());
			Console.WriteLine("Telefonate:");
			sim.StampaLista();
			Console.WriteLine($"\nMinuti totali: {sim.MinutiTotali()}");
			Console.WriteLine($"\nTelefonate effettuate per ogni numero: ");
			sim.TotaliTelefonate();
		}
	}
}