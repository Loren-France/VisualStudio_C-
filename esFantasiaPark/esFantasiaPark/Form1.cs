using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esFantasiaPark
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			 
		}

		private void btnGestioneBiglietti_Click(object sender, EventArgs e)
		{
			Form_GestioneBiglietti formGestioneBiglietti = new Form_GestioneBiglietti();
			formGestioneBiglietti.Show();
		}

		private void btnGestioneGiostre_Click(object sender, EventArgs e)
		{
			Form_GestioneGiostre formGestioneGiostre = new Form_GestioneGiostre();
			formGestioneGiostre.Show();
		}

		private void btnGestioneAttrazioni_Click(object sender, EventArgs e)
		{
			Form_GestioneAttrazioni formGestioneAttrazioni = new Form_GestioneAttrazioni();
			formGestioneAttrazioni.Show();
		}

		private void btnChiusura_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
