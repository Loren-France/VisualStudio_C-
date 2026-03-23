using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esBiblioteca
{
	public partial class Form2 : Form
	{
		public Form2(List<Libro> libri, bool Filtraggio, Genere Filtra1, string Filtra2)
		{
			InitializeComponent();

			lstFiltrata.Items.Clear();

			if (Filtraggio)
			{
				for (int i = 0; i < libri.Count; i++)
				{
					if (libri[i].tipo == Filtra1)
					{
						lstFiltrata.Items.Add(libri[i].Stampa());
					}
				}
			}
			else
			{
				for (int i = 0; i < libri.Count; i++)
				{
					if (libri[i].autore == Filtra2)
					{
						lstFiltrata.Items.Add(libri[i].Stampa());
					}
				}
			}

			if (lstFiltrata.Items.Count == 0)
			{
				MessageBox.Show("Nessun libro trovato con questo autore");
			}
		}
	}
}
