namespace EsPuffiFanCosì
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
			this.pnlCittà = new System.Windows.Forms.Panel();
			this.pnlCasetta = new System.Windows.Forms.Panel();
			this.pnlPuffo = new System.Windows.Forms.Panel();
			this.lblPunteggio = new System.Windows.Forms.Label();
			this.pnlCittà.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCittà
			// 
			this.pnlCittà.Controls.Add(this.pnlCasetta);
			this.pnlCittà.Controls.Add(this.pnlPuffo);
			this.pnlCittà.Controls.Add(this.lblPunteggio);
			this.pnlCittà.Location = new System.Drawing.Point(12, 12);
			this.pnlCittà.Name = "pnlCittà";
			this.pnlCittà.Size = new System.Drawing.Size(1089, 685);
			this.pnlCittà.TabIndex = 0;
			// 
			// pnlCasetta
			// 
			this.pnlCasetta.BackColor = System.Drawing.Color.Red;
			this.pnlCasetta.Location = new System.Drawing.Point(295, 240);
			this.pnlCasetta.Name = "pnlCasetta";
			this.pnlCasetta.Size = new System.Drawing.Size(52, 60);
			this.pnlCasetta.TabIndex = 1;
			// 
			// pnlPuffo
			// 
			this.pnlPuffo.BackColor = System.Drawing.Color.Blue;
			this.pnlPuffo.Location = new System.Drawing.Point(736, 172);
			this.pnlPuffo.Name = "pnlPuffo";
			this.pnlPuffo.Size = new System.Drawing.Size(52, 60);
			this.pnlPuffo.TabIndex = 0;
			// 
			// lblPunteggio
			// 
			this.lblPunteggio.BackColor = System.Drawing.SystemColors.Control;
			this.lblPunteggio.Location = new System.Drawing.Point(0, 0);
			this.lblPunteggio.Name = "lblPunteggio";
			this.lblPunteggio.Size = new System.Drawing.Size(124, 24);
			this.lblPunteggio.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 709);
			this.Controls.Add(this.pnlCittà);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.pnlCittà.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCittà;
		private System.Windows.Forms.Panel pnlPuffo;
		private System.Windows.Forms.Panel pnlCasetta;
		private System.Windows.Forms.Label lblPunteggio;
	}
}

