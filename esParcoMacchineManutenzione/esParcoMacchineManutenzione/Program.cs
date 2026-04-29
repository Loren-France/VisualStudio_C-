using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Security;
using esParcoMacchineManutenzione;
using static System.Console;

namespace esParcoMacchineManutenzione
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CRegistroManutenzioni registro = new CRegistroManutenzioni(new DateTime(2025, 4, 16), new DateTime(2025, 12, 20), "Sharra Colonna");
			CIntervento intervento1 = new CIntervento(1, Categoria.Controllo, 100.0, DateTime.Now);
			CIntervento intervento2 = new CIntervento(2, Categoria.Riparazione, 200.0, DateTime.Now);
			CIntervento intervento3 = new CIntervento(3, Categoria.Sostituzione, 300.0, DateTime.Now);
			CIntervento intervento4 = new CIntervento(4, Categoria.Sostituzione, 700.0, DateTime.Now);
			CIntervento intervento5 = new CIntervento(5, Categoria.Sostituzione, -100.0, DateTime.Now);
			CIntervento intervento6 = new CIntervento(6, Categoria.Controllo, 800.0, DateTime.Now);
			registro.AggiungiIntervento(intervento1);
			registro.AggiungiIntervento(intervento2);
			registro.AggiungiIntervento(intervento3);
			registro.AggiungiIntervento(intervento4);
			registro.AggiungiIntervento(intervento5);
			registro.AggiungiIntervento(intervento6);
			registro.StampaRegistro();
			registro.RicercaIntervento(2);
			registro.RimuoviIntervento(1);
			registro.StampaRegistro();
			registro.RicercaIntervento(1);
			registro.RicercaIntervento(6);
			GeneraReportAvanzato(registro);
		}

		static void GeneraReportAvanzato(CRegistroManutenzioni registro)
		{
			WriteLine("\n------------------REPORT AVANZATO-------------------");

			List<CIntervento> critic = new List<CIntervento>();
			int[] contatori = new int[3] { 0, 0, 0 };
			double[] medie = new double[3] { 0, 0, 0 };
			double[] max = new double[3] { 0, 0, 0 };
			double[] min = new double[3] { 0, 0, 0 };
			int totaleInterventi = 0;
			double totaleCosti = 0;

			for (int i = 0; i < contatori.Length; i++)
			{
				contatori[i] = registro.ContaInterventiPerCategoria((Categoria)i);
			}

			for (int i = 0; i < registro.Interventi.Count(); i++)
			{
				CIntervento singolo = registro.Interventi[i];
				if (singolo.Categoria == (Categoria)0)
				{
					medie[0] += singolo.Costo;
					if (singolo.Costo > max[0])
					{
						max[0] = singolo.Costo;
					}
					if (singolo.Costo < min[0] || min[0] == 0)
					{
						min[0] = singolo.Costo;
					}
					critic.Add(singolo);
				}
				else if (singolo.Categoria == (Categoria)1)
				{
					medie[1] += singolo.Costo;
					if (singolo.Costo > max[1])
					{
						max[1] = singolo.Costo;
					}
					if (singolo.Costo < min[1] || min[1] == 0)
					{
						min[1] = singolo.Costo;
					}
				}
				else if (singolo.Categoria == (Categoria)2)
				{
					medie[2] += singolo.Costo;
					if (singolo.Costo > max[2])
					{
						max[2] = singolo.Costo;
					}
					if (singolo.Costo < min[2] || min[2] == 0)
					{
						min[2] = singolo.Costo;
					}
				}
			}

			foreach (int j in contatori)
			{
				medie[j] /= j;
			}

			foreach (int k in contatori)
			{
				totaleInterventi += k;
			}

			totaleCosti = registro.CalcolaTotaleCosti();

			 WriteLine($"Totale interventi: {totaleInterventi}");
			 WriteLine($"Totale costi: {totaleCosti}\n");
			 WriteLine($"Media costi per categoria => Controllo: {medie[0]}, Riparazione: {medie[1]}, Sostituzione: {medie[2]}");
			 WriteLine($"Costo massimo per categoria => Controllo: {max[0]}, Riparazione: {max[1]}, Sostituzione: {max[2]}");
			 WriteLine($"Costo minimo per categoria => Controllo: {min[0]}, Riparazione: {min[1]}, Sostituzione: {min[2]}\n");
			 WriteLine("Interventi critici:");
			 registro.InterventiCritici();
		}
	}
}