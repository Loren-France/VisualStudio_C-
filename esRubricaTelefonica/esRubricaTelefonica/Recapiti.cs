using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace esRubricaTelefonica
{
	internal class Recapiti
	{
		private string numero;

		private MailAddress email;

		private DateTime dataCompleanno;

		public Recapiti(string numero, MailAddress email, DateTime dataCompleanno)
		{
			this.numero = numero;
			this.email = email;
			this.dataCompleanno = dataCompleanno;
		}

		public string ToString()
		{
			return $"Numero: {numero}, Email: {email.Address}, Data di compleanno: {dataCompleanno.ToShortDateString()}";
		}

		public string Numero {
			get { return numero; }
			set 
			{
				numero = value;
				if (numero.Length <= 7 || numero.Length > 11)
				{
					throw new ArgumentException("Il numero deve essere di 10 cifre");
				}
			}
		}

		public MailAddress Email {
			get { return email; }
			set 
			{
				email = value;
				if (!email.Address.Contains("@"))
				{
					throw new ArgumentException("L'indirizzo email deve contenere '@'");
				}
				else if (!email.Address.Contains("."))
				{
					throw new ArgumentException("L'indirizzo email deve contenere '.'");
				}
				else if (email.Address.Length < 16 || email.Address.Length > 254)
				{
					throw new ArgumentException("L'indirizzo email deve essere compreso tra 16 e 254 caratteri");
				}

			}
		}

		public DateTime DataCompleanno {
			get { return dataCompleanno; }
			set
			{
				dataCompleanno = value;
				if (dataCompleanno > DateTime.Now)
				{
					throw new ArgumentException("La data di compleanno non può essere futura");
				}
			}
		}

	}
}
