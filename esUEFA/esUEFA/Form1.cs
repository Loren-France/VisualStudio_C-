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

namespace esUEFA
{
	public struct Partita
	{
		public string Casa;
		public string Ospite;
		public int GolCasa;
		public int GolOspite;

		public Partita (string Casa, string Ospite, int GolCasa,  int GolOspite)
		{
			this.Casa = Casa;
			this.Ospite = Ospite;
			this.GolCasa = GolCasa;
			this.GolOspite = GolOspite;
		}

		public string Stampa () 
		{
			return $"Squadra in casa: {Casa} - Squadra in ospite: {Ospite} - Gol in casa: {GolCasa} - Gol in ospite: {GolOspite}";
		}
	}

	public partial class Form1 : Form
	{
		private void txtCasa_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		private void txtOspite_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		private void txtFiltra_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		private void txtGol1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsNumber(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		private void txtGol2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsNumber(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		List<Partita> partite = new List<Partita>();

		public Form1()
		{
			InitializeComponent();

			string fullPath = @"Registro.txt";

			char pv = '-';
			char capo = '\n';

			using (var sw = new StreamReader(fullPath, true))
			{
				string[] righe = sw.ReadToEnd().Split(capo);

				for (int i = 0; i < righe.Length; i++)
				{
					string[] dati = righe[i].Split(pv);
					Partita game = new Partita();
					game.Casa = dati[0];
					game.Ospite = dati[1];
					game.GolCasa = int.Parse(dati[2]);
					game.GolOspite = int.Parse(dati[3]);
					partite.Add(game);
				}

				MessageBox.Show($"Importato da {fullPath}");

				lstPartite.Items.Clear();

				for (int i = 0; i < partite.Count; i++)
				{
					lstPartite.Items.Add(partite[i].Stampa());
				}
			}
		}
		private void btnAggiunta_Click(object sender, EventArgs e)
		{
			Partita game = new Partita ();

			if (txtCasa.Text != txtOspite.Text && !string.IsNullOrEmpty(txtCasa.Text) && !string.IsNullOrEmpty(txtOspite.Text) && !string.IsNullOrEmpty(txtGol1.Text) && !string.IsNullOrEmpty(txtGol2.Text))
			{
				game.Casa = txtCasa.Text;
				game.Ospite = txtOspite.Text;
				game.GolCasa = int.Parse(txtGol1.Text);
				game.GolOspite = int.Parse(txtGol2.Text);
				partite.Add (game);
			}
			else
			{
				MessageBox.Show("Errore, non tutti i campi compilati sono corretti, reinserire i campi esatti");
				return;
			}

			lstPartite.Items.Clear ();

			for (int i = 0; i < partite.Count; i++)
			{
				lstPartite.Items.Add(partite[i].Stampa());
			}
		}

		private void btnFile_Click(object sender, EventArgs e)
		{
			string fullPath = @"Registro.txt";

			using (var sw = new StreamWriter(fullPath, true))
			{

				for (int i = 0; i < partite.Count; i++)
				{
					if (!string.IsNullOrEmpty(partite[i].Casa) && !string.IsNullOrEmpty(partite[i].Ospite) && !string.IsNullOrEmpty(partite[i].GolCasa.ToString()) && !string.IsNullOrEmpty(partite[i].GolOspite.ToString()))
					{
						string nomeCasa = partite[i].Casa;
						string nomeOspite = partite[i].Ospite;
						int GolCasa = partite[i].GolCasa;
						int GolOspite = partite[i].GolOspite;
						sw.WriteLine($"{nomeCasa}-{nomeOspite}-{GolCasa}-{GolOspite}");
					}
				}
			}
			
			MessageBox.Show($"Salvato in {fullPath}");
		}

		private void btnStatistiche_Click(object sender, EventArgs e)
		{
			List<string> squadre = new List<string>();
			List<int> score = new List<int>(); 
			string migliore = "";
			int somma = 0, temp = 0;
			Partita maggiore = new Partita();

			for (int j = 0; j < partite.Count; j++)
			{
				if (!squadre.Contains(partite[j].Casa))
				{
					squadre.Add(partite[j].Casa);
					score.Add(0);
				}
				if (!squadre.Contains(partite[j].Ospite))
				{
					squadre.Add(partite[j].Ospite);
					score.Add(0);
				}
			}

			for (int k = 0; k < partite.Count; k++)
			{
				int indexCasa = squadre.IndexOf(partite[k].Casa);
				int indexOspite = squadre.IndexOf(partite[k].Ospite);

				score[indexCasa] += partite[k].GolCasa;
				score[indexOspite] += partite[k].GolOspite;
			}

			for (int i = 0; i < partite.Count; i++)
			{	
				somma += (partite[i].GolCasa + partite[i].GolOspite);

				if (temp < (partite[i].GolCasa + partite[i].GolOspite))
				{
					temp = (partite[i].GolCasa + partite[i].GolOspite);
					maggiore = partite[i];
				}
			}

			int maxGol = score.Max();
			int pos = score.IndexOf(maxGol); 
			migliore = squadre[pos];

			MessageBox.Show($"La squadra che ha segnato il maggior numero di gol è: {migliore} {Environment.NewLine}Il numero di gol totale segnati nel campionato è: {somma} {Environment.NewLine}La partita in cui sono stati segnati più gol è:{Environment.NewLine}{maggiore.Stampa()}");
		}

		private void btnFiltra_Click(object sender, EventArgs e)
		{
			string dafiltrare = txtFiltra.Text;

			lstPartite.Items.Clear();

			if (string.IsNullOrEmpty(dafiltrare))
			{
				for (int i = 0; i < partite.Count; i++)
				{
					lstPartite.Items.Add(partite[i].Stampa());
				}
			}
			else
			{
				for (int i = 0; i < partite.Count; i++)
				{
					if (partite[i].Casa == dafiltrare || partite[i].Ospite == dafiltrare)
					{
						lstPartite.Items.Add(partite[i].Stampa());
					}
				}
			}
		}
	}
}
