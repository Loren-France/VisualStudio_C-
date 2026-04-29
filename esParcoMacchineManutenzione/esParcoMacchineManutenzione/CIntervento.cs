using System;
using System.Collections.Generic;
using System.Text;

namespace esParcoMacchineManutenzione
{
	public enum Categoria
	{
		Controllo, Riparazione, Sostituzione
	}
	internal class CIntervento
	{
		private int codiceintervento;
		private Categoria categoriaIntervento;
		private double costoIntervento;
		private DateTime dataIntervento;

		public CIntervento()
		{
			this.codiceintervento = 0;
			this.categoriaIntervento = (Categoria)0;
			this.costoIntervento = 0.0;
			this.dataIntervento = DateTime.Now;
		}

		public CIntervento(int codiceintervento, Categoria categoriaIntervento, double costoIntervento, DateTime dataIntervento)
		{
			this.codiceintervento = codiceintervento;
			this.categoriaIntervento = categoriaIntervento;
			this.costoIntervento = costoIntervento;
			this.dataIntervento = dataIntervento;
		}

		public string ToStringIntervento()
		{
  			return $"Codice Intervento: {codiceintervento}, Categoria: {categoriaIntervento}, Costo: {costoIntervento}, Data: {dataIntervento}";
		}

		public double Costo
		{
			get 
			{
				return costoIntervento;
			}
		}
		public int Codice
		{
			get
			{
   				return codiceintervento;
			}
		}

		public Categoria Categoria
		{
			get
			{
				return categoriaIntervento;
			}
		}
	}
}
