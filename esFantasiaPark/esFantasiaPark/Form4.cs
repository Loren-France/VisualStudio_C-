using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esFantasiaPark
{
	public struct Attrazione
	{
		public string nome;
		public int capienzaMAX;
		public int personeAttuali;

		public Attrazione(string nome, int capienzaMAX, int personeAttuali)
		{
			this.nome = nome;
			this.capienzaMAX = capienzaMAX;
			this.personeAttuali = personeAttuali;
		}

		public string Stampa()
		{
			return $"Attrazione: {nome}, Capienza massima: {capienzaMAX}, Persone attualmente all'interno: {personeAttuali}";
		}
	}
	public partial class Form_GestioneAttrazioni : Form
	{
		public Attrazione[] raccolta = new Attrazione [3];
		public string fullPath = @"lista_GestioneAttrazioni.csv";

		public Form_GestioneAttrazioni()
		{
			InitializeComponent();
		}

		private void txtPersone_KeyPress(object sender, KeyPressEventArgs e)
		{
			char carattere = e.KeyChar;

			if (!char.IsNumber(carattere) && !char.IsControl(carattere))
			{
				e.Handled = true;
			}
		}

		private void Form_GestioneAttrazioni_Load(object sender, EventArgs e)
		{
			if (!File.Exists(fullPath))
			{
				File.Create(fullPath).Close();
				MessageBox.Show("CSV non trovato, ne è stato creato uno nuovo.");
			}

			string[] righe = File.ReadAllLines(fullPath);
			if (righe.Length > 0)
			{
				char div = ';';
				for (int i = 0; i < righe.Length; i++)
				{
					string[] dati = righe[i].Split(div);
					raccolta[i].nome = dati[0];
					raccolta[i].capienzaMAX = int.Parse(dati[1]);
					raccolta[i].personeAttuali = int.Parse(dati[2]);
				}
				MessageBox.Show($"Dati letti con successo dal CSV: {fullPath}");
			}
			else
			{
				MessageBox.Show("Alcuni dati non sono stati trovati nel CSV, inizializzo attrazioni con valori prestabiliti, quindi non letti");
				raccolta[0] = new Attrazione("Stanza degli specchi", 10, 0);
				raccolta[1] = new Attrazione("Casa delle illusioni", 12, 0);
				raccolta[2] = new Attrazione("Tunnel delle stelle", 15, 0);
			}

			lblAttrazione1.Text = raccolta[0].nome;
			lblAttrazione2.Text = raccolta[1].nome;
			lblAttrazione3.Text = raccolta[2].nome;
			lblCapienza1.Text = $"Capienza MAX: {raccolta[0].capienzaMAX}";
			lblCapienza2.Text = $"Capienza MAX: {raccolta[1].capienzaMAX}";
			lblCapienza3.Text = $"Capienza MAX: {raccolta[2].capienzaMAX}";
			AggiornamentoElementi();
		}

		private void btnAzione1_Click(object sender, EventArgs e)
		{
			int person;

			if (!int.TryParse(txtPersone1.Text, out person) || person <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtPersone1.Clear();

			if (rdbEntrata1.Checked)
			{
				EntrataPersone(ref raccolta[0], person);
			}
			else if (rdbUscita1.Checked)
			{
				UscitaPersone(ref raccolta[0], person);
			}
			else
			{
				MessageBox.Show($"Selezionare un azione da compiere nell'attrazione {raccolta[0].nome}");
			}

			AggiornamentoElementi();
			AggiornaCSV();
		}
		
		private void btnAzione2_Click(object sender, EventArgs e)
		{
			int person;

			if (!int.TryParse(txtPersone2.Text, out person) || person <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtPersone2.Clear();

			if (rdbEntrata2.Checked)
			{
				EntrataPersone(ref raccolta[1], person);
			}
			else if (rdbUscita2.Checked)
			{
				UscitaPersone(ref raccolta[1], person);
			}
			else
			{
				MessageBox.Show($"Selezionare un azione da compiere nell'attrazione {raccolta[1].nome}");
			}

			AggiornamentoElementi();
			AggiornaCSV();
		}
		
		private void btnAzione3_Click(object sender, EventArgs e)
		{
			int person;

			if (!int.TryParse(txtPersone3.Text, out person) || person <= 0)
			{
				MessageBox.Show("Inserire un numero valido!");
				return;
			}

			txtPersone3.Clear();

			if (rdbEntrata3.Checked)
			{
				EntrataPersone(ref raccolta[2], person);
			}
			else if (rdbUscita3.Checked)
			{
				UscitaPersone(ref raccolta[2], person);
			}
			else
			{
				MessageBox.Show($"Selezionare un azione da compiere nell'attrazione {raccolta[2].nome}");
			}

			AggiornamentoElementi();
			AggiornaCSV();
		}

		private void EntrataPersone (ref Attrazione attrazione, int add)
		{
			if (attrazione.personeAttuali + add > attrazione.capienzaMAX)
			{
				MessageBox.Show($"Spiacenti, il numero di persone da aggiungere con quelle attualmente dentro all'attrazione supera il massimo di {attrazione.capienzaMAX} persone, annullamento dell'entrata");
				return;
			}
			else
			{
				attrazione.personeAttuali += add;
				MessageBox.Show($"Sono state fatte entrare {add} persone dall'attrazione {attrazione.nome}");
			}
		}

		private void UscitaPersone(ref Attrazione attrazione, int add)
		{
			if (attrazione.personeAttuali - add < 0)
			{
				MessageBox.Show($"Numero di persone in uscita maggiore di quelle attualmente presenti, faccio uscire tutte le persone dall'attrazione");
				attrazione.personeAttuali = 0;
				return;
			}
			else
			{
				attrazione.personeAttuali -= add;
				MessageBox.Show($"Sono uscite {add} persone dall'attrazione {attrazione.nome}");
			}
		}

		private void AggiornamentoElementi()
		{
			lblAttuali1.Text = $"Persone attualmente dentro: {raccolta[0].personeAttuali}";
			lblAttuali2.Text = $"Persone attualmente dentro: {raccolta[1].personeAttuali}";
			lblAttuali3.Text = $"Persone attualmente dentro: {raccolta[2].personeAttuali}";
		}

		private void AggiornaCSV()
		{
			
			using (var sw = new StreamWriter(fullPath, false))
			{
				foreach (Attrazione i in raccolta)
				{
					sw.WriteLine($"{i.nome};{i.capienzaMAX};{i.personeAttuali}");
				}
			}

			MessageBox.Show("CSV aggiornato con successo!");
		}
	}
}
