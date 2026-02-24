using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EsElencoAttività
{
	public partial class Form1 : Form
	{
		string activity;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAggiunta_Click(object sender, EventArgs e)
		{
			activity = txtDaFare.Text;

			if (activity != "" || activity != null)
			{
				lstAttività.Items.Add(activity);
				txtDaFare.Clear();
			}
			else
			{
				txtDaFare.Text = "Inserire un'attività da fare";
			}
		}
	}
}
