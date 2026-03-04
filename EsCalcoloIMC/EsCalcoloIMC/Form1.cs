using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsCalcoloIMC
{
	public enum Interpretazione
	{
		Sottopeso,
		Peso_normale,
		Sovrappeso,
		Obesità
	}
	public struct Persona
	{
		public string CognomeNome;
		public double Peso;
		public double Altezza;
		public double IMC;
		public Interpretazione Feedback;
		public Persona (string CognomeNome, double Peso, double Altezza, double IMC, Interpretazione Feedback)
		{
			this.CognomeNome = CognomeNome;
			this.Peso = Peso;
			this.Altezza = Altezza;
			this.IMC = IMC;
			this.Feedback = Feedback;
		}
		public string Stampa()
		{
			return $"ID: {CognomeNome}, Peso: {Peso}, Altezza: {Altezza}, IMC: {IMC}, FeedBack: {Feedback}";
		}
	}
	public partial class Form1 : Form
	{
		List <Persona> pazienti = new List <Persona> ();
		public Form1()
		{
			InitializeComponent();
		}

		private void txtCognomeNome_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-' && c != '\'' && c!='\n')
			{
				e.Handled = true;
			}
		}

		private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsNumber(c) && !char.IsControl(c) && c!='.')
			{
				e.Handled = true;
			}
		}

		private void txtAltezza_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsNumber(c) && !char.IsControl(c) && c != '.')
			{
				e.Handled = true;
			}
		}

		public void btnEsegui_Click(object sender, EventArgs e)
		{
			if (rdbCalcoloIMC.Checked)
			{
				string Conom = txtCognomeNome.Text;
				double weight = double.Parse(txtPeso.Text);
				double height = double.Parse(txtAltezza.Text) / 100;
				double IMC = weight / Math.Pow(height, 2);
				Interpretazione Feedback = ControlloStato(IMC);
				lblOutput.Text = $"L'IMC dei dati della persona inserita è : {IMC} , il paziente è considerato con questo stato: {Feedback}";
			}
			else if (rdbMediaIMC.Checked)
			{
				double somma = 0;

				for (int i = 0; i < pazienti.Count; i++)
				{
					somma += pazienti[i].IMC;
				}

				double media = somma / pazienti.Count;

				Interpretazione state = ControlloStato(media);

				lblOutput.Text = $"L'IMC medio dei pazienti inserito è: {media}, quindi come stato medio si considera: {state}";
			}
			else if (rdbModaIMC.Checked)
			{
				Interpretazione moda;
				int c1 = 0, c2 = 0, c3 = 0, c4 = 0;
				for (int i = 0; i < pazienti.Count; i++)
				{
					if (pazienti[i].Feedback == (Interpretazione)0)
					{
						c1++;
					}
					else if (pazienti[i].Feedback == (Interpretazione)1)
					{
						c2++;
					}
					else if (pazienti[i].Feedback == (Interpretazione)2)
					{
						c3++;
					}
					else
					{
						c4++;
					}
				}

				if (c1 > c2 && c1 > c3 && c1 > c4)
				{
					moda = (Interpretazione)0;
				}
				else if (c2 > c1 && c2 > c3 && c2 > c4)
				{
					moda = (Interpretazione)1;
				}
				else if (c3 > c1 && c3 > c2 && c3 > c2)
				{
					moda = (Interpretazione)2;
				}
				else
				{
					moda = (Interpretazione)3;
				}

				lblOutput.Text = $"Nella lista di persone inserita la moda di IMC tende allo status di: {moda}";
			}
			else if (rdbMedianaIMC.Checked) // mediana da sistemare
			{

				if (pazienti.Count % 2 == 0)
				{

				}
				else
				{

				}
			}
			else if (rdbVarianzaIMC.Checked)
			{
				double media = 0, somma = 0, varianza;
				double[] IMC = new double[pazienti.Count];

				for (int j = 0; j < pazienti.Count; j++)
				{
					media += pazienti[j].IMC;
				}

				media /= pazienti.Count;

				for (int i = 0; i < IMC.Length; i++)
				{
					IMC[i] = Math.Pow(pazienti[i].IMC - media, 2);
					somma += IMC[i];
				}

				varianza = Math.Sqrt(somma);

				lblOutput.Text = $"La varianza del IMC risulta essere: {varianza}";
 			}
			else
			{
				MessageBox.Show("Inserire un'azione da eseguire");
			}
		}

		public void btnSalva_Click(object sender, EventArgs e)
		{
			Persona nuova = new Persona();
			nuova.CognomeNome = txtCognomeNome.Text;
			nuova.Peso = double.Parse(txtPeso.Text);
			nuova.Altezza = double.Parse(txtAltezza.Text) / 100;
			nuova.IMC = nuova.Peso / Math.Pow(nuova.Altezza, 2);
			nuova.Feedback = ControlloStato(nuova.IMC);
			pazienti.Add(nuova);
			MessageBox.Show("Persona salvata correttamente!");
			lstPersone.Items.Clear();
			for (int i = 0; i < pazienti.Count; i++)
			{
				lstPersone.Items.Add(pazienti[i].Stampa());
			}
		}

		static Interpretazione ControlloStato(double IMC)
		{
			if (IMC < 18.5)
			{
				return (Interpretazione)0;
			}
			else if (IMC < 24.9)
			{
				return (Interpretazione)1;
			}
			else if (IMC < 29.9)
			{
				return (Interpretazione)2;
			}
			else
			{
				return (Interpretazione)3;
			}
		}
	}
}
