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
		Punto puffo = new Punto();
		Punto casetta = new Punto();
		Random rand = new Random();
		int c = 0;

		public Form1()
		{
			InitializeComponent();
			puffo.x = 0;
			puffo.y = 0;
			casetta.x = rand.Next(0, pnlCittà.Width - pnlCasetta.Width);
			casetta.y = rand.Next(0, pnlCittà.Height - pnlCasetta.Height);
			pnlPuffo.Location = new Point(puffo.x, puffo.y);
			pnlCasetta.Location = new Point(casetta.x, casetta.y);
			lblPunteggio.Text = $"Punteggio: {c}";
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
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

			if (Collisione())
			{
				c++;
				lblPunteggio.Text = $"Punteggio: {c}";
				casetta.x = rand.Next(0, pnlCittà.Width - pnlCasetta.Width);
				casetta.y = rand.Next(0, pnlCittà.Height - pnlCasetta.Height);
				pnlCasetta.Location = new Point(casetta.x, casetta.y);
			}
		}

		private bool Collisione()
		{
			if (puffo.x < casetta.x + pnlCasetta.Width && puffo.x + pnlPuffo.Width > casetta.x && puffo.y < casetta.y + pnlCasetta.Height && puffo.y + pnlPuffo.Height > casetta.y)
			{
				return true;
			}
			return false;
		}
	}
}
