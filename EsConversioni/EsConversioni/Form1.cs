using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsConversioni
{
	public partial class Form1 : Form
	{
		double input, input2;
		double output, output2;
		string selezione, selezione2;

		bool control;
		public Form1()
		{
			InitializeComponent();
		}
		
		private void btnConverti_Click(object sender, EventArgs e)
		{
			if (cmbSelezione.SelectedItem == null)
			{
				txtOutput.Text = "Seleziona una conversione da eseguire";
			}
			selezione = cmbSelezione.SelectedItem.ToString();
			control = double.TryParse(txtInput.Text, out input);
			if (control)
			{
				if (selezione != null)
				{
					if (selezione == "Celsius")
					{
						output = (input - 32) * 5 / 9;
						txtOutput.Text = output.ToString();
					}
					else if (selezione == "Fahrenheit")
					{
						output = (input * 9 / 5) + 32;
						txtOutput.Text = output.ToString();
					}
				}
				else
				{
					txtOutput.Text = "Seleziona una conversione da eseguire";
				}
			}
			else
			{
				txtOutput.Text = "Inserisci un numero valido da convertire";
			}

			if (cmbConverti2.SelectedItem == null)
			{
				txtOutput2.Text = "Seleziona una conversione da eseguire";
			}
			selezione2 = cmbConverti2.SelectedItem.ToString();
			control = double.TryParse(txtInput2.Text, out input2);
			if (control)
			{
				if (selezione2 != null)
				{
					if (selezione2 == "Kilometri")
					{
						output2 = input2 * 1.60934;
						txtOutput2.Text = output2.ToString();
					}
					else if (selezione2 == "Miglia")
					{
						output2 = input2 / 1.60934;
						txtOutput2.Text = output2.ToString();
					}
				}
				else
				{
					txtOutput.Text = "Seleziona una conversione da eseguire";
				}
			}
			else
			{
				txtOutput.Text = "Inserisci un numero valido da convertire";
			}
		}
	}
}
