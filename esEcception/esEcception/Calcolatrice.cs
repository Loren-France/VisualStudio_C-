using System;
using System.Collections.Generic;
using System.Text;

namespace esEcception
{
	internal class Calcolatrice
	{
		private double a;
		private double b;

		public Calcolatrice(double a, double b)
		{
			this.a = a;
			this.b = b;
		}

		public double Dividi(int a, int b)
		{
			try
			{
				if (a < 0 || b < 0)
				{
					throw new ArgumentException();
				}
				return a / b;
			}
			catch (DivideByZeroException z)
			{
				Console.WriteLine(z.Message);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
			catch
			{
				Console.WriteLine("Errore generico");
			}
			finally 
			{
				Console.WriteLine("Operazione terminata");
			}
			return 0;
		}
	}
}
