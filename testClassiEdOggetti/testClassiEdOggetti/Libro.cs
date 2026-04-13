using System;
using System.Collections.Generic;
using System.Text;

namespace testClassiEdOggetti
{
	internal class Libro
	{
		//Attributi
		private string titolo;
		private Autore autore;
		private int anno;
		private int pagine;

		//Costruttore
		public Libro(string titolo, Autore autore, int anno, int pagine)
		{
			this.titolo = titolo;
			this.anno = anno;
			this.pagine = pagine;
			this.autore = autore;
		}

		public string Info()
		{
			return $"{this.titolo} di {this.autore.NomeCompleto()} (Anno {this.anno}, Pagine {this.pagine})";
		}

        public string Titolo() 
	    { 
			return this.titolo;
		}

		public int Anno() 
		{
			return this.anno;
		}
		public int Pagine() 
		{
			return this.pagine;
		}
	}
}
