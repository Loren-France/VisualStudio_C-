namespace esFantasiaPark
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lblTitoloProgramma = new System.Windows.Forms.Label();
			this.lblDescrizione = new System.Windows.Forms.Label();
			this.btnGestioneBiglietti = new System.Windows.Forms.Button();
			this.btnGestioneGiostre = new System.Windows.Forms.Button();
			this.btnGestioneAttrazioni = new System.Windows.Forms.Button();
			this.btnChiusura = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lblTitolo.Location = new System.Drawing.Point(347, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(210, 36);
			this.lblTitolo.TabIndex = 0;
			this.lblTitolo.Text = "Fantasia Park";
			this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitoloProgramma
			// 
			this.lblTitoloProgramma.AutoSize = true;
			this.lblTitoloProgramma.BackColor = System.Drawing.Color.Transparent;
			this.lblTitoloProgramma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitoloProgramma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.lblTitoloProgramma.Location = new System.Drawing.Point(311, 45);
			this.lblTitoloProgramma.Name = "lblTitoloProgramma";
			this.lblTitoloProgramma.Size = new System.Drawing.Size(282, 25);
			this.lblTitoloProgramma.TabIndex = 1;
			this.lblTitoloProgramma.Text = "Gestionale interno del parco";
			this.lblTitoloProgramma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDescrizione
			// 
			this.lblDescrizione.AutoSize = true;
			this.lblDescrizione.BackColor = System.Drawing.Color.Transparent;
			this.lblDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescrizione.Location = new System.Drawing.Point(278, 96);
			this.lblDescrizione.Name = "lblDescrizione";
			this.lblDescrizione.Size = new System.Drawing.Size(349, 64);
			this.lblDescrizione.TabIndex = 2;
			this.lblDescrizione.Text = resources.GetString("lblDescrizione.Text");
			this.lblDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGestioneBiglietti
			// 
			this.btnGestioneBiglietti.Location = new System.Drawing.Point(81, 253);
			this.btnGestioneBiglietti.Name = "btnGestioneBiglietti";
			this.btnGestioneBiglietti.Size = new System.Drawing.Size(171, 81);
			this.btnGestioneBiglietti.TabIndex = 3;
			this.btnGestioneBiglietti.Text = "Gestione biglietti";
			this.btnGestioneBiglietti.UseVisualStyleBackColor = true;
			this.btnGestioneBiglietti.Click += new System.EventHandler(this.btnGestioneBiglietti_Click);
			// 
			// btnGestioneGiostre
			// 
			this.btnGestioneGiostre.Location = new System.Drawing.Point(367, 253);
			this.btnGestioneGiostre.Name = "btnGestioneGiostre";
			this.btnGestioneGiostre.Size = new System.Drawing.Size(171, 81);
			this.btnGestioneGiostre.TabIndex = 4;
			this.btnGestioneGiostre.Text = "Gestione giostre";
			this.btnGestioneGiostre.UseVisualStyleBackColor = true;
			this.btnGestioneGiostre.Click += new System.EventHandler(this.btnGestioneGiostre_Click);
			// 
			// btnGestioneAttrazioni
			// 
			this.btnGestioneAttrazioni.Location = new System.Drawing.Point(634, 253);
			this.btnGestioneAttrazioni.Name = "btnGestioneAttrazioni";
			this.btnGestioneAttrazioni.Size = new System.Drawing.Size(171, 81);
			this.btnGestioneAttrazioni.TabIndex = 5;
			this.btnGestioneAttrazioni.Text = "Gestione attrazioni";
			this.btnGestioneAttrazioni.UseVisualStyleBackColor = true;
			this.btnGestioneAttrazioni.Click += new System.EventHandler(this.btnGestioneAttrazioni_Click);
			// 
			// btnChiusura
			// 
			this.btnChiusura.BackColor = System.Drawing.Color.Red;
			this.btnChiusura.ForeColor = System.Drawing.Color.White;
			this.btnChiusura.Location = new System.Drawing.Point(367, 447);
			this.btnChiusura.Name = "btnChiusura";
			this.btnChiusura.Size = new System.Drawing.Size(171, 28);
			this.btnChiusura.TabIndex = 6;
			this.btnChiusura.Text = "Chiudi tutto";
			this.btnChiusura.UseVisualStyleBackColor = false;
			this.btnChiusura.Click += new System.EventHandler(this.btnChiusura_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::esFantasiaPark.Properties.Resources.Screenshot_2026_03_31_082243;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(956, 536);
			this.Controls.Add(this.btnChiusura);
			this.Controls.Add(this.btnGestioneAttrazioni);
			this.Controls.Add(this.btnGestioneGiostre);
			this.Controls.Add(this.btnGestioneBiglietti);
			this.Controls.Add(this.lblDescrizione);
			this.Controls.Add(this.lblTitoloProgramma);
			this.Controls.Add(this.lblTitolo);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.Label lblTitoloProgramma;
		private System.Windows.Forms.Label lblDescrizione;
		private System.Windows.Forms.Button btnGestioneBiglietti;
		private System.Windows.Forms.Button btnGestioneGiostre;
		private System.Windows.Forms.Button btnGestioneAttrazioni;
		private System.Windows.Forms.Button btnChiusura;
	}
}

