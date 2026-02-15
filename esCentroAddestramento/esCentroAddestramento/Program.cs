using System;
using static System.Console;

namespace esCentroAddestramento
{
	enum TipoMostro
	{
		Fuoco,
		Acqua,
		Erba,
		Elettrico,
		Roccia
	}
	enum LivelloEnergia
	{
		Basso,
		Medio,
		Alto
	}

	struct MostroDigitale
	{
		public int codice;
		public TipoMostro tipo;
		public LivelloEnergia energia;
		public int età;
		public int forza;
		public string allenatore;
		public MostroDigitale(int codice, TipoMostro tipo, LivelloEnergia energia, int età, int forza, string allenatore)
		{
			this.codice = codice;
			this.tipo = tipo;
			this.energia = energia;
			this.età = età;
			this.forza = forza;
			this.allenatore = allenatore;
		}

		public bool ÈAllenabile()
		{
			if (energia == LivelloEnergia.Basso)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool ÈStanco()
		{
			if (energia == LivelloEnergia.Basso)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void CambiaAllenatore(string nuovoAllenatore)
		{
			this.allenatore = nuovoAllenatore;
		}

		public void Allenati(int punti)
		{
			forza += punti;
			if (forza > 100)
			{
				forza = 100;
			}
		}

		public string Descrizione()
		{
			return $"Codice Mostro: {codice}, Tipo: {tipo}, Energia: {energia}, Età: {età}, Forza: {forza}, Allenatore: {allenatore}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int action;

			int cod = 1;

			bool cicle = true;

			bool control = true;

			const int dim = 67;

			MostroDigitale[] mostri = new MostroDigitale[dim];

			WriteLine("Benvenuto al cento di addestramento per mostri digitali");
			WriteLine("\n");


			while (cicle)
			{

				WriteLine("Scegli un'opzione:");
				WriteLine("1. Crea un nuovo mostro");
				WriteLine("2. Allena un mostro");
				WriteLine("3. Cambia allenatore ad un mostro");
				WriteLine("4. Scambia allenatore tra due mostri");
				WriteLine("5. Visualizza i mostri");
				WriteLine("6. Filtra per tipo di mostro");
				WriteLine("7. Filtra per livello di energia");
				WriteLine("8. Filtra per mostri stanchi");
				WriteLine("9. Esci");
				WriteLine("\n");
				Write("Inserisci il numero dell'azione da eseguire: ");

				do
				{
					control = int.TryParse(ReadLine(), out action);
					if (!control)
					{
						WriteLine("Input non valido. Inserisci un numero.");
					}
				}
				while (!control || action < 1 || action > 8);

				switch (action)
				{
					case 1:
						mostri[cod - 1] = CreaMostro(mostri, control, cod);
						cod++;
						break;
					case 2:
						AllenaMostro(mostri, control);
						break;
					case 3:
						CambioAllenatore(mostri, control);
						break;
					case 4:
						ScambioAllenatore(mostri, control);
						break;
					case 5:
						Visualizza(mostri);
						break;
					case 6:
						FiltraperTipo(mostri, control);
						break;
					case 7:
						FiltraperEnergia(mostri, control);
						break;
					case 8:
						FiltraperStanchi(mostri);
						break;
					case 9:
						WriteLine("Arrivederci!");
						cicle = false;
						break;
					default:
						WriteLine("Opzione non valida");
						break;
				}
			}
		}
		static MostroDigitale CreaMostro(MostroDigitale[] mostri, bool control, int cod)
		{
			int type;
			int energy;
			int age;
			int strenght;
			string trainer;

			MostroDigitale monster = new MostroDigitale();

			monster.codice = cod;

			WriteLine("Inserisci il tipo di mostro (1, 2, 3, 4, 5): ");

			do
			{
				control = int.TryParse(ReadLine(), out type);
				if (!control || type < 1 || type > 5)
				{
					WriteLine("Input non valido. REinserisci un numero tra 1 e 5: ");
				}
			} while (!control || type < 1 || type > 5);

			type -= 1;

			monster.tipo = (TipoMostro)type;

			WriteLine("Inserisci il livello di energia (1, 2, 3): ");

			do
			{
				control = int.TryParse(ReadLine(), out energy);
				if (!control || energy < 1 || energy > 3)
				{
					WriteLine("Input non valido. Reinserisci un numero tra 1 e 3: ");
				}
			} while (!control || energy < 1 || energy > 3);

			energy -= 1;

			monster.energia = (LivelloEnergia)energy;

			WriteLine("Inserisci l'età del mostro: ");

			do
			{
				control = int.TryParse(ReadLine(), out age);
				if (!control || age < 0)
				{
					WriteLine("Input non valido. Reinserire: ");
				}
			} while (!control || age < 0);

			monster.età = age;

			WriteLine("Inserisci la forza del mostro: ");

			do
			{
				control = int.TryParse(ReadLine(), out strenght);
				if (!control || strenght < 0 || strenght > 100)
				{
					WriteLine("Input non valido. Reinserire: ");
				}
			} while (!control || strenght < 0 || strenght > 100);

			monster.forza = strenght;

			WriteLine("Inserisci il nome dell'allenatore: ");

			do
			{
				trainer = ReadLine();
				if (string.IsNullOrWhiteSpace(trainer))
				{
					WriteLine("Input non valido. Reinserire: ");
				}
			} while (string.IsNullOrWhiteSpace(trainer));

			monster.allenatore = trainer;

			return monster;
		}
		static void AllenaMostro(MostroDigitale[] mostri, bool control)
		{
			int cod;
			int allenamento;
			WriteLine("Inserisci il codice del mostro da allenare: ");

			do
			{
				control = int.TryParse(ReadLine(), out cod);
				if (!control || cod < 1 || cod > mostri.Length)
				{
					WriteLine("Spiacente, non è stato inserito un codice valudo, reinserire: ");
				}
			} while (!control || cod < 1 || cod > mostri.Length);

			WriteLine("Inserisci di quanti punti forza vuoi far aumentare il mostro: ");

			do
			{
				control = int.TryParse(ReadLine(), out allenamento);
				if (!control || allenamento < 0)
				{
					WriteLine("Spiacente, il valore di forza da allenare non è valido, reinserire: ");
				}
			}
			while (!control || allenamento < 0);

			mostri[cod - 1].Allenati(allenamento);

			WriteLine("Mostro allenato con successo!");
		}
		static void CambioAllenatore(MostroDigitale[] mostri, bool control)
		{
			string nuovoAllenatore;
			int cod;

			WriteLine("Inserisci il codice del mostro a cui vuoi cambiare allenatore: ");

			do
			{
				control = int.TryParse(ReadLine(), out cod);
				if (!control || cod < 1 || cod > mostri.Length)
				{
					WriteLine("Spiacente, non è stato inserito un codice valudo, reinserire: ");
				}
			} while (!control || cod < 1 || cod > mostri.Length);

			WriteLine("Inserisci il nome dell'allenatore: ");

			do
			{
				nuovoAllenatore = ReadLine();
				if (string.IsNullOrWhiteSpace(nuovoAllenatore))
				{
					WriteLine("Spiacente, nome non valido, reinserire: ");
				}
			} while (string.IsNullOrWhiteSpace(nuovoAllenatore));

			mostri[cod - 1].CambiaAllenatore(nuovoAllenatore);

		}
		static void ScambioAllenatore(MostroDigitale[] mostri, bool control)
		{
			int cod1;
			int cod2;
			string temp1;
			string temp2;

			WriteLine("Inserisci il codice del primo mostro: ");

			do
			{
				control = int.TryParse(ReadLine(), out cod1);
				if (!control || cod1 < 1 || cod1 > mostri.Length)
				{
					WriteLine("Spiacente, non è stato inserito un codice valido, reinserire: ");
				}
			} while (!control || cod1 < 1 || cod1 > mostri.Length);

			WriteLine("Inserisci il codice del secondo mostro: ");

			do
			{
				control = int.TryParse(ReadLine(), out cod2);
				if (!control || cod2 < 1 || cod2 > mostri.Length)
				{
					WriteLine("Spiacente, non è stato inserito un codice valido, reinserire: ");
				}
			} while (!control || cod2 < 1 || cod2 > mostri.Length);

			temp1 = mostri[cod1 - 1].allenatore;
			temp2 = mostri[cod2 - 1].allenatore;
			mostri[cod1 - 1].CambiaAllenatore(temp2);
			mostri[cod2 - 1].CambiaAllenatore(temp1);

			WriteLine("Scambio allenatori avvenuto con successo!");
		}
		static void Visualizza(MostroDigitale[] mostri)
		{
			WriteLine("Visualizzazione dei mostri digitali: ");
			WriteLine();
			for (int i = 0; i < mostri.Length; i++)
			{
				if (mostri[i].codice != 0)
				{
					WriteLine(mostri[i].Descrizione());
				}
			}
			WriteLine();
		}
		static void FiltraperTipo(MostroDigitale[] mostri, bool control)
		{
			int tipo;
			TipoMostro verotipo;
			WriteLine("Visualizzazione dei mostri digitali per tipo: ");
			WriteLine();

			WriteLine("Inserire il tipo che si vuole visualizzare: ");
			WriteLine("1. Fuoco");
			WriteLine("2. Acqua");
			WriteLine("3. Erba");
			WriteLine("4. Elettro");
			WriteLine("5. Terra");
			WriteLine();

			do
			{
				control = int.TryParse(ReadLine(), out tipo);
				if (!control || tipo < 1 || tipo > 5)
				{
					WriteLine("Spiacente, non è stato inserito un tipo valudo, reinserire: ");
				}
			} while (!control || tipo < 1 || tipo > 5);

			verotipo = (TipoMostro)(tipo - 1);

			for (int i = 0; i < mostri.Length; i++)
			{
				if (mostri[i].codice != 0 && mostri[i].tipo == verotipo)
				{
					WriteLine(mostri[i].Descrizione());
				}
			}
			WriteLine();
		}
		static void FiltraperEnergia(MostroDigitale[] mostri, bool control)
		{
			int energia;
			LivelloEnergia veraenergia;
			WriteLine("Visualizzazione dei mostri digitali per energia: ");
			WriteLine();

			WriteLine("Inserire l'energia che si vuole visualizzare: ");
			WriteLine("1. Basso");
			WriteLine("2. Medio");
			WriteLine("3. Alto");
			WriteLine();

			do
			{
				control = int.TryParse(ReadLine(), out energia);
				if (!control || energia < 1 || energia > 5)
				{
					WriteLine("Spiacente, non è stato inserito un tipo valido, reinserire: ");
				}
			} while (!control || energia < 1 || energia > 5);

			veraenergia = (LivelloEnergia)(energia - 1);

			for (int i = 0; i < mostri.Length; i++)
			{
				if (mostri[i].codice != 0 && mostri[i].energia == veraenergia)
				{
					WriteLine(mostri[i].Descrizione());
				}
			}
			WriteLine();
		}
		static void FiltraperStanchi(MostroDigitale[] mostri)
		{
			WriteLine("Visualizzazione dei mostri digitali stanchi: ");
			WriteLine();
			for (int i = 0; i < mostri.Length; i++)
			{
				if (mostri[i].codice != 0 && mostri[i].ÈStanco())
				{
					WriteLine(mostri[i].Descrizione());
				}
			}
			WriteLine();
		}
	}
}