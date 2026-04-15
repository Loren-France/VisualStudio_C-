using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using esOperatoreSIM;

namespace esOperatoreSIMForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		CartaSIM sim = new CartaSIM(1234567890, 50);

		private void Form1_Load(object sender, EventArgs e)
		{
			lblSIM.Text = sim.Stampa2();
		}

		private void btnAggiungi_Click(object sender, EventArgs e)
		{
			long numero = long.Parse(txtNumero.Text);
			int durata = int.Parse(txtDurata.Text);
			Telefonata nuova = new Telefonata(durata, numero);
			sim.AggiungiTelefonata(nuova);
			AggiornaLista();

		}

		public void AggiornaLista()
		{
			foreach (Telefonata t in sim.RitornaLista())
			{
				lstTelefonate.Items.Add(t.stampa1());
			}
		}
	}
}
