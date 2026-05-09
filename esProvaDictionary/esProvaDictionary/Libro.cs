using System;
using System.Collections.Generic;
using System.Text;

namespace esProvaDictionary
{
	internal class Libro
	{

		private string titolo;
		private string autore;
		private int anno;

		public Libro(string titolo, string autore, int anno)
		{
			this.titolo = titolo;
			this.autore = autore;
			this.anno = anno;
		}

		public string Titolo
		{
			get { return titolo; }
			set { titolo = value; }
		}

		public string Autore
		{
			get { return autore; }
		}

		public int Anno
		{
			get { return anno; }
		}

		public string ToString()
		{
			return $"Titolo: {titolo} (Autore: {autore}, Anno: {anno})";
		}
	}
}
