using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esSport
{
	public enum Tipe
	{
		Corsa,
		Pesi,
		Nuoto
	}

	public struct Allenamento
	{
		public int durata;
		public Tipe tipo;
		public string luogo;

		public Allenamento(int durata, Tipe tipo, string luogo)
		{
			this.durata = durata;
			this.tipo = tipo;
			this.luogo = luogo;
		}

		public string Stampa()
		{
			return $"Attività: {tipo}, Durata: {durata}, Luogo: {luogo}";
		}
	}


	public partial class Form1 : Form
	{
		private void txtMinuti_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsNumber(c) && !char.IsControl(c) && c != '-')
			{
				e.Handled = true;
			}
		}

		private void txtLuogo_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ' && c != '-' && c != '\'' && c != '\n')
			{
				e.Handled = true;
			}
		}

		Allenamento[] registro = new Allenamento[5];
		int c = 0;

		public Form1()
		{
			InitializeComponent();
			cmbTipo.DataSource = Enum.GetValues(typeof(Tipe));

			string fullPath = @"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\esSport\allenamenti_input.txt";

			char pv = ';';
			char capo = '\n';

			using (var sw = new StreamReader(fullPath, true))
			{
				string[] righe = sw.ReadToEnd().Split(capo);

				for (int i = 0; i < righe.Length; i++)
				{
					string[] dati = righe[i].Split(pv);

					for (int j = 0; j < dati.Length; j++)
					{
						registro[i].durata = int.Parse(dati[0]);
						if (dati[1] == ((Tipe)0).ToString())
						{
							registro[i].tipo = (Tipe)0;
						}
						else if (dati[1] == ((Tipe)1).ToString())
						{
							registro[i].tipo = (Tipe)1;
						}
						else if (dati[1] == ((Tipe)2).ToString())
						{
							registro[i].tipo = (Tipe)2;
						}
						else
						{
							MessageBox.Show("Errore, tipo inserito non valido, annullo inserimento file");
							return;
						}
						registro[i].luogo = dati[2];
					}
					c++;
				}

				MessageBox.Show($"Importato da {fullPath}");

				sw.Close();
			}

			lstRegistro.Items.Clear();

			for (int i = 0; i < registro.Length; i++)
			{
				if (!string.IsNullOrEmpty(registro[i].luogo))
				{
					lstRegistro.Items.Add(registro[i].Stampa());
				}
			}
			NumeroAllenamenti(registro);
			txtOutput.Text += Environment.NewLine;
			txtOutput.Text += Environment.NewLine;
			MaxAllenamenti(registro);
			txtOutput.Text += Environment.NewLine;
			txtOutput.Text += Environment.NewLine;
			LuoghiAllenamenti(registro);
			txtOutput.Text += Environment.NewLine;
			txtOutput.Text += Environment.NewLine;
			MediaAllenamenti(registro);
		}

		private void btnAggiungi_Click(object sender, EventArgs e)
		{

			if (c < 5)
			{
				Allenamento train = new Allenamento();

				train.durata = int.Parse(txtMinuti.Text);
				train.tipo = (Tipe)cmbTipo.SelectedItem;
				train.luogo = txtLuogo.Text;

				registro[c] = train;
				c++;

				lstRegistro.Items.Clear();

				for (int i = 0; i < registro.Length; i++)
				{
					if (!string.IsNullOrEmpty(registro[i].luogo))
					{
						lstRegistro.Items.Add(registro[i].Stampa());
					}
				}
				NumeroAllenamenti(registro);
				txtOutput.Text += Environment.NewLine;
				txtOutput.Text += Environment.NewLine;
				MaxAllenamenti(registro);
				txtOutput.Text += Environment.NewLine;
				txtOutput.Text += Environment.NewLine;
				LuoghiAllenamenti(registro);
				txtOutput.Text += Environment.NewLine;
				txtOutput.Text += Environment.NewLine;
				MediaAllenamenti(registro);
			}
			else
			{
				MessageBox.Show("Registro per gli allenamenti pieno!");
				return;
			}
		}

		private void btnFile_Click(object sender, EventArgs e)
		{
			string fullPath = @"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\esSport\allenamenti_output.txt";

			using (var sw = new StreamWriter(fullPath, true))
			{
				sw.WriteLine("durata;tipo;luogo");

				for (int i = 0; i < registro.Length; i++)
				{
					if (!string.IsNullOrEmpty(registro[i].luogo))
					{
						string durata = registro[i].durata.ToString();
						string tipo = registro[i].tipo.ToString();
						string luogo = registro[i].luogo.ToString();
						sw.WriteLine($"{durata};{tipo};{luogo}");
					}
				}
			}

			MessageBox.Show($"Salvato in {fullPath}");
		}

		public void NumeroAllenamenti(Allenamento[] registro)
		{
          int cCorsa = 0, cPesi = 0, cNuoto = 0;

			for (int i = 0; i < registro.Length; i++)
			{
				if (!string.IsNullOrEmpty(registro[i].luogo))
				{
					switch (registro[i].tipo)
					{
						case Tipe.Corsa:
							cCorsa++;
							break;
						case Tipe.Pesi:
							cPesi++;
							break;
						case Tipe.Nuoto:
							cNuoto++;
							break;
					}
				}
			}
			txtOutput.Text = $" Corsa: {cCorsa} {Environment.NewLine} Pesi: {cPesi} {Environment.NewLine} Nuoto: {cNuoto}";
		}

		public void MaxAllenamenti(Allenamento[] registro)
		{
			int maxCorsa = 0, maxPesi = 0, maxNuoto = 0;

			for (int i = 0; i < registro.Length; i++)
			{
				if (!string.IsNullOrEmpty(registro[i].luogo))
				{
					switch (registro[i].tipo)
					{
						case Tipe.Corsa:
							if (registro[i].durata > maxCorsa)
								maxCorsa = registro[i].durata;
							break;
						case Tipe.Pesi:
							if (registro[i].durata > maxPesi)
								maxPesi = registro[i].durata;
							break;
						case Tipe.Nuoto:
							if (registro[i].durata > maxNuoto)
								maxNuoto = registro[i].durata;
							break;
					}
				}
			}

			txtOutput.Text += $" Durata massima corsa: {maxCorsa} minuti {Environment.NewLine} Durata massima pesi: {maxPesi} minuti {Environment.NewLine} Durata massima nuoto: {maxNuoto} minuti";
		}

		public void LuoghiAllenamenti(Allenamento[] registro)
		{
			txtOutput.Text += $"Allenamenti maggiori svolti: {Environment.NewLine}";

			for (int i = 0; i < registro.Length; i++)
			{
				if (registro[i].durata >= 40)
				{
					txtOutput.Text += $"{registro[i].luogo}{Environment.NewLine}";
				}
			}
		}

		public void MediaAllenamenti(Allenamento[] registro)
		{
			int c = -1;
			double primo = registro[0].durata;
			double secondo = registro[1].durata;
			double terzo = registro[2].durata;

			for (int j = 0; j < registro.Length; j++)
			{
				string converter = registro[j].durata.ToString();
				if (!string.IsNullOrEmpty(converter))
				{
					c++;
				}
			}

			if (c <= 3)
			{
				txtOutput.Text += "Ci sono troppo pochi elementi per eseguire la verifica della media";
			}
			else
			{
				if (secondo == (primo + secondo) / 2)
				{
					txtOutput.Text += $"La media tra questi due allenamenti: {Environment.NewLine}";
					txtOutput.Text += registro[0].Stampa();
					txtOutput.Text += Environment.NewLine;
					txtOutput.Text += registro[2].Stampa();
					txtOutput.Text += Environment.NewLine;
					txtOutput.Text += $"Risulta essere uguale a questo elemento: {Environment.NewLine}";
					txtOutput.Text += registro[1].Stampa();
					txtOutput.Text += Environment.NewLine;
				}
			}
		}
	}
}
