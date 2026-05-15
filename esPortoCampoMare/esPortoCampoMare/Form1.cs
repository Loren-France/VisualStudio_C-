using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esPortoCampoMare
{
	public partial class Form1 : Form
	{

		Porto nuovo = new Porto("Capo Mare");

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Random rand = new Random();
			int r = rand.Next(5, 16);
			nuovo.RegistraBarche(r);
			lstBarche.Items.Clear();
			foreach (var item in nuovo.dizionario)
			{
				lstBarche.Items.Add($"ID: {item.Key} - Nome: {item.Value.Nome} - Capitano: {item.Value.Capitano} - Carico: {item.Value.Carico} - Tipologia: {item.Value.Tipocarico}");
			}
			Titolo.Text = $"Porto di {nuovo.Nome}";
		}

		private void btnGestisciPartenza_Click(object sender, EventArgs e)
		{
			int car = int.Parse(txtCarico.Text);
			MessageBox.Show(nuovo.GestisciPartenze(car));
			lstBarche.Items.Clear();
			foreach (var item in nuovo.dizionario)
			{
				lstBarche.Items.Add($"ID: {item.Key} - Nome: {item.Value.Nome} - Capitano: {item.Value.Capitano} - Carico: {item.Value.Carico} - Tipologia: {item.Value.Tipocarico}");
			}
		}
	}
}
