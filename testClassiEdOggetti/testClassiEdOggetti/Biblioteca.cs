using System;
using System.Collections.Generic;
using System.Text;

namespace testClassiEdOggetti
{
	internal class Biblioteca
	{
		private string nome;
		private List<Autore> autori;
		private List<Libro> libri;

		public Biblioteca(string nome)
		{
			this.nome = nome;
			this.autori = new List<Autore> { };
			this.libri = new List<Libro> { };
		}

		public string ToString()
		{
			string stampaa = string.Join(",", this.autori);

			return $"Biblioteca: {this.nome}, Autori: {string.Join(",", autori)}, Libri: {string.Join(",", libri)}";
		}

		public int AggiungiAutore(Autore nuovo)
		{
			this.autori.Add(nuovo);
			return this.autori.Count;
		}

		public int AggiungiLibro(Libro nuovo)
		{
			this.libri.Add(nuovo);
			return this.libri.Count;
		}
		public List<Autore> ElencoAutori()
		{
			return this.autori;
		}

		public List<Libro> ElencoLibri()
		{
			return this.libri;
		}

		public string Nome()
		{
  			return this.nome;
		}
	}
}
