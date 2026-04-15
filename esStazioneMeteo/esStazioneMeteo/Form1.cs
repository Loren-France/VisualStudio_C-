using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esStazioneMeteo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<StazioneMeteo> stazioni = new List<StazioneMeteo>();
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void txtStazione_KeyPress(object sender, KeyPressEventArgs e)
		{
			char carattere = e.KeyChar;

			if (!char.IsNumber(carattere) && !char.IsControl(carattere) && carattere != '.')
			{
				e.Handled = true;
			}
		}

		private void btnCerca_Click(object sender, EventArgs e)
		{
           int number;
			if (!int.TryParse(txtStazione.Text, out number))
			{
				MessageBox.Show("Inserire un numero di stazione valido.");
				return;
			}

			bool found = false;
			foreach (StazioneMeteo stazione in stazioni)
			{
				if (stazione.Numero == number)
				{
					MessageBox.Show(stazione.Stampa() + "\n" + stazione.Piovuto(stazione.Pioggia));
					found = true;
					break;
				}
			}

			if (!found)
			{
				MessageBox.Show("Stazione non trovata.");
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
            int resettare;
			if (!int.TryParse(txtReset.Text, out resettare))
			{
				MessageBox.Show("Inserire un numero di stazione valido da resettare.");
				return;
			}

			bool found = false;
			foreach (StazioneMeteo station in stazioni)
			{
				if (station.Numero == resettare)
				{
					station.Reset();
					MessageBox.Show("Stazione " + station.Numero + " resettata.");
					found = true;
					break;
				}
			}

			if (!found)
			{
				MessageBox.Show("Stazione da resettare non trovata.");
			}

			AggiornaLista();
			AggiornaCSV();
		}

		public void AggiornaLista()
		{
			lstDatiStazioni.Items.Clear();
			foreach (StazioneMeteo stazione in stazioni)
			{
				lstDatiStazioni.Items.Add(stazione.Stampa());
			}
		}

		private void AggiornaCSV()
		{
            using (var sw = new StreamWriter(@"lista_Stazioni.csv", false))
			{
				for (int i = -1; i < stazioni.Count; i++)
				{
					if (i == -1)
					{
						sw.WriteLine("Numero;Barometro;Termometro;Pluviometro;Igrometro;Anemometro;Presenza di pioggia?");
						continue;
					}
					var temps = stazioni[i].Temperature ?? new double[0];
					sw.WriteLine($"{stazioni[i].Numero};{stazioni[i].Pressione};{string.Join(",", temps)};{stazioni[i].Pioggia};{stazioni[i].Umidità};{stazioni[i].Velocità};{stazioni[i].Piovuto(stazioni[i].Pioggia)}");
				}
			}
			MessageBox.Show("CSV aggiornato con successo!");
		}

		private void btnAggiungi_Click(object sender, EventArgs e)
		{
            int identificativo;
			double barometro;
			double term1, term2, term3, term4;
			double pluviometro;
			int igrometro;
			double anemometro;

			if (!int.TryParse(txtNum.Text, out identificativo) ||
				!double.TryParse(txtBar.Text, out barometro) ||
				!double.TryParse(txtTerm1.Text, out term1) ||
				!double.TryParse(txtTerm2.Text, out term2) ||
				!double.TryParse(txtTerm3.Text, out term3) ||
				!double.TryParse(txtTerm4.Text, out term4) ||
				!double.TryParse(txtPluv.Text, out pluviometro) ||
				!int.TryParse(txtIgro.Text, out igrometro) ||
				!double.TryParse(txtAnem.Text, out anemometro))
			{
				MessageBox.Show("Controlla tutti i campi: inserire valori numerici validi.");
				return;
			}

			double[] termometro = { term1, term2, term3, term4 };


			StazioneMeteo nuovaStazione = new StazioneMeteo(identificativo, barometro, pluviometro, igrometro, anemometro);
			nuovaStazione.AggiungiTemperatura(termometro);
			stazioni.Add(nuovaStazione);
			AggiornaLista();
			AggiornaCSV();
		}
	}
}
