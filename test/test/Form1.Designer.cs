namespace test
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
			this.btnSaluta = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSaluta
			// 
			this.btnSaluta.Location = new System.Drawing.Point(12, 12);
			this.btnSaluta.Name = "btnSaluta";
			this.btnSaluta.Size = new System.Drawing.Size(265, 195);
			this.btnSaluta.TabIndex = 0;
			this.btnSaluta.Text = "Ciao";
			this.btnSaluta.UseVisualStyleBackColor = true;
			this.btnSaluta.Click += new System.EventHandler(this.btnSaluta_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(362, 141);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(146, 22);
			this.txtNome.TabIndex = 1;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(359, 121);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(124, 17);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Inserisci nome:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnSaluta);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaluta;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
	}
}

