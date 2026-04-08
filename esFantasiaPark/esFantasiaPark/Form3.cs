using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esFantasiaPark
{
	public partial class Form_GestioneGiostre : Form
	{
		public struct Giostra
		{
			public string nome;
			public int capienza;
			public int coda;
			public Giostra(string nome, int capienza, int coda)
			{
				this.nome = nome;
				this.capienza = capienza;
				this.coda = coda;
			}
			public string Stampa()
			{
				return $"{nome};{capienza};{coda}";
			}
		}

		public Giostra g1 = new Giostra("Montagne Ruggenti", 8, 0);
		public Giostra g2 = new Giostra("Ruota Panoramica", 16, 0);
		public Giostra g3 = new Giostra("Tagadà", 7, 0);

		public Form_GestioneGiostre()
		{
			InitializeComponent();
		}

		private void txtAggiungere_KeyPress(object sender, KeyPressEventArgs e)
		{
			char carattere = e.KeyChar;

			if (!char.IsNumber(carattere) && !char.IsControl(carattere))
			{
				e.Handled = true;
			}
		}

		private void Form_GestioneGiostre_Load(object sender, EventArgs e)
		{
			lblGiostra1.Text = g1.nome;
			lblGiostra2.Text = g2.nome;
			lblGiostra3.Text = g3.nome;
			lblCapienza1.Text = $"Capienza MAX: {g1.capienza}";
			lblCapienza2.Text = $"Capienza MAX: {g2.capienza}";
			lblCapienza3.Text = $"Capienza MAX: {g3.capienza}";
			AggiornamentoElementi();
			AggiornaCSV();
		}

		private void btnAggiunta1_Click(object sender, EventArgs e)
		{
			int aggiunta;

			if (!int.TryParse(txtAggiungere1.Text, out aggiunta) || aggiunta <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtAggiungere1.Clear();
			FunzioneAggiunta(ref g1, aggiunta);
			AggiornamentoElementi();
			AggiornaCSV();
		}

		private void btnPartire1_Click(object sender, EventArgs e)
		{
			FunzionePartenza(ref g1);
			AggiornaCSV();
		}

		private void btnAggiunta2_Click(object sender, EventArgs e)
		{
			int aggiunta;

			if (!int.TryParse(txtAggiungere2.Text, out aggiunta) || aggiunta <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtAggiungere2.Clear();
			FunzioneAggiunta(ref g2, aggiunta);
			AggiornamentoElementi();
			AggiornaCSV();
		}

		private void btnPartire2_Click(object sender, EventArgs e)
		{
			FunzionePartenza(ref g2);
			AggiornaCSV();
		}

		private void btnAggiunta3_Click(object sender, EventArgs e)
		{
			int aggiunta;

			if (!int.TryParse(txtAggiungere3.Text, out aggiunta) || aggiunta <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtAggiungere3.Clear();
			FunzioneAggiunta(ref g3, aggiunta);
			AggiornamentoElementi();
			AggiornaCSV();
		}

		private void btnPartire3_Click(object sender, EventArgs e)
		{
			FunzionePartenza(ref g3);
			AggiornaCSV();
		}

		private void FunzioneAggiunta(ref Giostra g, int add)
		{
			g.coda += add;
			MessageBox.Show($"Aggiunti {add} alla coda di {g.nome}");
		}

		private void FunzionePartenza(ref Giostra g)
		{
			g.coda = (g.coda - g.capienza < 0) ? 0
				: g.coda - g.capienza;

			MessageBox.Show($"Partiti {g.capienza} dalla coda di {g.nome}");
			AggiornamentoElementi();
		}
		//Utilizzo di ref nelle funzioni per riferirmi direttamente alle struct giostre che ho creato, se non lo utilizzassi, verrebbero create delle "copie" della struct riferita
		//quindi non otterrei i valori di ritorno aggiornati, ma quelli originali, che non cambiano mai
		private void AggiornamentoElementi()
		{
			lblCoda1.Text = $"Coda: {g1.coda}";
			lblCoda2.Text = $"Coda: {g2.coda}";
			lblCoda3.Text = $"Coda: {g3.coda}";
		}

		private void AggiornaCSV()
		{
			using (var sw = new StreamWriter(@"lista_GestioneGiostre.csv", false))
			{
				sw.WriteLine(g1.Stampa());
				sw.WriteLine(g2.Stampa());
				sw.WriteLine(g3.Stampa());
			}

			MessageBox.Show("CSV aggiornato con successo!");
		}
	}
}
