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

		public string AggiungiIntervento(CIntervento intervento)
		{
			try
			{
				if (intervento.Costo < 0)
				{
					throw new ArgumentException("Il costo dell'intervento non può essere negativo");
				}
				interventi.Add(intervento);
				return ""; 
			}
			catch (Exception ex)
			{
				return ("Errore durante l'aggiunta dell'intervento: " + ex.Message);
			}
		}

		public string RimuoviIntervento(int codiceIntervento)
		{
			for (int i = 0; i < interventi.Count; i++)
			{
				if (interventi[i].Codice == codiceIntervento)
				{
					interventi.RemoveAt(i);
					return ("\nIntervento rimosso con successo\n");
				}
			}
			return "\nIntervento non trovato";
		}

		public string RicercaIntervento(int codiceIntervento)
		{
  			for (int i = 0; i < interventi.Count; i++)
			{
   				if (interventi[i].Codice == codiceIntervento)
				{
					return ("\nIntervento ricercato: " + interventi[i].ToStringIntervento());
				}
			}
			return ("\nIntervento non trovato");
		}

		public string StampaRegistro(CIntervento i)
		{
			return (i.ToStringIntervento());
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

		public string InterventiCritici(CIntervento i)
		{
			if (i.Categoria == (Categoria)0)
			{
				return (i.ToStringIntervento() + " INTERVENTO CRITICO !!!\n");
			}
			return "";
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
