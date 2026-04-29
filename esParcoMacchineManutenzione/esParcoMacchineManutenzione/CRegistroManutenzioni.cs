using System;
using System.Collections.Generic;
using System.Text;

namespace esParcoMacchineManutenzione
{
	internal class CRegistroManutenzioni
	{
		private List<CIntervento> interventi;
		private DateTime dataInizioRegistro;
		private DateTime dataFineRegistro;
		private string tecnicoResponsabile;

		public CRegistroManutenzioni()
		{
			interventi = new List<CIntervento>();
			dataInizioRegistro = DateTime.Now;
			dataFineRegistro = DateTime.Now;
			tecnicoResponsabile = "N/D";
		}

		public CRegistroManutenzioni(DateTime dataInizioRegistro, DateTime dataFineRegistro, string tecnicoResponsabile)
		{
			this.interventi = new List<CIntervento>();
			this.dataInizioRegistro = dataInizioRegistro;
			this.dataFineRegistro = dataFineRegistro;
			this.tecnicoResponsabile = tecnicoResponsabile;
		}

		public void AggiungiIntervento(CIntervento intervento)
		{
			try
			{
				if (intervento.Costo < 0)
				{
					throw new ArgumentException("Il costo dell'intervento non può essere negativo");
				}
				interventi.Add(intervento);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Errore durante l'aggiunta dell'intervento: " + ex.Message);
				return;
			}
		}

		public void RimuoviIntervento(int codiceIntervento)
		{
			for (int i = 0; i < interventi.Count; i++)
			{
				if (interventi[i].Codice == codiceIntervento)
				{
					interventi.RemoveAt(i);
					Console.WriteLine("\nIntervento rimosso con successo");
					return;
				}
			}
		}

		public void RicercaIntervento(int codiceIntervento)
		{
			Console.WriteLine("\nIntervento ricercato: ");
  			for (int i = 0; i < interventi.Count; i++)
			{
   				if (interventi[i].Codice == codiceIntervento)
				{
					Console.WriteLine(interventi[i].ToStringIntervento());
					return;
				}
			}
			Console.WriteLine("Intervento non trovato");
			return;
		}

		public void StampaRegistro()
		{
			Console.WriteLine();
			foreach (CIntervento i in interventi)
			{
				Console.WriteLine(i.ToStringIntervento());
			}
			Console.WriteLine();
		}

		public double CalcolaTotaleCosti()
		{
			double tot = 0.0;
			for (int j = 0; j < interventi.Count; j++)
			{
				tot += interventi[j].Costo;
			}
			return tot;
		}

		public int ContaInterventiPerCategoria(Categoria category)
		{
			int counter = 0;
			for (int i = 0; i < interventi.Count; i++)
			{
				if (interventi[i].Categoria == category)
				{
					counter++;
				}
			}
			return counter;
		}

		public void InterventiCritici()
		{
			Console.WriteLine();
			for (int i = 0; i < interventi.Count; i++)
			{
				if (interventi[i].Categoria == (Categoria)0)
				{
					Console.WriteLine(interventi[i].ToStringIntervento() + " INTERVENTO CRITICO !!!");
				}
			}
			Console.WriteLine();
			return;
		}

		public List<CIntervento> Interventi
		{
			get
			{
				return interventi;
			}
		}
	}
}
