namespace EsElencoAttività
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
			this.lstAttività = new System.Windows.Forms.ListBox();
			this.btnAggiunta = new System.Windows.Forms.Button();
			this.txtDaFare = new System.Windows.Forms.TextBox();
			this.lblAttività = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstAttività
			// 
			this.lstAttività.FormattingEnabled = true;
			this.lstAttività.ItemHeight = 16;
			this.lstAttività.Location = new System.Drawing.Point(12, 12);
			this.lstAttività.Name = "lstAttività";
			this.lstAttività.Size = new System.Drawing.Size(312, 420);
			this.lstAttività.TabIndex = 0;
			// 
			// btnAggiunta
			// 
			this.btnAggiunta.Location = new System.Drawing.Point(504, 191);
			this.btnAggiunta.Name = "btnAggiunta";
			this.btnAggiunta.Size = new System.Drawing.Size(100, 75);
			this.btnAggiunta.TabIndex = 1;
			this.btnAggiunta.Text = "Aggiungi attività";
			this.btnAggiunta.UseVisualStyleBackColor = true;
			this.btnAggiunta.Click += new System.EventHandler(this.btnAggiunta_Click);
			// 
			// txtDaFare
			// 
			this.txtDaFare.Location = new System.Drawing.Point(485, 125);
			this.txtDaFare.Multiline = true;
			this.txtDaFare.Name = "txtDaFare";
			this.txtDaFare.Size = new System.Drawing.Size(141, 36);
			this.txtDaFare.TabIndex = 2;
			// 
			// lblAttività
			// 
			this.lblAttività.Location = new System.Drawing.Point(485, 90);
			this.lblAttività.Name = "lblAttività";
			this.lblAttività.Size = new System.Drawing.Size(141, 32);
			this.lblAttività.TabIndex = 3;
			this.lblAttività.Text = "Inserire un\'attività:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAttività);
			this.Controls.Add(this.txtDaFare);
			this.Controls.Add(this.btnAggiunta);
			this.Controls.Add(this.lstAttività);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstAttività;
		private System.Windows.Forms.Button btnAggiunta;
		private System.Windows.Forms.TextBox txtDaFare;
		private System.Windows.Forms.Label lblAttività;
	}
}

