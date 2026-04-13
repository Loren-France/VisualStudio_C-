using testClassiEdOggetti;

Autore orwell = new Autore("Orwell", "George", "M", 1903);

Autore yourcenar = new Autore("Yourcenar", "Marguerite", "F", 1903);

Libro lib1984 = new Libro("1984", orwell, 1949, 328);

orwell.Aggiungi(lib1984);

Biblioteca biblio = new Biblioteca("ITIS Rossi");
biblio.AggiungiAutore(orwell);
biblio.AggiungiAutore(yourcenar);

Console.WriteLine($"{biblio.Nome()}\nElenco Autori:");
foreach (Autore autore in biblio.ElencoAutori())
  Console.WriteLine($"- {autore.Info()}\n libri presenti: {autore.LibriPubblicati().Count}");

int idx = 0;
Console.WriteLine("Elenco Libri:");
foreach (Libro liber in biblio.ElencoLibri())
	Console.WriteLine($"{++idx}. {liber.Info()}");