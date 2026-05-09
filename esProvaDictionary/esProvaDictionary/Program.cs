using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using static System.Console;

namespace esProvaDictionary
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();
			int action = 0;

			WriteLine("PROGRAMMA CHE GESTISCE UNA PICCOLA BIBLIOTECA CON UN DICTIONARY");

			WriteLine("Creazione dei 5 libri...");

			Libro book1 = new Libro("Il Signore degli Anelli", "J.R.R. Tolkien", 1954);
			Libro book2 = new Libro("Harry Potter e la Pietra Filosofale", "J.K. Rowling", 1997);
			Libro book3 = new Libro("Il Codice Da Vinci", "Dan Brown", 2003);
			Libro book4 = new Libro("1984", "George Orwell", 1949);
			Libro book5 = new Libro("Il Grande Gatsby", "F. Scott Fitzgerald", 1925);

			biblioteca.Add("9788845299193", book1);
			biblioteca.Add("9788871321234", book2);
			biblioteca.Add("9788882223334", book3);
			biblioteca.Add("9788893334445", book4);
			biblioteca.Add("9788804445556", book5);

			WriteLine("Stampa dei libri in biblioteca...");

			Stampa(biblioteca);

			while (action != 5)
			{
				do
				{
					WriteLine("Azioni possibili: ");
					WriteLine("1. Aggiungi un libro");
					WriteLine("2. Modifica titolo di un libro");
					WriteLine("3. Rimuovi un libro");
					WriteLine("4. Stampa i libri in biblioteca");
					WriteLine("5. Esci");
					Write("Inserire l'azione da eseguire: ");

					action = int.Parse(ReadLine());

					if (action <= 0 || action > 5)
					{
						WriteLine("Azione non valida, reinserire.");
					}

				}

				while (action <= 0 || action > 5);

				switch (action)
				{
					case 1:
						WriteLine("Aggiunta di un libro...");
						AggiuntaLibro(biblioteca);
						break;
					case 2:
						WriteLine("Modifica titolo di un libro...");
						ModificaTitolo(biblioteca);
						break;
					case 3:
						WriteLine("Rimozione di un libro...");
						RimuoviLibro(biblioteca);
						break;
					case 4:
						WriteLine("Stampa dei libri in biblioteca...");
						Stampa(biblioteca);
						break;
					case 5:
						WriteLine("Uscita dal programma...");
						break;
					default:
						WriteLine("Caso impossibile!");
						break;
				}
			}
			return;

		}

		static void Stampa(Dictionary<string, Libro> biblioteca)
		{
			foreach (var i in biblioteca)
			{
				WriteLine($"Libro {i.Key} => {i.Value.ToString()}");
			}
		}

		static void AggiuntaLibro(Dictionary<string, Libro> biblioteca)
		{
			try
			{
				Write("Inserire ISBN: ");
				string isbn = ReadLine();
				Write("Inserire titolo: ");
				string titolo = ReadLine();
				Write("Inserire autore: ");
				string autore = ReadLine();
				Write("Inserire anno: ");
				int anno = int.Parse(ReadLine());
				Libro newBook = new Libro(titolo, autore, anno);
				biblioteca.Add(isbn, newBook);
				WriteLine("Libro Aggiunto");
			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
		}

		static void ModificaTitolo(Dictionary<string, Libro> biblioteca)
		{
			WriteLine("Inserire ISBN del libro da modificare: ");
			string isbn = ReadLine();
			if (biblioteca.ContainsKey(isbn))
			{
				Write("Inserire nuovo titolo: ");
				string nuovot = ReadLine();
				Libro modifiedBook = biblioteca[isbn];
				modifiedBook.Titolo = nuovot;
				biblioteca[isbn] = modifiedBook;
				WriteLine("Titolo modificato");
			}
			else
			{
				WriteLine("ISBN non trovato.");
			}
			return;
		}

		static void RimuoviLibro(Dictionary<string, Libro> biblioteca)
		{
			WriteLine("Inserire ISBN del libro da rimuovere: ");
			string isbn = ReadLine();
			if (biblioteca.ContainsKey(isbn))
			{
				biblioteca.Remove(isbn);
				WriteLine("Libro rimosso");
			}
			else
			{
				WriteLine("ISBN non trovato.");
			}
			return;
		}
	}
}
