using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esPasticceria
{
	public enum Frolla
	{
		Classica,
		Integrale,
		GlutenFree,
		Semi
	}

	public enum Marmellata
	{
		Albicocca,
		Fragola,
		FruttiDiBosco,
		Crema
	}

	public enum Filtra
	{
		Default,
		Albicocca,
		Fragola,
		FruttiDiBosco,
		Crema
	}

	public struct Crostata
	{
		public Frolla tipoFrolla;
		public Marmellata tipoMarmellata;
		public double cottura;
		public double diametro;
		public bool decorazione;
		public string nome;

		public Crostata (Frolla tipoFrolla, Marmellata tipoMarmellata, int cottura, int diametro, bool decorazione, string nome)
		{
			this.tipoFrolla = tipoFrolla;
			this.tipoMarmellata = tipoMarmellata;
			this.cottura = cottura;
			this.diametro = diametro;
			this.decorazione = decorazione;
			this.nome = nome;
		}

		public string Stampa()
		{
			string sigla = "No";
			if (decorazione)
			{
				sigla = "Sì";
			}

			return $"Nome: {nome} - Frolla: {tipoFrolla} - Marmellata: {tipoMarmellata} -  Cottura: {cottura} - Diametro: {diametro} - Decorazione: {sigla}";
		}
	}

	public partial class Form1 : Form
	{
		private void txtCottura_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsNumber(c) && !char.IsControl(c) && c != '.')
			{
				e.Handled = true;
			}
		}

		private void txtDiametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsNumber(c) && !char.IsControl(c) && c != '.')
			{
				e.Handled = true;
			}
		}

		private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsLetter(c) && !char.IsControl(c) && c != '-' && c != ' ')
			{
				e.Handled = true;
			}
		}

		List<Crostata> crostate = new List<Crostata>();
		public string fullPath = @"Ricette.csv";

		public Form1()
		{
			InitializeComponent();
			cmbFrolla.DataSource = Enum.GetValues(typeof(Frolla));
			cmbMarmellata.DataSource = Enum.GetValues(typeof(Marmellata));
			cmbFiltra.DataSource = Enum.GetValues(typeof(Filtra));

			char pv = ';';

			string[] righe = File.ReadAllLines(fullPath);

			for (int i = 0; i < righe.Length; i++)
			{
				string[] dati = righe[i].Split(pv);
				Crostata inserire = new Crostata();
				inserire.nome = dati[0];
				if (dati[1] == "Classica")
				{
					inserire.tipoFrolla = (Frolla)0;
				}
				else if (dati[1] == "Integrale")
				{
					inserire.tipoFrolla = (Frolla)1;
				}
				else if (dati[1] == "GlutenFree")
				{
					inserire.tipoFrolla = (Frolla)2;
				}
				else if (dati[1] == "Semi")
				{
					inserire.tipoFrolla = (Frolla)3;
				}
				else
				{
					return;
				}

				if (dati[2] == "Albicocca")
				{
					inserire.tipoMarmellata = (Marmellata)0;
				}
				else if (dati[2] == "Fragola")
				{
					inserire.tipoMarmellata = (Marmellata)1;
				}
				else if (dati[2] == "FruttiDiBosco")
				{
					inserire.tipoMarmellata = (Marmellata)2;
				}
				else if (dati[2] == "Crema")
				{
					inserire.tipoMarmellata = (Marmellata)3;
				}
				else
				{
					return;
				}

				inserire.cottura = double.Parse(dati[3]);
				inserire.diametro = double.Parse(dati[4]);

				if (dati[5] == "Sì")
				{
					inserire.decorazione = true;
				}
				else if (dati[5] == "No")
				{
					inserire.decorazione = false;
				}
				else
				{
					return;
				}

				crostate.Add(inserire);
			}

			MessageBox.Show($"Importato da {fullPath}");

			SelectionSort(crostate);

			lstCrostate.Items.Clear();

			for (int j = 0; j < crostate.Count; j++)
			{
				lstCrostate.Items.Add(crostate[j].Stampa());
			}
		}

		private void btnAggiunta_Click(object sender, EventArgs e)
		{
			Crostata nuova = new Crostata();

			if (string.IsNullOrEmpty(txtNome.Text))
			{
				MessageBox.Show("Inserire un nome per la crostata");
				return;
			}
			nuova.nome = txtNome.Text;
			nuova.tipoFrolla = (Frolla)cmbFrolla.SelectedIndex;
			nuova.tipoMarmellata = (Marmellata)cmbMarmellata.SelectedIndex;

			if (string.IsNullOrEmpty(txtCottura.Text))
			{
				MessageBox.Show("Inserire un tempo di cottura");
				return;
			}
			nuova.cottura = int.Parse(txtCottura.Text);

			if (string.IsNullOrEmpty(txtDiametro.Text))
			{
				MessageBox.Show("Inserire un diametro per la crostata");
				return;
			}
			nuova.diametro = int.Parse(txtDiametro.Text);

			if (rdbDecorazioniTrue.Checked)
			{
				nuova.decorazione = true;
			}
			else if (rdbDecorazioniFalse.Checked)
			{
				nuova.decorazione = false;
			}
			else
			{
				MessageBox.Show("Inserire la preferenza se si vogliono o meno le decorazioni");
				return;
			}

			crostate.Add(nuova);

			SelectionSort(crostate);

			lstCrostate.Items.Clear();

			for (int i = 0; i < crostate.Count; i++)
			{
				lstCrostate.Items.Add(crostate[i].Stampa());
			}


			using (var sw = new StreamWriter(fullPath, false))
			{
				for (int i = 0; i < crostate.Count; i++)
				{
					string nome = crostate[i].nome;
					string frolla = crostate[i].tipoFrolla.ToString();
					string confettura = crostate[i].tipoMarmellata.ToString();
					double gradi = crostate[i].cottura;
					double diametro = crostate[i].diametro;
					string sigla;
					if (crostate[i].decorazione)
					{
						sigla = "Sì";
					}
					else
					{
						sigla = "No";
					}
					sw.WriteLine($"{nome};{frolla};{confettura};{gradi};{diametro};{sigla}");
				}
			}

			MessageBox.Show($"Modifiche apportate in {fullPath}");
		}

		private void btnFiltra_Click(object sender, EventArgs e)
		{
			if (cmbFiltra.SelectedIndex == 0)
			{
				lstCrostate.Items.Clear();

				for (int j = 0; j < crostate.Count; j++)
				{
					lstCrostate.Items.Add(crostate[j].Stampa());
				}
				MessageBox.Show("Ricette senza filtraggio");
			}
			else
			{
				lstCrostate.Items.Clear();

				for (int j = 0; j < crostate.Count; j++)
				{
					if (crostate[j].tipoMarmellata == (Marmellata)cmbFiltra.SelectedIndex-1)
					{
						lstCrostate.Items.Add(crostate[j].Stampa());
					}
				}
				MessageBox.Show($"Ricette filtrate per marmellata tipo: {(Marmellata)cmbFiltra.SelectedIndex-1}");
			}
		}

		static void SelectionSort(List<Crostata> lista)
		{
			int n = lista.Count;

			for (int i = 0; i < n - 1; i++)
			{
				int minIndex = i;

				for (int j = i + 1; j < n; j++)
				{
					if (string.Compare(lista[j].nome, lista[minIndex].nome) < 0)
					{
						minIndex = j;
					}
				}

				if (minIndex != i)
				{
					Crostata temp = lista[i];
					lista[i] = lista[minIndex];
					lista[minIndex] = temp;
				}
			}
		}


	}
}
