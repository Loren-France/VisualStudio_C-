namespace esPortoCampoMare
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
			this.Titolo = new System.Windows.Forms.Label();
			this.lstBarche = new System.Windows.Forms.ListBox();
			this.txtCarico = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGestisciPartenza = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Titolo
			// 
			this.Titolo.AutoSize = true;
			this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titolo.Location = new System.Drawing.Point(235, 9);
			this.Titolo.Name = "Titolo";
			this.Titolo.Size = new System.Drawing.Size(462, 38);
			this.Titolo.TabIndex = 0;
			this.Titolo.Text = "Gestione porto di Capo Mare";
			// 
			// lstBarche
			// 
			this.lstBarche.FormattingEnabled = true;
			this.lstBarche.ItemHeight = 16;
			this.lstBarche.Location = new System.Drawing.Point(12, 67);
			this.lstBarche.Name = "lstBarche";
			this.lstBarche.Size = new System.Drawing.Size(543, 260);
			this.lstBarche.TabIndex = 1;
			// 
			// txtCarico
			// 
			this.txtCarico.Location = new System.Drawing.Point(647, 111);
			this.txtCarico.Name = "txtCarico";
			this.txtCarico.Size = new System.Drawing.Size(180, 22);
			this.txtCarico.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(644, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Inserire i carichi da far partire: ";
			// 
			// btnGestisciPartenza
			// 
			this.btnGestisciPartenza.Location = new System.Drawing.Point(673, 139);
			this.btnGestisciPartenza.Name = "btnGestisciPartenza";
			this.btnGestisciPartenza.Size = new System.Drawing.Size(128, 52);
			this.btnGestisciPartenza.TabIndex = 4;
			this.btnGestisciPartenza.Text = "Fai partire";
			this.btnGestisciPartenza.UseVisualStyleBackColor = true;
			this.btnGestisciPartenza.Click += new System.EventHandler(this.btnGestisciPartenza_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 511);
			this.Controls.Add(this.btnGestisciPartenza);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCarico);
			this.Controls.Add(this.lstBarche);
			this.Controls.Add(this.Titolo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Titolo;
		private System.Windows.Forms.ListBox lstBarche;
		private System.Windows.Forms.TextBox txtCarico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGestisciPartenza;
	}
}

