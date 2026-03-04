using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPuffiFanCosì
{

	struct Punto
	{
		public int x;
		public int y;

		public Punto (int x, int y)
		{
			this.x = x;
			this.y = y;
		}

	}
	public partial class Form1 : Form
	{
	    Panel[] panels = new Panel[10];
		Punto puffo = new Punto();
		Punto casetta = new Punto();
		Punto gargamella = new Punto();
		Punto[] alberi = new Punto[10];
		Random rand = new Random();
		int cP = 0, cG = 0, movement = 0;
		bool TurnoPuffo = true;

		public Form1()
		{
			InitializeComponent();
			puffo.x = 0;
			puffo.y = 0;
			casetta.x = rand.Next(0, pnlCittà.Width - pnlCasetta.Width);
			casetta.y = rand.Next(0, pnlCittà.Height - pnlCasetta.Height);
			gargamella.x = pnlCittà.Width - pnlGargamella.Width;
			gargamella.y = pnlCittà.Height- pnlGargamella.Height;
			pnlPuffo.Location = new Point(puffo.x, puffo.y);
			pnlCasetta.Location = new Point(casetta.x, casetta.y);
			pnlGargamella.Location = new Point(gargamella.x, gargamella.y);
			for (int i = 0; i < panels.Length; i++)
			{
				panels[i] = new Panel();
				panels[i].Width = pnlCasetta.Width;
				panels[i].Height = pnlCasetta.Height;
				panels[i].BackColor = Color.Green;
				panels[i].BackgroundImage = Properties.Resources.a_tree_with_green_leaves_free_vector;
				panels[i].BackgroundImageLayout = ImageLayout.Zoom;
				panels[i].BorderStyle = BorderStyle.Fixed3D;
				panels[i].Visible = true;
				alberi[i].x = rand.Next(0, pnlCittà.Width - panels[i].Width);
				alberi[i].y = rand.Next(0, pnlCittà.Height - panels[i].Height);
				panels[i].Location = new Point(alberi[i].x, alberi[i].y);
				pnlCittà.Controls.Add(panels[i]);
			}
			lblPunteggioP.Text = $"Punteggio Puffo: {cP}";
			lblPunteggioG.Text = $"Punteggio Gargamella: {cG}";
			lblTurno.Text = "Turno del PUFFO";
			lblTurno.ForeColor = Color.Blue;
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (TurnoPuffo)
			{
				lblTurno.Text = "Turno del PUFFO";
				lblTurno.ForeColor = Color.Blue;
				switch (e.KeyCode)
				{
					case Keys.S:
						puffo.y += 20;
						break;
					case Keys.D:
						puffo.x += 20;
						break;
					case Keys.A:
						puffo.x -= 20;
						break;
					case Keys.W:
						puffo.y -= 20;
						break;
					default:
						break;
				}

				if (puffo.x < 0)
				{
					puffo.x = 0;
				}
				if (puffo.y < 0)
				{
					puffo.y = 0;
				}
				if (puffo.x > pnlCittà.Width - pnlPuffo.Width)
				{
					puffo.x = pnlCittà.Width - pnlPuffo.Width;
				}
				if (puffo.y > pnlCittà.Height - pnlPuffo.Height)
				{
					puffo.y = pnlCittà.Height - pnlPuffo.Height;
				}

				pnlPuffo.Location = new Point(puffo.x, puffo.y);
			}
			else
			{
				lblTurno.Text = "Turno di GARGAMELLA";
				lblTurno.ForeColor = Color.Red;
				switch (e.KeyCode)
				{
					case Keys.K:
						gargamella.y += 20;
						break;
					case Keys.L:
						gargamella.x += 20;
						break;
					case Keys.J:
						gargamella.x -= 20;
						break;
					case Keys.I:
						gargamella.y -= 20;
						break;
					default:
						break;
				}

				if (gargamella.x < 0)
				{
					gargamella.x = 0;
				}
				if (gargamella.y < 0)
				{
					gargamella.y = 0;
				}
				if (gargamella.x > pnlCittà.Width - pnlGargamella.Width)
				{
					gargamella.x = pnlCittà.Width - pnlGargamella.Width;
				}
				if (gargamella.y > pnlCittà.Height - pnlGargamella.Height)
				{
					gargamella.y = pnlCittà.Height - pnlGargamella.Height;
				}

				pnlGargamella.Location = new Point(gargamella.x, gargamella.y);
			}

			if (CollisioneCasetta())
			{
				cP++;
				lblPunteggioP.Text = $"Punteggio Puffo: {cP}";
				casetta.x = rand.Next(0, pnlCittà.Width - pnlCasetta.Width);
				casetta.y = rand.Next(0, pnlCittà.Height - pnlCasetta.Height);
				pnlCasetta.Location = new Point(casetta.x, casetta.y);
				for (int k = 0; k < 10; k++)
				{
					alberi[k].x = rand.Next(0, pnlCittà.Width - panels[k].Width);
					alberi[k].y = rand.Next(0, pnlCittà.Height - panels[k].Height);
					panels[k].Location = new Point(alberi[k].x, alberi[k].y);
				}
			}

			if (CollisionePuffo())
			{
				cG++;
				lblPunteggioG.Text = $"Punteggio Gargamella: {cG}";
				puffo.x = rand.Next(0, pnlCittà.Width - pnlPuffo.Width);
				puffo.y = rand.Next(0, pnlCittà.Height - pnlPuffo.Height);
				pnlPuffo.Location = new Point(puffo.x, puffo.y);
			}

			if (CollisioneAlbero())
			{
				TurnoPuffo = !TurnoPuffo;
				movement = 0;
			}

			movement++;

			if (movement > 11)
			{
				TurnoPuffo = !TurnoPuffo;
				movement = 0;
			}
		}

		public bool CollisioneCasetta()
		{
			if (puffo.x < casetta.x + pnlCasetta.Width && puffo.x + pnlPuffo.Width > casetta.x && puffo.y < casetta.y + pnlCasetta.Height && puffo.y + pnlPuffo.Height > casetta.y)
			{
				return true;
			}
			return false;
		}
		public bool CollisionePuffo()
		{
			if (gargamella.x < puffo.x + pnlPuffo.Width && gargamella.x + pnlGargamella.Width > puffo.x && gargamella.y < puffo.y + pnlPuffo.Height && gargamella.y + pnlGargamella.Height > puffo.y)
			{
				return true;
			}
			return false;
		}

		public bool CollisioneAlbero()
		{
			for (int j = 0; j < panels.Length; j++)
			{
				if ((puffo.x < alberi[j].x + panels[j].Width && puffo.x + pnlPuffo.Width > alberi[j].x && puffo.y < alberi[j].y + panels[j].Height && puffo.y + pnlPuffo.Height > alberi[j].y) || (gargamella.x < alberi[j].x + panels[j].Width && gargamella.x + pnlGargamella.Width > alberi[j].x && gargamella.y < alberi[j].y + panels[j].Height && gargamella.y + pnlGargamella.Height > alberi[j].y))
				{
					return true;
				}
			}
			return false;
		}
	}
}