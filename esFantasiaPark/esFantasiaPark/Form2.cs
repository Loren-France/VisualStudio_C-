using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace esFantasiaPark
{
	public enum Tipologia
	{
		Intero,
		Ridotto,
		VIP
	}
	public struct Biglietto
	{
		public int numero;
		public string nome;
		public Tipologia tipo;
		public DateTime data;

		public Biglietto(int numero, string nome, Tipologia tipo, DateTime data)
		{
			this.numero = numero;
			this.nome = nome;
			this.tipo = tipo;
			this.data = data;
		}

		public string Stampa()
		{
			// D4 indica il numero di cifre con cui viene scritto il numero, quindi se il numero di cifre è < 4 aggiunge zeri davanti ad esso fino al raggiungimento delle 4 cifre
			return $"Biglietto Numero: {numero:D4}, Nome: {nome}, Tipo: {tipo}, Data: {data}";
		}
	}
	public partial class Form_GestioneBiglietti : Form
	{
		public List<Biglietto> biglietti = new List<Biglietto>();
		public int numero = 1;
		public string fullPath = @"lista_GestioneBiglietti.csv";
		public Form_GestioneBiglietti()
		{
			InitializeComponent();
			cmbTipo.DataSource = Enum.GetValues(typeof(Tipologia));
		}

		private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			char carattere = e.KeyChar;

			if (!char.IsLetter(carattere) && !char.IsControl(carattere) && carattere != ' ' && carattere != '-')
			{
				e.Handled = true;
			}
		}

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			char carattere = e.KeyChar;

			if (!char.IsNumber(carattere) && !char.IsControl(carattere))
			{
				e.Handled = true;
			}
		}


		private void Form_GestioneBiglietti_Load(object sender, EventArgs e)
		{
			dttData.Value = DateTime.Now;
			dttData.MinDate = DateTime.Now;

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
					Biglietto aggiungere = new Biglietto();
					aggiungere.numero = int.Parse(dati[0]);
					aggiungere.nome = dati[1];
					if (dati[2] == "Intero")
					{
						aggiungere.tipo = (Tipologia)0;
					}
					else if (dati[2] == "Ridotto")
					{
						aggiungere.tipo = (Tipologia)1;
					}
					else if (dati[2] == "VIP")
					{
						aggiungere.tipo = (Tipologia)2;
					}
					aggiungere.data = DateTime.Parse(dati[3]);
					biglietti.Add(aggiungere);

					if (aggiungere.numero >= numero)
					{
						numero = aggiungere.numero + 1;
					}
				}

				MessageBox.Show($"Dati letti con successo dal CSV: {fullPath}");
			}
			else
			{
				MessageBox.Show("Biglietti non trovati o non letti correttamente dal CSV, inizializzo lista vuota");
			}

			AggiornaLista();
		}

		private void btnCrea_Click(object sender, EventArgs e)
		{
			Biglietto nuovo = new Biglietto();

			nuovo.numero = numero;

			if (string.IsNullOrWhiteSpace(txtNome.Text))
			{
				MessageBox.Show("Inserire un nome valido!");
				return;
			}
			nuovo.nome = txtNome.Text;

			nuovo.tipo = (Tipologia)cmbTipo.SelectedIndex;
			nuovo.data = dttData.Value;

			biglietti.Add(nuovo);

			AggiornaLista();

			AggiornaCSV();

			numero++;
		}
		private void btnElimina_Click(object sender, EventArgs e)
		{
			int codice;
			bool eliminato = false;

			if (!int.TryParse(txtNumero.Text, out codice))
			{
				MessageBox.Show("Numero del biglietto non valido!");
				return;
			}

			for (int i = 0; i < biglietti.Count; i++)
			{
				if (biglietti[i].numero == codice)
				{
					biglietti.RemoveAt(i);
					MessageBox.Show("Biglietto eliminato con successo!");
					eliminato = true;
					break;
				}
			}

			if (!eliminato)
			{
				MessageBox.Show("Non è stato possibile eliminare il biglietto selezionato, numero del biglietto non trovato o inesistente!");
				return;
			}

			AggiornaLista();
			AggiornaCSV();
		}

		private void AggiornaLista()
		{
			lstBiglietti.Items.Clear();

			foreach(Biglietto i in biglietti)
			{
   				lstBiglietti.Items.Add(i.Stampa());		
			}
		}

		private void AggiornaCSV()
		{
			using (var sw = new StreamWriter(@"lista_GestioneBiglietti.csv", false))
			{
				foreach (Biglietto i in biglietti)
				{
					sw.WriteLine($"{i.numero:D4};{i.nome};{i.tipo};{i.data}");
				}
			}

			MessageBox.Show("CSV aggiornato con successo!");
		}

		private void btnCerca_Click(object sender, EventArgs e)
		{
			int codice;

			if (!int.TryParse(txtNumero.Text, out codice))
			{
				MessageBox.Show("Numero del biglietto non valido!");
				return;
			}

			bool trovato = false;

			foreach (Biglietto i in biglietti)
			{
				if (i.numero == codice)
				{
					MessageBox.Show($"Biglietto trovato ={Environment.NewLine}{i.Stampa()}");
					trovato = true;
					break;
				}
			}

			if (!trovato)
			{
				MessageBox.Show("Numero del biglietto immesso non trovato o inesistente!");
			}
		}
	}
}
