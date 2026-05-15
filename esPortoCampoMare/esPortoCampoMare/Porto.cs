using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace esPortoCampoMare
{
	internal class Porto
	{

		private Dictionary<int, Barca> identificativo = new Dictionary<int, Barca>();
		private string nome;

		public Porto(string nome)
		{
			this.nome = nome;
		}

		public void RegistraBarche(int numeroDiBarche)
		{
			Random rand = new Random();
			int ID = 1;

			for (int i = 0; i < numeroDiBarche; i++)
			{
				int carico = rand.Next(1, 11);
				Barca b = new Barca($"Barca {i + 1}", $"Capitano {i + 1}", carico, carico, (Tipologia)rand.Next(0, 3));
				identificativo.Add(ID, b);
				ID++;
			}
		}

		public string GestisciPartenze(int numero)
		{
			string messaggio = "";
			List<int> daRimuovere = new List<int>();

			foreach (var kvp in identificativo)
			{
				if (kvp.Value.Carico == numero)
				{
					messaggio += $"Barca ID {kvp.Key} nome \"{kvp.Value.Nome}\" con carico {kvp.Value.Carico} è partita!\n";
					daRimuovere.Add(kvp.Key);
				}
			}

			foreach (int id in daRimuovere)
			{
				identificativo.Remove(id);
			}

			int partenze = daRimuovere.Count;
			if (partenze > 5)
			{
				messaggio += "Il porto si sta svuotando rapidamente! Più di 5 barche sono partite in un solo turno!\n";
			}

			return messaggio;
		}


		public Dictionary<int, Barca> dizionario
		{
			get { return identificativo; }
			set { identificativo = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
	}
}
