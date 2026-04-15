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
          string s = "Biblioteca: " + this.nome + "\nAutori:\n";
			foreach (Autore a in autori)
				s += "- " + a.NomeCompleto() + "\n";
			s += "Libri:\n";
			foreach (Libro l in libri)
				s += "- " + l.Info() + "\n";
			return s;
		}

		public int AggiungiAutore(Autore nuovo)
		{
			this.autori.Add(nuovo);
			foreach (Libro l in nuovo.LibriPubblicati())
			 this.libri.Add(l);
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

        public List<Autore> AutoriInAnno(int anno)
		{
		   List<Autore> risultato = new List<Autore>();
		   foreach (Autore a in this.autori)
		   {
			  if (a.DataNascita() == anno)
				{
					risultato.Add(a);
				}
		   }
		   return risultato;
		}

        public List<Libro> LibriInAnno(int anno)
		{
		   List<Libro> risultato = new List<Libro>();
		   foreach (Libro l in this.libri)
		   {
				if (l.Anno() == anno)
				{
					risultato.Add(l);
				}
		   }
		   return risultato;
		}

		public int TotalePagine()
		{
			int sum = 0;
			foreach (Libro l in this.libri)
				sum += l.Pagine();
			return sum;
		}

		public string Nome()
		{
  			return this.nome;
		}
	}
}
