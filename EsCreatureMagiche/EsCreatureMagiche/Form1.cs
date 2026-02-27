using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsCreatureMagiche
{
	public enum Razza
	{
		Drago,
		Elfo,
		Troll,
		Fata
	}

	public struct Creatura
	{
		public string Nome;
		public Razza Razza;
		public int LivelloMagia;
		public Creatura(string nome, Razza razza, int livelloMagia)
		{
			Nome = nome;
			Razza = razza;
			LivelloMagia = livelloMagia;
		}
		public string ToString()
		{
			return $"Nome: {Nome} - Razza: {Razza} - Magia: {LivelloMagia}";
		}
	}
	public partial class Form1 : Form
	{
		static List<Creatura> creatures = new List<Creatura>();
		public Form1()
		{
			InitializeComponent();
			cmbBoxRazza.DataSource = Enum.GetValues(typeof(Razza));
			for (int i = 1; i <= 10; i++)
			{
				cmbBoxMagia.Items.Add(i);
			}
			cmbBoxMagia.SelectedIndex = 0;
			panel1.Visible = false;
		}

		private void btnEvoca_Click(object sender, EventArgs e)
		{
			Creatura creatura = new Creatura();

			string name = txtBoxNome.Text;
			Razza razza = (Razza)cmbBoxRazza.SelectedItem;
			int magia = 1;
			if (cmbBoxMagia.SelectedItem != null)
			{
				magia = (int)cmbBoxMagia.SelectedItem;
			}

			creatura.Nome = name;
			creatura.Razza = razza;
			creatura.LivelloMagia = magia;

			if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
			{
				MessageBox.Show("Spiacente, inserire un nome valido");
				return;
			}

			creatures.Add(creatura);

			lstBoxCreature.Items.Clear();

			for (int i = 0; i < creatures.Count(); i++)
			{
				lstBoxCreature.Items.Add(creatures[i].ToString());
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			btnAvvia.Visible = false;
			panel1.Visible = true;
		}

		private void btnScaccia_Click(object sender, EventArgs e)
		{
			string rimuovere = txtBoxNome.Text;

			if (string.IsNullOrEmpty(rimuovere) || string.IsNullOrWhiteSpace(rimuovere))
			{
				MessageBox.Show("Spiacente, inserire un nome valido");
			}

			for (int i = 0; i < creatures.Count(); i++)
			{
				if (creatures[i].Nome == rimuovere)
				{
					creatures.RemoveAt(i);
					break;
				}
			}

			lstBoxCreature.Items.Clear();

			for (int i = 0; i < creatures.Count(); i++)
			{
				lstBoxCreature.Items.Add(creatures[i].ToString());
			}
		}

		private void btnMediaMagia_Click(object sender, EventArgs e)
		{
			double media = 0;
			int somma = 0;
			int c = 0;

			for (c = 0; c < creatures.Count; c++)
			{
				somma += creatures[c].LivelloMagia;
			}

			if (c > 0)
			{
				media = (double)somma / c;
				MessageBox.Show($"La media del livello di magia è: {media}");
			}
			else
			{
				MessageBox.Show("Non ci sono creature evocate sufficienti per fare la media dei livelli di magia");
			}
		}

		private void btnCreatureDeboli_Click(object sender, EventArgs e)
		{
			int deboli = 0;

			for (int j = 0; j < creatures.Count; j++)
			{
				if (creatures[j].LivelloMagia < 5)
				{
					deboli++;
				}
			}

			if (deboli > 0)
			{
				MessageBox.Show($"Ci sono {deboli} creature con un livello di magia inferiore a 5");
			}
			else
			{
				MessageBox.Show("Non ci sono creature evocate con un livello di magia inferiore a 5, oppure non ci sono mostri su cui verificare la debolezza");
			}
		}

		private void btnFiltraRazza_Click(object sender, EventArgs e)
		{
			Razza race = (Razza)cmbBoxRazza.SelectedItem;

			lstBoxCreature.Items.Clear();

			MessageBox.Show($"Lista filtrata per la razza: {race}");

			for (int i = 0; i < creatures.Count(); i++)
			{
				if (creatures[i].Razza == race)
				{
					lstBoxCreature.Items.Add(creatures[i].ToString());
				}
			}
		}

		private void btnCreaturaPotente_Click(object sender, EventArgs e)
		{
			Creatura first = creatures[0];

			for (int i = 1; i < creatures.Count(); i++)
			{
				if (creatures[i].LivelloMagia > first.LivelloMagia)
				{
					first = creatures[i];
				}
			}

			if (creatures.Count() > 0)
			{
				MessageBox.Show($"La creatura più potente è = {first.ToString()}");
			}
			else
			{
				MessageBox.Show("Non ci sono creature evocate sufficienti per identificare la creatura più potente");
			}
		}
	}
}
