using System;
using static System.Console;

namespace esDinosauri
{
	enum TipoDinosauro
	{
		Brontosauro,
		Triceratopo,
		Pterodattilo,
		TRex,
		Stegosauro
	}
	enum Taglia
	{
		Piccolo,
		Medio,
		Grande
	}
	struct Dinosauro
	{
		public int code;
		public TipoDinosauro Tipo;
		public Taglia taglia;
		public int età;
		public int forza;
		public string Proprietario;
		public Dinosauro(int code, TipoDinosauro tipo, Taglia taglia, int età, int forza, string proprietario)
		{
			this.code = code;
			this.Tipo = tipo;
			this.taglia = taglia;
			this.età = età;
			this.forza = forza;
			this.Proprietario = proprietario;
		}
		public string Stampa()
		{
			return $"Codice: {code}, Tipo: {Tipo}, Taglia: {taglia}, Età: {età}, Forza: {forza}, Proprietario: {Proprietario}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			bool control = true;

			Random rand = new Random();

			bool cicle = true;

			int action;

			int dimensione = rand.Next(1, 21);

			string proprietario = "Nessuno";

			Dinosauro[] Recinto = new Dinosauro[dimensione];

			for (int i = 0; i < dimensione; i++)
			{
				Recinto[i] = new Dinosauro();

				int tipologia = rand.Next(0, 5);

				int taglia = rand.Next(0, 3);

				int età = rand.Next(1, 101);

				int forza = rand.Next(1, 101);

				Recinto[i].code = i + 1;

				Recinto[i].Tipo = (TipoDinosauro)tipologia;

				Recinto[i].taglia = (Taglia)taglia;

				Recinto[i].età = età;

				Recinto[i].forza = forza;

				Recinto[i].Proprietario = proprietario;
			}

			WriteLine("Programma che permette di gestire i dinosauri di un recinto");
			WriteLine();
			WriteLine("Dinosauri presenti nel recinto:");
			for (int i = 0; i < Recinto.Length; i++)
			{
				WriteLine(Recinto[i].Stampa());
			}

			while (cicle)
			{
				WriteLine();
				WriteLine("Azioni disponibili: ");
				WriteLine("1. Prendi un dinosauro");
				WriteLine("2. Cambia proprietario di un dinosauro");
				WriteLine("3. Visualizza i dinosauri");
				WriteLine("4. Visualizza per tipo");
				WriteLine("5. Visualizza per taglia");
				WriteLine("6. Esci");

				WriteLine("\n");

				Write("Dimmi l'azione da eseguire: ");
				do
				{
					control = int.TryParse(ReadLine(), out action);

					if (!control || action < 1 || action > 6)
					{
						Write("Azione non valida. Reimmettere: ");
					}
				} while (!control || action < 1 || action > 6);

				switch (action)
				{

					case 1:
						PrendiDinosauro(Recinto, control);
						WriteLine("Dinosauro preso con successo");
						break;
					case 2:
						CambioProprietà(Recinto, control);
						WriteLine("Proprietario cambiato con successo");
						break;
					case 3:
						VisualizzaDinosauri(Recinto);
						break;
					case 4:
						VisualizzaTipo(Recinto,control);
						break;
					case 5:
						VisualizzaTaglia(Recinto,control);
						break;
					case 6:
						cicle = false;
						break;

					default:
						WriteLine("Azione non valida.");
						break;
				}
			}
		}

		static Dinosauro PrendiDinosauro(Dinosauro[] recinto, bool control)
		{
			int code;
			string nome;
			Write("Dimmi il codice del dinosauro da prendere: ");

			do
			{
				control = int.TryParse(ReadLine(), out code);

				if (!control || code < 1 || code > recinto.Length)
				{
					Write("Codice non valido. Reimmettere: ");
				}
			}
			while (!control || code < 1 || code > recinto.Length);

			Write("Dimmi il tuo nome e cognome: ");
			nome = ReadLine();

			Dinosauro dino = recinto[code - 1];

			dino.Proprietario = nome;

			return recinto[code - 1] = dino;
		}

		static void CambioProprietà(Dinosauro[] recinto, bool control)
		{
			Write("Dimmi il codice del dinosauro di cui vuoi cambiare il proprietario: ");
			int code;

			do
			{
				control = int.TryParse(ReadLine(), out code);

				if (!control || code < 1 || code > recinto.Length)
				{
					Write("Codice non valido. Reimmettere: ");
				}
			}
			while (!control || code < 1 || code > recinto.Length);

			Write("Dimmi il nuovo proprietario: ");
			string nuovoProprietario = ReadLine();

			Dinosauro dino = recinto[code - 1];
			dino.Proprietario = nuovoProprietario;
			recinto[code - 1] = dino;

			WriteLine($"Il proprietario del dinosauro con codice {code} è stato cambiato in {nuovoProprietario}");
		}
		static void VisualizzaDinosauri(Dinosauro[] recinto)
		{
			WriteLine("Visualizzazione dinosauri nel recinto: ");
			for (int i = 0; i < recinto.Length; i++)
			{
				WriteLine(recinto[i].Stampa());
			}
		}
		static void VisualizzaTipo(Dinosauro[] recinto, bool control)
		{
			int type;

			WriteLine("Visualizzazione dinosauri per tipo: ");
			WriteLine();
			WriteLine("Scegli il tipo di dinosauri da visualizzare: ");
			WriteLine("1. Brontosauro");
			WriteLine("2. Triceratopo");
			WriteLine("3. Pterodattilo");
			WriteLine("4. TRex");
			WriteLine("5. Stegosauro");

			Write("Dimmi il tipo da visualizzare: ");
			do
			{
				control = int.TryParse(ReadLine(), out type);
				if (!control || type < 1 || type > 5)
				{
					Write("Tipo non valido. Reimmettere: ");
				}
			} while (!control || type < 1 || type > 5);

			TipoDinosauro tipoScelto = (TipoDinosauro)(type - 1);

			WriteLine();
			WriteLine($"Dinosauri di tipo {tipoScelto}:");

			bool trovato = false;

			for (int i = 0; i < recinto.Length; i++)
			{
				if (recinto[i].Tipo == tipoScelto)
				{
					WriteLine(recinto[i].Stampa());
					trovato = true;
				}
			}

			if (!trovato)
			{
				WriteLine("Nessun dinosauro trovato di questo tipo.");
			}
		}

		static void VisualizzaTaglia(Dinosauro[] recinto, bool control)
		{
			int type;

			WriteLine("Visualizzazione dinosauri per taglia: ");
			WriteLine();
			WriteLine("Scegli la taglia di dinosauri da visualizzare: ");
			WriteLine("1. Piccolo");
			WriteLine("2. Medio");
			WriteLine("3. Grande");

			Write("Dimmi la taglia da visualizzare: ");
			do
			{
				control = int.TryParse(ReadLine(), out type);
				if (!control || type < 1 || type > 3)
				{
					Write("Taglia non valida. Reimmettere: ");
				}
			} while (!control || type < 1 || type > 3);

			Taglia tagliaScelta = (Taglia)(type - 1);
			WriteLine();
			WriteLine($"Dinosauri di taglia {tagliaScelta}:");

			bool trovato = false;

			for (int i = 0; i < recinto.Length; i++)
			{
				if (recinto[i].taglia == tagliaScelta)
				{
					WriteLine(recinto[i].Stampa());
					trovato = true;
				}
			}

			if (!trovato)
			{
				WriteLine("Nessun dinosauro trovato di questa taglia");
			}
		}
	}
}