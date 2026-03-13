namespace esSport
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
			this.txtMinuti = new System.Windows.Forms.TextBox();
			this.lstRegistro = new System.Windows.Forms.ListBox();
			this.lblMInuti = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblLuogo = new System.Windows.Forms.Label();
			this.txtLuogo = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.btnAggiungi = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMinuti
			// 
			this.txtMinuti.Location = new System.Drawing.Point(27, 28);
			this.txtMinuti.Name = "txtMinuti";
			this.txtMinuti.Size = new System.Drawing.Size(199, 22);
			this.txtMinuti.TabIndex = 0;
			this.txtMinuti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuti_KeyPress);
			// 
			// lstRegistro
			// 
			this.lstRegistro.FormattingEnabled = true;
			this.lstRegistro.ItemHeight = 16;
			this.lstRegistro.Location = new System.Drawing.Point(27, 210);
			this.lstRegistro.Name = "lstRegistro";
			this.lstRegistro.Size = new System.Drawing.Size(366, 228);
			this.lstRegistro.TabIndex = 3;
			// 
			// lblMInuti
			// 
			this.lblMInuti.AutoSize = true;
			this.lblMInuti.Location = new System.Drawing.Point(24, 9);
			this.lblMInuti.Name = "lblMInuti";
			this.lblMInuti.Size = new System.Drawing.Size(188, 16);
			this.lblMInuti.TabIndex = 4;
			this.lblMInuti.Text = "Inserire i minuti di allenamento:";
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(24, 69);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(179, 16);
			this.lblTipo.TabIndex = 6;
			this.lblTipo.Text = "Inserire il tipo di allenamento:\r\n";
			// 
			// lblLuogo
			// 
			this.lblLuogo.AutoSize = true;
			this.lblLuogo.Location = new System.Drawing.Point(24, 136);
			this.lblLuogo.Name = "lblLuogo";
			this.lblLuogo.Size = new System.Drawing.Size(202, 16);
			this.lblLuogo.TabIndex = 8;
			this.lblLuogo.Text = "Inserire il luogo dell\'allenamento:";
			// 
			// txtLuogo
			// 
			this.txtLuogo.Location = new System.Drawing.Point(27, 155);
			this.txtLuogo.Name = "txtLuogo";
			this.txtLuogo.Size = new System.Drawing.Size(199, 22);
			this.txtLuogo.TabIndex = 7;
			this.txtLuogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuogo_KeyPress);
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(27, 88);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(199, 24);
			this.cmbTipo.TabIndex = 9;
			// 
			// btnAggiungi
			// 
			this.btnAggiungi.Location = new System.Drawing.Point(271, 9);
			this.btnAggiungi.Name = "btnAggiungi";
			this.btnAggiungi.Size = new System.Drawing.Size(122, 58);
			this.btnAggiungi.TabIndex = 10;
			this.btnAggiungi.Text = "Aggiungi allenamento";
			this.btnAggiungi.UseVisualStyleBackColor = true;
			this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(416, 9);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(372, 429);
			this.txtOutput.TabIndex = 11;
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(271, 94);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(122, 58);
			this.btnFile.TabIndex = 12;
			this.btnFile.Text = "Salva in un file";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnAggiungi);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.lblLuogo);
			this.Controls.Add(this.txtLuogo);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblMInuti);
			this.Controls.Add(this.lstRegistro);
			this.Controls.Add(this.txtMinuti);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMinuti;
		private System.Windows.Forms.ListBox lstRegistro;
		private System.Windows.Forms.Label lblMInuti;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblLuogo;
		private System.Windows.Forms.TextBox txtLuogo;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button btnAggiungi;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnFile;
	}
}

