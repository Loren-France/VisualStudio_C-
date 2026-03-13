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
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace esCavalli
{
	public struct Cavallo
	{
		public string nome;
		public string razza;
		public int anno;
		public bool sesso;
		
		public Cavallo (string nome, string razza, int anno, bool sesso)
		{
			this.nome = nome;
			this.razza = razza;
			this.anno = anno;
			this.sesso = sesso;
		}

		public string Stampa()
		{
			char lettera;

			if (sesso)
			{
				lettera = 'M';
			}
			else
			{
				lettera = 'F';
			}

			return $"Cavallo: {nome}, Razza: {razza}, Anno di nascita: {anno}, Sesso: {lettera}";
		}
	}

	public partial class Form1 : Form
	{
		List <Cavallo> cavalli = new List <Cavallo>(5);
		int c = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Selezionare file .txt per importare i dati";

			string fullPath;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fullPath = ofd.FileName;

				char pv = ';';
				char capo = '\n';
				char maschio = 'M';

				using (var sw = new StreamReader(fullPath, true))
				{
					string[] righe = sw.ReadToEnd().Split(capo);

					for (int i = 0; i < righe.Length; i++)
					{
						Cavallo puledro = new Cavallo();
						string[] dati = righe[i].Split(pv);

						for (int j = 0; j < dati.Length; j++)
						{
							puledro.nome = dati[0].ToString();
							puledro.razza = dati[1].ToString();
							puledro.anno = int.Parse(dati[2].ToString());
							char lettera = char.Parse(dati[3].Trim());
							if (maschio == lettera)
							{
								puledro.sesso = true;
							}
							else
							{
								puledro.sesso = false;
							}
						}
						cavalli.Add(puledro);
					}

					lstCavalli.Items.Clear();

					for (int i = 0; i < cavalli.Count; i++)
					{
						lstCavalli.Items.Add(cavalli[i].Stampa());
					}

					MessageBox.Show($"Importato da {fullPath}");

					sw.Close();
				}
			}
		}

		private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-' && c != '\'' && c != '\n')
			{
				e.Handled = true;
			}
		}

		private void txtRazza_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-' && c != '\'' && c != '\n')
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

		private void btnSalva_Click(object sender, EventArgs e)
		{
			if (c < 10)
			{
				Cavallo puledro = new Cavallo();
				puledro.nome = txtNome.Text;
				puledro.razza = txtRazza.Text;
				puledro.anno = int.Parse(txtAnno.Text);

				if (rdbF.Checked)
				{
					puledro.sesso = false;
				}
				else if (rdbM.Checked)
				{
					puledro.sesso = true;
				}
				else
				{
					MessageBox.Show("Selezionare il sesso di un cavallo");
					return;
				}

				cavalli.Add(puledro);

				lstCavalli.Items.Clear();

				for (int i = 0; i < cavalli.Count; i++)
				{
					lstCavalli.Items.Add(cavalli[i].Stampa());
				}
			}
			else
			{
				MessageBox.Show("La stalla è piena, non è possibile inserire più cavalli!");
				return;
			}
			c++;
		}

		private void btnFiltra_Click(object sender, EventArgs e)
		{
			lstCavalli.Items.Clear();

			for (int i = 0; i < cavalli.Count; i++)
			{
				if (txtNome.Text == cavalli[i].nome)
				{
					MessageBox.Show($"Ecco il cavallo che si voleva trovare => {cavalli[i].Stampa()}");
					break;
				}
			}
		}

		private void btnModifica_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < cavalli.Count; i++)
			{
				if (txtNome.Text == cavalli[i].nome)
				{
					Cavallo modificare = cavalli[i];
					modificare.razza = txtRazza.Text;
					modificare.anno = int.Parse(txtAnno.Text);
					
					if (rdbM.Checked) {
						modificare.sesso = true;
					}
					else if (rdbF.Checked)
					{
						modificare.sesso = false;
					}
					else {
						MessageBox.Show("Inserire il sesso modificato");
						return;
					}

					cavalli[i] = modificare;

					MessageBox.Show("Cavallo modificato con successo!");

					break;
				}
			}

			lstCavalli.Items.Clear();

			for (int i = 0; i < cavalli.Count; i++)
			{
				lstCavalli.Items.Add(cavalli[i].Stampa());
			}
		}

		private void btnRimozione_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < cavalli.Count; i++)
			{
				if (txtNome.Text == cavalli[i].nome)
				{
					cavalli.RemoveAt(i);
					MessageBox.Show("Cavallo rimosso con successo!");
					break;
				}
			}

			lstCavalli.Items.Clear();

			for (int i = 0; i < cavalli.Count; i++)
			{
				lstCavalli.Items.Add(cavalli[i].Stampa());
			}
		}
		private void btnFile_Click(object sender, EventArgs e)
		{
			string fullPath = @"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\esCavalli\Resoconto.txt";

			using (var sw = new StreamWriter(fullPath, true))
			{
				for (int i = 0; i < cavalli.Count; i++)
				{
					if (!string.IsNullOrEmpty(cavalli[i].nome))
					{
						string durata = cavalli[i].nome.ToString();
						string tipo = cavalli[i].razza.ToString();
						string luogo = cavalli[i].anno.ToString();
						char lettera;
						if (cavalli[i].sesso)
						{
							lettera = 'M';
						}
						else
						{
							lettera = 'F';
						}
						sw.WriteLine($"{durata};{tipo};{luogo};{lettera}");
					}
				}
			}

			MessageBox.Show($"Salvato in {fullPath}");
		}
	}
}