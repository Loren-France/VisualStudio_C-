using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esDanceDanceRevolution
{
	public partial class Form1 : Form
	{
		Random r = new Random();
		List <Button> frecce = new List<Button>();
		public Form1()
		{
			InitializeComponent();
			frecce.Add(btn1);
			frecce.Add(btn2);
			frecce.Add(btn3);
			frecce.Add(btn4);
		}

		private void txtNickname_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			if (!char.IsLetter(c) && !char.IsControl(c))
			{
				e.Handled = true;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int rand = r.Next(1, 5);
			ImageChange(frecce[rand]);
			pnlDati.Visible = true;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (txtNickname.Text.Length > 0)
			{
				lblGiocatore.Text = "Giocatore: " + txtNickname.Text;
				pnlDati.Visible = false;
			}
			else
			{
				MessageBox.Show("Inserisci un nickname valido!");
			}
		}

		private void ImageChange(Button b)
		{
			if (b.Name == "btn1")
			{
				btn1.Image = Properties.Resources.freccia_su;
			}
			else if (b.Name == "btn2")
			{
				btn2.Image = Properties.Resources.freccia_sx;
			}
			else if (b.Name == "btn3")
			{
				btn3.Image = Properties.Resources.freccia_dx;
			}
			else if (b.Name == "btn4")
			{
				btn4.Image = Properties.Resources.freccia_giu;
			}
		}

		private void ImageDefault(Button b)
		{
			if (b.Name == "btn1")
			{
				btn1.BackgroundImage = Image.FromFile(@"Resources\freccia su.png");
			}
			else if (b.Name == "btn2")
			{
				btn2.BackgroundImage = Image.FromFile(@"Resources\freccia sx.png");
			}
			else if (b.Name == "btn3")
			{
				btn3.BackgroundImage = Image.FromFile(@"Resources\freccia dx.png");
			}
			else if (b.Name == "btn4")
			{
				btn4.BackgroundImage = Image.FromFile(@"Resources\freccia giu.png");
			}
		}
	}
}
