using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form1 : Form
	{
		int i;
		string colore;
		public Form1()
		{
			InitializeComponent();
			i = 0;
		}

		private void btnSaluta_Click(object sender, EventArgs e)
		{
			colore = txtNome.Text;

			if (colore == "rosso")
			{
				btnSaluta.Text = $"Rosso{i}!";
				btnSaluta.ForeColor = Color.LightCoral;
				btnSaluta.BackColor = Color.Red;
				btnSaluta.Image = Image.FromFile(@"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\test\test\rosso.png");
			}
			else if (colore == "verde")
			{
				btnSaluta.Text = $"Verde{i}!";
				btnSaluta.ForeColor = Color.LightGreen;
				btnSaluta.BackColor = Color.Green;
				btnSaluta.Image = Image.FromFile(@"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\test\test\verde.png");
			}
			else if (colore == "blu")
			{ 				
				btnSaluta.Text = $"Blu{i}!";
				btnSaluta.ForeColor = Color.LightBlue;
				btnSaluta.BackColor = Color.Blue;
				btnSaluta.Image = Image.FromFile(@"C:\Users\Loren\OneDrive\Documenti\Informatica\VisualStudio\test\test\blue.png");
			}
			else
			{
				btnSaluta.Text = $"Errore, il colore {colore} non è valido!";
				btnSaluta.ForeColor = Color.White;
				btnSaluta.BackColor = Color.Black;
			}
			i++;
		}
	}
}
