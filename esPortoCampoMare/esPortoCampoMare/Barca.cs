using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace esPortoCampoMare
{
	public enum Tipologia
	{
		Container,
		Rinfuse,
		Passeggeri
	}

	internal class Barca
	{

		private string nome;
		private string capitano;
		private int nequipaggio;
		private int carico;
		private Tipologia tipocarico;

		public Barca(string nome, string capitano, int nequipaggio, int carico, Tipologia tipocarico)
		{
			this.nome = nome;
			this.capitano = capitano;
			this.nequipaggio = nequipaggio;
			this.carico = carico;
			this.tipocarico = tipocarico;
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string Capitano
		{
			get { return capitano; }
			set { capitano = value; }
		}

		public int Carico
		{
			get { return carico; }
			set { carico = value; }
		}

		public int Nequipaggio
		{
			get { return nequipaggio; }
			set { nequipaggio = value; }
		}

		public Tipologia Tipocarico
		{
			get { return tipocarico; }
			set { tipocarico = value; }
		}

	}
}
