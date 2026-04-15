using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esStazioneMeteo
{
	internal class StazioneMeteo
	{
		private int numero;
		private double pressione, pioggia, velocità;
		private double[] temperatura;
		private int umidità;

		public StazioneMeteo(int numero, double pressione, double pioggia, int umidità, double velocità)
		{
			this.numero = numero;
			this.pressione = pressione;
			this.pioggia = pioggia;
			this.velocità = velocità;
			this.temperatura = new double[4];
			this.umidità = umidità;
		}

		public string Stampa()
		{
			return $"Numero stazione: {numero}, Barometro: {pressione}, Termometro: {string.Join(", ", temperatura)}, Pluviometro: {pioggia}, Igrometro: {umidità}, Anemometro: {velocità}";
		}

		public int Numero
		{
			get { return numero; }
		}

		public double Pressione
		{
			get { return pressione; }
		}

		public double Pioggia
		{
			get { return pioggia; }
		}

		public double Velocità
		{
			get { return velocità; }
		}

		public int Umidità
		{
  			get { return umidità; }
		}

		public double[] Temperature
		{
			get { return temperatura; }
		}

		public void AggiungiTemperatura(double[] temp)
		{
			for (int i = 0; i < temp.Length; i++)
			{
				temperatura[i] = temp[i];
			}
		}

		public string Piovuto(double pioggia)
		{
			if (pioggia != 0)
			{
				return "Sì, oggi c'è stata la pioggia in questa stazione";
			}
			else
			{
				return "No, oggi non ha piovuto in questa stazione";
			}
		}

		public void Reset()
		{
  			pressione = 0;
			pioggia = 0;
			velocità = 0;
			umidità = 0;
			for (int i = 0; i < temperatura.Length; i++)
			{
				temperatura[i] = 0;
			}
		}
	}
}
