using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esBiblioteca
{
	public enum Genere
	{
		Giallo, Fantasy, Fantascienza, Romanzo, Saggio
	}


	public struct Libro
	{
		public string titolo;
		public string autore;
		public Genere tipo;
		public int annoPubblicazione;
		public int numeroPagine;
		public bool disponibile;
		public long codiceISBN;

		public Libro(string titolo, string autore, Genere tipo, int annoPubblicazione, int numeroPagine, bool disponibile, long codiceISBN)
		{
			this.titolo = titolo;
			this.autore = autore;
			this.tipo = tipo;
			this.annoPubblicazione = annoPubblicazione;
			this.numeroPagine = numeroPagine;
			this.disponibile = disponibile;
			this.codiceISBN = codiceISBN;

		}
		public string Stampa()
		{
			string sigla = disponibile ? "Sì"
				: "No";
			return $"Titolo: {titolo}, Autore: {autore}, Genere: {tipo}, Anno di pubblicazione: {annoPubblicazione}, Disponibile: {sigla}, Codice ISBN: {codiceISBN}";
		}
	}
	public partial class Form1 : Form
	{
		private void txtTitoloLibro_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-')
			{
				e.Handled = true;
			}
		}
		private void txtAutore_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-')
			{
				e.Handled = true;
			}
		}
		private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsNumber(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}
		private void txtPagine_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsNumber(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}
		private void txtCodice_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsNumber(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		List<Libro> libri = new List<Libro>();
		bool Filtraggio;

		public Form1()
		{
			InitializeComponent();
			cmbGenere.DataSource = Enum.GetValues(typeof(Genere));
			cmbFiltraGenere.DataSource = Enum.GetValues(typeof(Genere));

			string fullPath = @"libri.csv";

			char pv = ';';

			string[] righe = File.ReadAllLines(fullPath);

			for (int i = 0; i < righe.Length; i++)
			{
				string[] dati = righe[i].Split(pv);
				Libro inserire = new Libro();
				inserire.titolo = dati[0];
				inserire.autore = dati[1];
				// Giallo, Fantasy, Fantascienza, Romanzo, Saggio
				if (dati[2] == "Giallo")
				{
					inserire.tipo = (Genere)0;
				}
				else if (dati[2] == "Fantasy")
				{
					inserire.tipo = (Genere)1;
				}
				else if (dati[2] == "Fantascienza")
				{
					inserire.tipo = (Genere)2;
				}
				else if (dati[2] == "Romanzo")
				{
					inserire.tipo = (Genere)3;
				}
				else if (dati[2] == "Saggio")
				{
					inserire.tipo = (Genere)4;
				}
				else
				{
					MessageBox.Show("Importazione annullata, nome del genere di un libro non valida");
					return;
				}

				inserire.annoPubblicazione = int.Parse(dati[3]);
				inserire.numeroPagine = int.Parse(dati[4]);

				if (dati[5] == "Sì")
				{
					inserire.disponibile = true;
				}
				else if (dati[5] == "No")
				{
					inserire.disponibile = false;
				}
				else
				{
					MessageBox.Show("Importazione annullata, disponibilità di un libro non valida");
					return;
				}

				inserire.codiceISBN = long.Parse(dati[6]);

				libri.Add(inserire);
			}

			MessageBox.Show($"Importato da {fullPath}");

			lstLibri.Items.Clear();

				for (int i = 0; i < libri.Count; i++)
				{
					lstLibri.Items.Add(libri[i].Stampa());
				}
			}

		private void btnAggiungi_Click(object sender, EventArgs e)
		{	
			Libro book = new Libro();

			if (string.IsNullOrEmpty(txtTitoloLibro.Text))
			{
				MessageBox.Show("Inserire il titolo del libro");
				return;
			}
			else
			{
				book.titolo = txtTitoloLibro.Text;
			}

			if (string.IsNullOrEmpty(txtTitoloLibro.Text))
			{
				MessageBox.Show("Inserire l'autore del libro");
				return;
			}
			else
			{
				book.autore = txtAutore.Text;
			}

			if (cmbGenere.SelectedIndex == 0)
			{
				book.tipo = (Genere)0;
			}
			else if (cmbGenere.SelectedIndex == 1)
			{
				book.tipo = (Genere)1;
			}
			else if (cmbGenere.SelectedIndex == 2)
			{
				book.tipo = (Genere)2;
			}
			else if (cmbGenere.SelectedIndex == 3)
			{
				book.tipo = (Genere)3;
			}
			else
			{
				book.tipo = (Genere)4;
			}

			int anno = int.Parse(txtAnno.Text);
			if (anno < 1400 || anno > 2026)
			{
				MessageBox.Show("Inserire un anno di pubblicazione valido");
				return;
			}
			book.annoPubblicazione = anno;
			book.numeroPagine = int.Parse(txtPagine.Text);
			book.disponibile = chcDisponibile.Checked ? true
				: false;

			if (txtCodice.Text.Length != 13)
			{
				MessageBox.Show("Il codice ISBN deve avere 13 cifre");
				return;
			}
			book.codiceISBN = long.Parse(txtCodice.Text);
			libri.Add(book);

			lstLibri.Items.Clear();

			foreach (Libro i in libri)
			{
				lstLibri.Items.Add(i.Stampa());
			}

			string fullPath = @"libri.csv";

			using (var sw = new StreamWriter(fullPath, false))
			{
				for (int i = 0; i < libri.Count; i++)
				{
					string titolo = libri[i].titolo;
					string autore = libri[i].autore;
					string genere = libri[i].tipo.ToString();
					int year = libri[i].annoPubblicazione;
					int numerop = libri[i].numeroPagine;
					string sigla;
					if (libri[i].disponibile)
					{
						sigla = "Sì";
					}
					else
					{
						sigla = "No";
					}
					long codice = libri[i].codiceISBN;
					sw.WriteLine($"{titolo};{autore};{genere};{year};{numerop};{sigla};{codice}");
				}
			}

			MessageBox.Show($"Modifiche apportate in {fullPath}");

		}

		private void btnFiltraGenere_Click(object sender, EventArgs e)
		{
				Genere Filtra1 = (Genere)cmbFiltraGenere.SelectedIndex;
			Filtraggio = true;
			Form2 form2 = new Form2(libri, Filtraggio, Filtra1, "");
			form2.Show();
		}

		private void btnFiltraAutore_Click(object sender, EventArgs e)
		{
			string Filtra2 = txtFiltraAutore.Text;
			Filtraggio = false;
			Form2 form2 = new Form2(libri, Filtraggio, new Genere(), Filtra2);
			form2.Show();
		}

		private void btnOrdinamento_Click(object sender, EventArgs e)
		{
			if (rdbAZ.Checked)
			{
				int n = libri.Count;

				for (int i = 0; i < n - 1; i++)
				{
					int minIndex = i;

					for (int j = i + 1; j < n; j++)
					{
						if (string.Compare(libri[j].titolo, libri[minIndex].titolo) < 0)
						{
							minIndex = j;
						}
					}

					if (minIndex != i)
					{
						Libro temp = libri[i];
						libri[i] = libri[minIndex];
						libri[minIndex] = temp;
					}
				}
			}
			else if (rdbAnnoPubblicazione.Checked)
			{
				int n = libri.Count;

				for (int i = 0; i < n - 1; i++)
				{
					int minIndex = i;

					for (int j = i + 1; j < n; j++)
					{
						if (libri[j].annoPubblicazione > libri[minIndex].annoPubblicazione)
						{
							minIndex = j;
						}
					}

					if (minIndex != i)
					{
						Libro temp = libri[i];
						libri[i] = libri[minIndex];
						libri[minIndex] = temp;
					}
				}
			}
			else 
			{
				MessageBox.Show("Inserire un tipo di ordinamento da eseguire");
				return;
			}

			lstLibri.Items.Clear();
			for (int i = 0; i < libri.Count; i++)
			{
				lstLibri.Items.Add(libri[i].Stampa());
			}
		}

		private void btnStatistiche_Click(object sender, EventArgs e)
		{
			int[] conteggi = new int[5];
			int disponibili = 0;

			for (int i = 0; i < libri.Count; i++)
			{
				if (libri[i].disponibile)
				{
					disponibili++;
				}

				if (libri[i].tipo == (Genere)0)
				{
					conteggi[0]++;
				}
				else if (libri[i].tipo == (Genere)1)
				{
					conteggi[1]++;
				}
				else if (libri[i].tipo == (Genere)2)
				{
					conteggi[2]++;
				}
				else if (libri[i].tipo == (Genere)3)
				{
					conteggi[3]++;
				}
				else
				{
					conteggi[4]++;
				}
			}

			int max = conteggi.Max();

			MessageBox.Show($"Il numero totale di libri presenti: {libri.Count}{Environment.NewLine}" +
			$"Il numero di libri disponibili della lista: {disponibili}{Environment.NewLine}" +
			$"Numero di libri divisi per il proprio genere:{Environment.NewLine} {Environment.NewLine}" +
			$"	Giallo: {conteggi[0]} {Environment.NewLine}" +
			$"	Fantasy: {conteggi[1]} {Environment.NewLine}" +
			$"	Fantascienza: {conteggi[2]} {Environment.NewLine}" +
			$"	Romanzo: {conteggi[3]} {Environment.NewLine}" +
			$"	Saggio: {conteggi[4]} {Environment.NewLine}");
		}
	}
}
