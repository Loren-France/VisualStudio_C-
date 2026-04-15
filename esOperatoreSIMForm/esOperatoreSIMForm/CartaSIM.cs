using System;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace esOperatoreSIM
{
	internal class CartaSIM
	{
		private long numeroTelefono;
		private int credito;
		private List<Telefonata> telefonate;

		public CartaSIM(long numeroTelefono, int credito)
		{
			this.numeroTelefono = numeroTelefono;
			this.credito = credito;
			this.telefonate = new List<Telefonata>();
		}

		public string Stampa2()
		{
			return $"Numero di Telefono: {numeroTelefono}    Credito: {credito} euro";
		}

		public void AggiungiTelefonata(Telefonata telefonata)
		{
			telefonate.Add(telefonata);
		}

		public List<Telefonata> RitornaLista()
		{
			return this.telefonate;
		}

		public int MinutiTotali()
		{
			int minutiTotali = 0;
			foreach (Telefonata telefonata in telefonate)
			{
				minutiTotali += telefonata.minuti();
			}
			return minutiTotali;
		}

		public void TotaliTelefonate()
		{
			for (int j = 0; j < telefonate.Count; j++)
			{
				long numero = telefonate[j].NumeroChiamato();
				bool trovato = false;

				for (int k = 0; k < j; k++)
				{
					if (telefonate[k].NumeroChiamato() == numero)
					{
						trovato = true;
						break;
					}
				}

				if (!trovato)
				{
					Console.Write($"Numero: {numero}");
				}

				int count = 0;
				for (int i = 0; i < telefonate.Count; i++)
				{
					if (telefonate[i].NumeroChiamato() == numero)
						count++;
				}

				if (!trovato)
				{
					Console.WriteLine($", Totale Telefonate: {count}");
				}
			}
		}
	}
}
