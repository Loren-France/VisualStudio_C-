namespace esOperatoreSIMForm
{
	partial class Form1
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblSIM = new System.Windows.Forms.Label();
			this.lstTelefonate = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtDurata = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAggiungi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSIM
			// 
			this.lblSIM.AutoSize = true;
			this.lblSIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSIM.Location = new System.Drawing.Point(33, 9);
			this.lblSIM.Name = "lblSIM";
			this.lblSIM.Size = new System.Drawing.Size(72, 29);
			this.lblSIM.TabIndex = 0;
			this.lblSIM.Text = "SIM: ";
			// 
			// lstTelefonate
			// 
			this.lstTelefonate.FormattingEnabled = true;
			this.lstTelefonate.ItemHeight = 16;
			this.lstTelefonate.Location = new System.Drawing.Point(38, 71);
			this.lstTelefonate.Name = "lstTelefonate";
			this.lstTelefonate.Size = new System.Drawing.Size(385, 308);
			this.lstTelefonate.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(450, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Inserire numero telefonato: ";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(453, 121);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(184, 22);
			this.txtNumero.TabIndex = 4;
			// 
			// txtDurata
			// 
			this.txtDurata.Location = new System.Drawing.Point(453, 202);
			this.txtDurata.Name = "txtDurata";
			this.txtDurata.Size = new System.Drawing.Size(184, 22);
			this.txtDurata.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(450, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Inserire durata della telefonata: ";
			// 
			// btnAggiungi
			// 
			this.btnAggiungi.Location = new System.Drawing.Point(453, 265);
			this.btnAggiungi.Name = "btnAggiungi";
			this.btnAggiungi.Size = new System.Drawing.Size(154, 67);
			this.btnAggiungi.TabIndex = 7;
			this.btnAggiungi.Text = "Aggiungi telefonata";
			this.btnAggiungi.UseVisualStyleBackColor = true;
			this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAggiungi);
			this.Controls.Add(this.txtDurata);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstTelefonate);
			this.Controls.Add(this.lblSIM);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSIM;
		private System.Windows.Forms.ListBox lstTelefonate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtDurata;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAggiungi;
	}
}

