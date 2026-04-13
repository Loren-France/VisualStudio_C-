using System;
using System.Collections.Generic;
using System.Text;

namespace testClassiEdOggetti
{
	internal class Autore
	{
		private string cognome, nome, sesso;
		private int dataNascita;
		private List<Libro> libri;

		public Autore(string cognome, string nome, string sesso, int dataNascita)
		{
			this.cognome = cognome;
			this.nome = nome;
			this.sesso = sesso;
			this.dataNascita = dataNascita;
			this.libri = new List<Libro> { };
		}

		public string Info()
		{
           return $"Cognome: {this.cognome}, Nome: {this.nome}, Sesso: {this.sesso}, Data di Nascita: {this.dataNascita}, Libri: {string.Join(", ", libri.ConvertAll(l => l.Info()))}";
		}

		public int Aggiungi (Libro nuovo)
		{	
			this.libri.Add(nuovo);
			return this.libri.Count;
		}

        public List<Libro> LibriPubblicati() { return this.libri; }
		public string NomeCompleto() { return this.nome + " " + this.cognome; }

		public int DataNascita() { return this.dataNascita; }
	}
}
