using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace esOperatoreSIM
{
	internal class Telefonata
	{
		private int durata;
		private long numeroChiamato;

		public Telefonata(int durata, long numeroChiamato)
		{
			this.durata = durata;
			this.numeroChiamato = numeroChiamato;
		}

		public string stampa1()
		{
			return $"Durata: {durata} minuti, Numero Chiamato: {numeroChiamato}";
		}

		public int minuti()
		{
			return durata;
		}

		public long NumeroChiamato()
		{
			return numeroChiamato;
		}
	}
}
