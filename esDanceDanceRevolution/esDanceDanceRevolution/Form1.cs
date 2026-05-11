using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using esDanceDanceRevolution.Properties;

namespace esDanceDanceRevolution
{
	public partial class Form1 : Form
	{
		int punteggio = 0;
		Random r = new Random();
		int rand;
		List<Button> frecce = new List<Button>();
		bool[] lighter = new bool[4] { false, false, false, false };
		public Form1()
		{
			InitializeComponent();
			frecce.Add(btn1);
			frecce.Add(btn2);
			frecce.Add(btn3);
			frecce.Add(btn4);
			
			btn1.Click += Btn1_Click;
			btn2.Click += Btn2_Click;
			btn3.Click += Btn3_Click;
			btn4.Click += Btn4_Click;
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
			int rand = r.Next(frecce.Count);
			ImageChange(frecce[rand]);
			lighter[rand] = true;
			pnlDati.Visible = true;
			
			PlayMusic();
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
				btn1.BackgroundImage = Resources.FracciaSuColor;
			}
			else if (b.Name == "btn2")
			{
				btn2.BackgroundImage = Resources.FrecciaSXColor;
			}
			else if (b.Name == "btn3")
			{
				btn3.BackgroundImage = Resources.FrecciaDxColor;
			}
			else if (b.Name == "btn4")
			{
				btn4.BackgroundImage = Resources.FrecciagiuColor;
			}
		}

		private void ImageDefault(Button b)
		{
			if (b.Name == "btn1")
			{
				btn1.BackgroundImage = Resources.frecciaSu;
			}
			else if (b.Name == "btn2")
			{
				btn2.BackgroundImage = Resources.frecciaSX;
			}
			else if (b.Name == "btn3")
			{
				btn3.BackgroundImage = Resources.frecciaDx;
			}
			else if (b.Name == "btn4")
			{
				btn4.BackgroundImage = Resources.frecciaGiu;
			}
		}

		private void Btn1_Click(object sender, EventArgs e)
		{
			if (lighter[0])
			{
				foreach (Button b in frecce)
				{
					ImageDefault(b);
				}
				punteggio += 10;
				lblPunteggio.Text = $"Punteggio: {punteggio}";
				ImageDefault(btn1);
				rand = r.Next(0, 4);
				for (int i = 0; i < lighter.Length; i++)
				{
					lighter[i] = false;
				}
				lighter[rand] = true;
				ImageChange(frecce[rand]);
			}
		}

		private void Btn2_Click(object sender, EventArgs e)
		{
			if (lighter[1])
			{
				foreach (Button b in frecce)
				{
					ImageDefault(b);
				}
				punteggio += 10;
				lblPunteggio.Text = $"Punteggio: {punteggio}";
				ImageDefault(btn2);
				rand = r.Next(0, 4);
				for (int i = 0; i < lighter.Length; i++)
				{
					lighter[i] = false;
				}
				lighter[rand] = true;
				ImageChange(frecce[rand]);
			}
		}

		private void Btn3_Click(object sender, EventArgs e)
		{
			if (lighter[2])
			{
				foreach (Button b in frecce)
				{
					ImageDefault(b);
				}
				punteggio += 10;
				lblPunteggio.Text = $"Punteggio: {punteggio}";
				ImageDefault(btn3);
				rand = r.Next(0, 4);
				for (int i = 0; i < lighter.Length; i++)
				{
					lighter[i] = false;
				}
				lighter[rand] = true;
				ImageChange(frecce[rand]);
			}
		}

		private void Btn4_Click(object sender, EventArgs e)
		{
			if (lighter[3])
			{
				foreach (Button b in frecce)
				{
					ImageDefault(b);
				}
				punteggio += 10;
				lblPunteggio.Text = $"Punteggio: {punteggio}";
				ImageDefault(btn4);
				rand = r.Next(0, 4);
				for (int i = 0; i < lighter.Length; i++)
				{
					lighter[i] = false;
				}
				lighter[rand] = true;
				ImageChange(frecce[rand]);
			}
		}

		private void PlayMusic()
		{
			try
			{
				SoundPlayer player = new SoundPlayer(@"backgroud_music.wav");
				player.PlayLooping();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore: {ex.Message}");
			}
		}
	}
}
