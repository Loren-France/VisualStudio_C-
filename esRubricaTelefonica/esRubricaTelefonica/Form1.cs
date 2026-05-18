using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esRubricaTelefonica
{
	public partial class Form1 : Form
	{
		Dictionary<string, Recapiti> contatti = new Dictionary<string, Recapiti>();

		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			contatti.Clear();
		}

		private void btnAggiunta_Click(object sender, EventArgs e)
		{
			try{
				string nome = txtNomeCognome.Text;
				string numero = txtNumero.Text;
				MailAddress email = new MailAddress(txtEmail.Text);
				DateTime data = dtpData.Value;

				contatti.Add(nome, new Recapiti(numero, email, data));

				Stampa();

				MessageBox.Show("Contatto aggiunto con successo!");

				txtNomeCognome.Clear();
				txtNumero.Clear();
				txtEmail.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Errore durante l'aggiunta del contatto: " + ex.Message);
				return;
			}
		}

		private void btnRimozione_Click(object sender, EventArgs e)
		{
			try
			{
				string nome = txtEliminaRicerca.Text;
				if (contatti.ContainsKey(nome))
				{
					contatti.Remove(nome);
					Stampa();
					MessageBox.Show("Contatto rimosso con successo!");
					txtEliminaRicerca.Clear();
				}
				else
				{
					MessageBox.Show("Contatto non trovato!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Errore durante la rimozione: " + ex.Message);
			}
		}

		private void btnModifica_Click(object sender, EventArgs e)
		{
			try
			{
				string nome = txtNomeCognome.Text;
				if (contatti.ContainsKey(nome))
				{
					string numero = txtNumero.Text;
					MailAddress email = new MailAddress(txtEmail.Text);
					DateTime data = dtpData.Value;

					contatti[nome] = new Recapiti(numero, email, data);
					Stampa();
					MessageBox.Show("Contatto modificato con successo!");

					txtNomeCognome.Clear();
					txtNumero.Clear();
					txtEmail.Clear();
				}
				else
				{
					MessageBox.Show("Contatto non trovato!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Errore durante la modifica: " + ex.Message);
			}
		}

		private void btnRicerca_Click(object sender, EventArgs e)
		{
			try
			{
				string nome = txtEliminaRicerca.Text;
				if (contatti.ContainsKey(nome))
				{
					MessageBox.Show("Contatto trovato!");
					string trovato = $"Nome: {nome}\nNumero: {contatti[nome].Numero}\nEmail: {contatti[nome].Email.Address}\nData: {contatti[nome].DataCompleanno.ToShortDateString()}";
					MessageBox.Show(trovato);
				}
				else
				{
					MessageBox.Show("Contatto non trovato!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Errore durante la ricerca: " + ex.Message);
			}
		}

		public void Stampa()
		{
			lstContatti.Items.Clear();
			foreach (KeyValuePair<string, Recapiti> contatto in contatti)
			{
				lstContatti.Items.Add($"Nome: {contatto.Key}, {contatto.Value.ToString()}");
			}
		}
	}
}
