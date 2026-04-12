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
			return $"Cognome: {this.cognome}, Nome: {this.nome}, Sesso: {this.sesso}, Data di Nascita: {this.dataNascita}, Libri: {string.Join(",", libri)}";
		}

		public int Aggiungi (Libro nuovo)
		{	
			this.libri.Add(nuovo);
			return this.libri.Count;
		}
	}
}
