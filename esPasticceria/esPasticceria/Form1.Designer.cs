namespace esPasticceria
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
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lstCrostate = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAutore = new System.Windows.Forms.Label();
			this.cmbFrolla = new System.Windows.Forms.ComboBox();
			this.cmbMarmellata = new System.Windows.Forms.ComboBox();
			this.txtCottura = new System.Windows.Forms.TextBox();
			this.txtDiametro = new System.Windows.Forms.TextBox();
			this.rdbDecorazioniTrue = new System.Windows.Forms.RadioButton();
			this.rdbDecorazioniFalse = new System.Windows.Forms.RadioButton();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblFrolla = new System.Windows.Forms.Label();
			this.lblMarmellata = new System.Windows.Forms.Label();
			this.lblCottura = new System.Windows.Forms.Label();
			this.lblDiametro = new System.Windows.Forms.Label();
			this.lblDecorazioni = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnAggiunta = new System.Windows.Forms.Button();
			this.lblFiltra = new System.Windows.Forms.Label();
			this.btnFiltra = new System.Windows.Forms.Button();
			this.cmbFiltra = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblTitolo
			// 
			this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitolo.Location = new System.Drawing.Point(475, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(260, 61);
			this.lblTitolo.TabIndex = 0;
			this.lblTitolo.Text = "1001 Crostata";
			this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstCrostate
			// 
			this.lstCrostate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstCrostate.FormattingEnabled = true;
			this.lstCrostate.ItemHeight = 16;
			this.lstCrostate.Location = new System.Drawing.Point(179, 73);
			this.lstCrostate.Name = "lstCrostate";
			this.lstCrostate.Size = new System.Drawing.Size(777, 290);
			this.lstCrostate.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Yellow;
			this.panel1.Location = new System.Drawing.Point(30, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(100, 300);
			this.panel1.TabIndex = 2;
			// 
			// lblAutore
			// 
			this.lblAutore.AutoSize = true;
			this.lblAutore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAutore.Location = new System.Drawing.Point(12, 606);
			this.lblAutore.Name = "lblAutore";
			this.lblAutore.Size = new System.Drawing.Size(234, 24);
			this.lblAutore.TabIndex = 3;
			this.lblAutore.Text = "Autore: Lorenzo Franceschetto";
			// 
			// cmbFrolla
			// 
			this.cmbFrolla.FormattingEnabled = true;
			this.cmbFrolla.Location = new System.Drawing.Point(1003, 73);
			this.cmbFrolla.Name = "cmbFrolla";
			this.cmbFrolla.Size = new System.Drawing.Size(112, 24);
			this.cmbFrolla.TabIndex = 4;
			// 
			// cmbMarmellata
			// 
			this.cmbMarmellata.FormattingEnabled = true;
			this.cmbMarmellata.Location = new System.Drawing.Point(1003, 133);
			this.cmbMarmellata.Name = "cmbMarmellata";
			this.cmbMarmellata.Size = new System.Drawing.Size(112, 24);
			this.cmbMarmellata.TabIndex = 5;
			// 
			// txtCottura
			// 
			this.txtCottura.Location = new System.Drawing.Point(1005, 191);
			this.txtCottura.Name = "txtCottura";
			this.txtCottura.Size = new System.Drawing.Size(109, 22);
			this.txtCottura.TabIndex = 6;
			this.txtCottura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCottura_KeyPress);
			// 
			// txtDiametro
			// 
			this.txtDiametro.Location = new System.Drawing.Point(1006, 247);
			this.txtDiametro.Name = "txtDiametro";
			this.txtDiametro.Size = new System.Drawing.Size(109, 22);
			this.txtDiametro.TabIndex = 7;
			this.txtDiametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiametro_KeyPress);
			// 
			// rdbDecorazioniTrue
			// 
			this.rdbDecorazioniTrue.AutoSize = true;
			this.rdbDecorazioniTrue.Location = new System.Drawing.Point(1003, 307);
			this.rdbDecorazioniTrue.Name = "rdbDecorazioniTrue";
			this.rdbDecorazioniTrue.Size = new System.Drawing.Size(40, 20);
			this.rdbDecorazioniTrue.TabIndex = 8;
			this.rdbDecorazioniTrue.TabStop = true;
			this.rdbDecorazioniTrue.Text = "Sì";
			this.rdbDecorazioniTrue.UseVisualStyleBackColor = true;
			// 
			// rdbDecorazioniFalse
			// 
			this.rdbDecorazioniFalse.AutoSize = true;
			this.rdbDecorazioniFalse.Location = new System.Drawing.Point(1003, 333);
			this.rdbDecorazioniFalse.Name = "rdbDecorazioniFalse";
			this.rdbDecorazioniFalse.Size = new System.Drawing.Size(46, 20);
			this.rdbDecorazioniFalse.TabIndex = 9;
			this.rdbDecorazioniFalse.TabStop = true;
			this.rdbDecorazioniFalse.Text = "No";
			this.rdbDecorazioniFalse.UseVisualStyleBackColor = true;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(1003, 383);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(109, 22);
			this.txtNome.TabIndex = 10;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// lblFrolla
			// 
			this.lblFrolla.AutoSize = true;
			this.lblFrolla.Location = new System.Drawing.Point(1002, 54);
			this.lblFrolla.Name = "lblFrolla";
			this.lblFrolla.Size = new System.Drawing.Size(114, 16);
			this.lblFrolla.TabIndex = 11;
			this.lblFrolla.Text = "Selezionare frolla:";
			// 
			// lblMarmellata
			// 
			this.lblMarmellata.AutoSize = true;
			this.lblMarmellata.Location = new System.Drawing.Point(984, 114);
			this.lblMarmellata.Name = "lblMarmellata";
			this.lblMarmellata.Size = new System.Drawing.Size(152, 16);
			this.lblMarmellata.TabIndex = 12;
			this.lblMarmellata.Text = "Selezionare marmellata:";
			// 
			// lblCottura
			// 
			this.lblCottura.AutoSize = true;
			this.lblCottura.Location = new System.Drawing.Point(984, 172);
			this.lblCottura.Name = "lblCottura";
			this.lblCottura.Size = new System.Drawing.Size(138, 16);
			this.lblCottura.TabIndex = 13;
			this.lblCottura.Text = "Inserire tempo cottura:";
			// 
			// lblDiametro
			// 
			this.lblDiametro.AutoSize = true;
			this.lblDiametro.Location = new System.Drawing.Point(984, 228);
			this.lblDiametro.Name = "lblDiametro";
			this.lblDiametro.Size = new System.Drawing.Size(161, 16);
			this.lblDiametro.TabIndex = 14;
			this.lblDiametro.Text = "Inserire diametro crostata:";
			// 
			// lblDecorazioni
			// 
			this.lblDecorazioni.AutoSize = true;
			this.lblDecorazioni.Location = new System.Drawing.Point(1000, 288);
			this.lblDecorazioni.Name = "lblDecorazioni";
			this.lblDecorazioni.Size = new System.Drawing.Size(82, 16);
			this.lblDecorazioni.TabIndex = 15;
			this.lblDecorazioni.Text = "Decorazioni:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(984, 364);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(142, 16);
			this.lblNome.TabIndex = 16;
			this.lblNome.Text = "Inserire nome crostata:";
			// 
			// btnAggiunta
			// 
			this.btnAggiunta.Location = new System.Drawing.Point(1003, 428);
			this.btnAggiunta.Name = "btnAggiunta";
			this.btnAggiunta.Size = new System.Drawing.Size(109, 50);
			this.btnAggiunta.TabIndex = 17;
			this.btnAggiunta.Text = "Aggiungi crostata";
			this.btnAggiunta.UseVisualStyleBackColor = true;
			this.btnAggiunta.Click += new System.EventHandler(this.btnAggiunta_Click);
			// 
			// lblFiltra
			// 
			this.lblFiltra.AutoSize = true;
			this.lblFiltra.Location = new System.Drawing.Point(444, 423);
			this.lblFiltra.Name = "lblFiltra";
			this.lblFiltra.Size = new System.Drawing.Size(132, 16);
			this.lblFiltra.TabIndex = 19;
			this.lblFiltra.Text = "Filtra per marmellata:";
			// 
			// btnFiltra
			// 
			this.btnFiltra.Location = new System.Drawing.Point(447, 483);
			this.btnFiltra.Name = "btnFiltra";
			this.btnFiltra.Size = new System.Drawing.Size(109, 50);
			this.btnFiltra.TabIndex = 20;
			this.btnFiltra.Text = "Filtra crostate";
			this.btnFiltra.UseVisualStyleBackColor = true;
			this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
			// 
			// cmbFiltra
			// 
			this.cmbFiltra.FormattingEnabled = true;
			this.cmbFiltra.Items.AddRange(new object[] {
            "Default"});
			this.cmbFiltra.Location = new System.Drawing.Point(447, 442);
			this.cmbFiltra.Name = "cmbFiltra";
			this.cmbFiltra.Size = new System.Drawing.Size(112, 24);
			this.cmbFiltra.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(1163, 639);
			this.Controls.Add(this.cmbFiltra);
			this.Controls.Add(this.btnFiltra);
			this.Controls.Add(this.lblFiltra);
			this.Controls.Add(this.btnAggiunta);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblDecorazioni);
			this.Controls.Add(this.lblDiametro);
			this.Controls.Add(this.lblCottura);
			this.Controls.Add(this.lblMarmellata);
			this.Controls.Add(this.lblFrolla);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.rdbDecorazioniFalse);
			this.Controls.Add(this.rdbDecorazioniTrue);
			this.Controls.Add(this.txtDiametro);
			this.Controls.Add(this.txtCottura);
			this.Controls.Add(this.cmbMarmellata);
			this.Controls.Add(this.cmbFrolla);
			this.Controls.Add(this.lblAutore);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lstCrostate);
			this.Controls.Add(this.lblTitolo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.ListBox lstCrostate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblAutore;
		private System.Windows.Forms.ComboBox cmbFrolla;
		private System.Windows.Forms.ComboBox cmbMarmellata;
		private System.Windows.Forms.TextBox txtCottura;
		private System.Windows.Forms.TextBox txtDiametro;
		private System.Windows.Forms.RadioButton rdbDecorazioniTrue;
		private System.Windows.Forms.RadioButton rdbDecorazioniFalse;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblFrolla;
		private System.Windows.Forms.Label lblMarmellata;
		private System.Windows.Forms.Label lblCottura;
		private System.Windows.Forms.Label lblDiametro;
		private System.Windows.Forms.Label lblDecorazioni;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Button btnAggiunta;
		private System.Windows.Forms.Label lblFiltra;
		private System.Windows.Forms.Button btnFiltra;
		private System.Windows.Forms.ComboBox cmbFiltra;
	}
}

