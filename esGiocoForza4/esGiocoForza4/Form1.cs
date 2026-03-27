using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esGiocoForza4
{
	public partial class Form1 : Form
	{
		public int righe;
		public int colonne;
		public int[,] matrice;
		public bool giocatore;
		public bool vittoria;

		public Form1()
		{
			InitializeComponent();
			colonne = 7;
			righe = 6;
			giocatore = true;
			vittoria = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvGriglia.RowHeadersVisible = false;
			dgvGriglia.ColumnHeadersVisible = false;

			dgvGriglia.SelectionMode = DataGridViewSelectionMode.CellSelect;

			dgvGriglia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dgvGriglia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

			dgvGriglia.RowCount = righe;
			dgvGriglia.ColumnCount = colonne;

			for (int i = 0; i < righe; i++)
			{
				dgvGriglia.Rows[i].Height = 77;
			}

			dgvGriglia.ClearSelection();

			lblTurno.Text = "Turno: GIALLO";
			lblTurno.ForeColor = Color.Yellow;
		}


		private void dgvGriglia_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = e.RowIndex;
			int c = e.ColumnIndex;

			if (dgvGriglia.Rows[r].Cells[c].Style.BackColor != Color.Yellow && dgvGriglia.Rows[r].Cells[c].Style.BackColor != Color.Red)
			{
				if (r != righe - 1)
				{
					if (dgvGriglia.Rows[r + 1].Cells[c].Style.BackColor != Color.Red && dgvGriglia.Rows[r + 1].Cells[c].Style.BackColor != Color.Yellow)
					{
						MessageBox.Show("Posizione non disponibile");
						return;
					}
				}

				giocatore = !giocatore;

				if (giocatore)
				{
					dgvGriglia.Rows[r].Cells[c].Style.BackColor = Color.Red;
					lblTurno.Text = "Turno: GIALLO";
					lblTurno.ForeColor = Color.Yellow;
				}
				else
				{
					dgvGriglia.Rows[r].Cells[c].Style.BackColor = Color.Yellow;
					lblTurno.Text = "Turno: ROSSO";
					lblTurno.ForeColor = Color.Red;
				}

				dgvGriglia.ClearSelection();

				ControlloVittoria();
			}
			else
			{
				MessageBox.Show("Cella gia occupata");
				return;
			}
		}

		private void ControlloVittoria()
		{
			//Orizzontale
			for (int r = 0; r < righe; r++)
			{
				for (int c = 0; c < colonne - 3; c++)
				{
					Color a = dgvGriglia.Rows[r].Cells[c].Style.BackColor;
					if (a != Color.Red && a != Color.Yellow)
					continue;

					if (dgvGriglia.Rows[r].Cells[c + 1].Style.BackColor == a &&
						dgvGriglia.Rows[r].Cells[c + 2].Style.BackColor == a &&
						dgvGriglia.Rows[r].Cells[c + 3].Style.BackColor == a)
					{
						Vittoria(a);
						return;
					}
				}
			}
			//Verticale
			for (int r = 0; r < righe - 3; r++)
			{
				for (int c = 0; c < colonne; c++)
				{
					Color a = dgvGriglia.Rows[r].Cells[c].Style.BackColor;
					if (a != Color.Red && a != Color.Yellow)
					continue;

					if (dgvGriglia.Rows[r + 1].Cells[c].Style.BackColor == a &&
						dgvGriglia.Rows[r + 2].Cells[c].Style.BackColor == a &&
						dgvGriglia.Rows[r + 3].Cells[c].Style.BackColor == a)
					{
						Vittoria(a);
						return;
					}
				}
			}
			//Obliquo da alto a basso
			for (int r = 0; r < righe - 3; r++)
			{
				for (int c = 0; c < colonne - 3; c++)
				{
					Color a = dgvGriglia.Rows[r].Cells[c].Style.BackColor;
					if (a != Color.Red && a != Color.Yellow)
					continue;

					if (dgvGriglia.Rows[r + 1].Cells[c + 1].Style.BackColor == a &&
						dgvGriglia.Rows[r + 2].Cells[c + 2].Style.BackColor == a &&
						dgvGriglia.Rows[r + 3].Cells[c + 3].Style.BackColor == a)
					{
						Vittoria(a);
						return;
					}
				}
			}
			// Obliquo da basso ad alto
			for (int r = 3; r < righe; r++)
			{
				for (int c = 0; c < colonne - 3; c++)
				{
					Color a = dgvGriglia.Rows[r].Cells[c].Style.BackColor;
					if (a != Color.Red && a != Color.Yellow)
					continue;

					if (dgvGriglia.Rows[r - 1].Cells[c + 1].Style.BackColor == a &&
						dgvGriglia.Rows[r - 2].Cells[c + 2].Style.BackColor == a &&
						dgvGriglia.Rows[r - 3].Cells[c + 3].Style.BackColor == a)
					{
						Vittoria(a);
						return;
					}
				}
			}
		}
		private void Vittoria(Color colore)
		{
			string nome = colore == Color.Red ? "ROSSO"
				: "GIALLO";
			MessageBox.Show("Ha vinto: " + nome);
			vittoria = true;
			dgvGriglia.Enabled = false;
		}
	}
}
