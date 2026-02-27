namespace EsCreatureMagiche
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lblBoxCreature = new System.Windows.Forms.Label();
			this.lblMagia = new System.Windows.Forms.Label();
			this.lblRazza = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnCreaturaPotente = new System.Windows.Forms.Button();
			this.btnFiltraRazza = new System.Windows.Forms.Button();
			this.btnCreatureDeboli = new System.Windows.Forms.Button();
			this.btnMediaMagia = new System.Windows.Forms.Button();
			this.btnScaccia = new System.Windows.Forms.Button();
			this.btnEvoca = new System.Windows.Forms.Button();
			this.lstBoxCreature = new System.Windows.Forms.ListBox();
			this.cmbBoxMagia = new System.Windows.Forms.ComboBox();
			this.cmbBoxRazza = new System.Windows.Forms.ComboBox();
			this.txtBoxNome = new System.Windows.Forms.TextBox();
			this.btnAvvia = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblTitolo);
			this.panel1.Controls.Add(this.lblBoxCreature);
			this.panel1.Controls.Add(this.lblMagia);
			this.panel1.Controls.Add(this.lblRazza);
			this.panel1.Controls.Add(this.lblNome);
			this.panel1.Controls.Add(this.btnCreaturaPotente);
			this.panel1.Controls.Add(this.btnFiltraRazza);
			this.panel1.Controls.Add(this.btnCreatureDeboli);
			this.panel1.Controls.Add(this.btnMediaMagia);
			this.panel1.Controls.Add(this.btnScaccia);
			this.panel1.Controls.Add(this.btnEvoca);
			this.panel1.Controls.Add(this.lstBoxCreature);
			this.panel1.Controls.Add(this.cmbBoxMagia);
			this.panel1.Controls.Add(this.cmbBoxRazza);
			this.panel1.Controls.Add(this.txtBoxNome);
			this.panel1.Location = new System.Drawing.Point(42, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1098, 803);
			this.panel1.TabIndex = 0;
			// 
			// lblTitolo
			// 
			this.lblTitolo.Location = new System.Drawing.Point(480, 25);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(141, 25);
			this.lblTitolo.TabIndex = 29;
			this.lblTitolo.Text = "Creature Magiche";
			this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBoxCreature
			// 
			this.lblBoxCreature.Location = new System.Drawing.Point(21, 55);
			this.lblBoxCreature.Name = "lblBoxCreature";
			this.lblBoxCreature.Size = new System.Drawing.Size(416, 23);
			this.lblBoxCreature.TabIndex = 28;
			this.lblBoxCreature.Text = "Lista creature:";
			this.lblBoxCreature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMagia
			// 
			this.lblMagia.Location = new System.Drawing.Point(923, 322);
			this.lblMagia.Name = "lblMagia";
			this.lblMagia.Size = new System.Drawing.Size(124, 38);
			this.lblMagia.TabIndex = 27;
			this.lblMagia.Text = "Inserisci il livello di magia:";
			// 
			// lblRazza
			// 
			this.lblRazza.Location = new System.Drawing.Point(923, 89);
			this.lblRazza.Name = "lblRazza";
			this.lblRazza.Size = new System.Drawing.Size(124, 38);
			this.lblRazza.TabIndex = 26;
			this.lblRazza.Text = "Inserisci la razza da filtrare:";
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(532, 89);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(146, 38);
			this.lblNome.TabIndex = 25;
			this.lblNome.Text = "Inserisci il nome della creatura magica:";
			// 
			// btnCreaturaPotente
			// 
			this.btnCreaturaPotente.Location = new System.Drawing.Point(926, 442);
			this.btnCreaturaPotente.Name = "btnCreaturaPotente";
			this.btnCreaturaPotente.Size = new System.Drawing.Size(121, 66);
			this.btnCreaturaPotente.TabIndex = 24;
			this.btnCreaturaPotente.Text = "Visualizza più potente";
			this.btnCreaturaPotente.UseVisualStyleBackColor = true;
			this.btnCreaturaPotente.Click += new System.EventHandler(this.btnCreaturaPotente_Click);
			// 
			// btnFiltraRazza
			// 
			this.btnFiltraRazza.Location = new System.Drawing.Point(926, 206);
			this.btnFiltraRazza.Name = "btnFiltraRazza";
			this.btnFiltraRazza.Size = new System.Drawing.Size(121, 66);
			this.btnFiltraRazza.TabIndex = 23;
			this.btnFiltraRazza.Text = "Filtra per razza";
			this.btnFiltraRazza.UseVisualStyleBackColor = true;
			this.btnFiltraRazza.Click += new System.EventHandler(this.btnFiltraRazza_Click);
			// 
			// btnCreatureDeboli
			// 
			this.btnCreatureDeboli.Location = new System.Drawing.Point(535, 322);
			this.btnCreatureDeboli.Name = "btnCreatureDeboli";
			this.btnCreatureDeboli.Size = new System.Drawing.Size(121, 66);
			this.btnCreatureDeboli.TabIndex = 22;
			this.btnCreatureDeboli.Text = "Creature deboli";
			this.btnCreatureDeboli.UseVisualStyleBackColor = true;
			this.btnCreatureDeboli.Click += new System.EventHandler(this.btnCreatureDeboli_Click);
			// 
			// btnMediaMagia
			// 
			this.btnMediaMagia.Location = new System.Drawing.Point(726, 322);
			this.btnMediaMagia.Name = "btnMediaMagia";
			this.btnMediaMagia.Size = new System.Drawing.Size(121, 66);
			this.btnMediaMagia.TabIndex = 21;
			this.btnMediaMagia.Text = "Media Magica";
			this.btnMediaMagia.UseVisualStyleBackColor = true;
			this.btnMediaMagia.Click += new System.EventHandler(this.btnMediaMagia_Click);
			// 
			// btnScaccia
			// 
			this.btnScaccia.Location = new System.Drawing.Point(726, 206);
			this.btnScaccia.Name = "btnScaccia";
			this.btnScaccia.Size = new System.Drawing.Size(121, 66);
			this.btnScaccia.TabIndex = 20;
			this.btnScaccia.Text = "Scaccia creatura";
			this.btnScaccia.UseVisualStyleBackColor = true;
			this.btnScaccia.Click += new System.EventHandler(this.btnScaccia_Click);
			// 
			// btnEvoca
			// 
			this.btnEvoca.Location = new System.Drawing.Point(535, 206);
			this.btnEvoca.Name = "btnEvoca";
			this.btnEvoca.Size = new System.Drawing.Size(121, 66);
			this.btnEvoca.TabIndex = 19;
			this.btnEvoca.Text = "Evoca creatura!";
			this.btnEvoca.UseVisualStyleBackColor = true;
			this.btnEvoca.Click += new System.EventHandler(this.btnEvoca_Click);
			// 
			// lstBoxCreature
			// 
			this.lstBoxCreature.FormattingEnabled = true;
			this.lstBoxCreature.ItemHeight = 16;
			this.lstBoxCreature.Location = new System.Drawing.Point(21, 81);
			this.lstBoxCreature.Name = "lstBoxCreature";
			this.lstBoxCreature.Size = new System.Drawing.Size(416, 644);
			this.lstBoxCreature.TabIndex = 18;
			// 
			// cmbBoxMagia
			// 
			this.cmbBoxMagia.FormattingEnabled = true;
			this.cmbBoxMagia.Location = new System.Drawing.Point(926, 364);
			this.cmbBoxMagia.Name = "cmbBoxMagia";
			this.cmbBoxMagia.Size = new System.Drawing.Size(121, 24);
			this.cmbBoxMagia.TabIndex = 17;
			// 
			// cmbBoxRazza
			// 
			this.cmbBoxRazza.FormattingEnabled = true;
			this.cmbBoxRazza.Location = new System.Drawing.Point(926, 130);
			this.cmbBoxRazza.Name = "cmbBoxRazza";
			this.cmbBoxRazza.Size = new System.Drawing.Size(121, 24);
			this.cmbBoxRazza.TabIndex = 16;
			// 
			// txtBoxNome
			// 
			this.txtBoxNome.Location = new System.Drawing.Point(535, 130);
			this.txtBoxNome.Name = "txtBoxNome";
			this.txtBoxNome.Size = new System.Drawing.Size(175, 22);
			this.txtBoxNome.TabIndex = 15;
			// 
			// btnAvvia
			// 
			this.btnAvvia.Location = new System.Drawing.Point(525, 12);
			this.btnAvvia.Name = "btnAvvia";
			this.btnAvvia.Size = new System.Drawing.Size(138, 47);
			this.btnAvvia.TabIndex = 30;
			this.btnAvvia.Text = "Avvia";
			this.btnAvvia.UseVisualStyleBackColor = true;
			this.btnAvvia.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 885);
			this.Controls.Add(this.btnAvvia);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.Label lblBoxCreature;
		private System.Windows.Forms.Label lblMagia;
		private System.Windows.Forms.Label lblRazza;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Button btnCreaturaPotente;
		private System.Windows.Forms.Button btnFiltraRazza;
		private System.Windows.Forms.Button btnCreatureDeboli;
		private System.Windows.Forms.Button btnMediaMagia;
		private System.Windows.Forms.Button btnScaccia;
		private System.Windows.Forms.Button btnEvoca;
		private System.Windows.Forms.ListBox lstBoxCreature;
		private System.Windows.Forms.ComboBox cmbBoxMagia;
		private System.Windows.Forms.ComboBox cmbBoxRazza;
		private System.Windows.Forms.TextBox txtBoxNome;
		private System.Windows.Forms.Button btnAvvia;
	}
}

