namespace esBiblioteca
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
			this.lstLibri = new System.Windows.Forms.ListBox();
			this.btnAggiungi = new System.Windows.Forms.Button();
			this.txtTitoloLibro = new System.Windows.Forms.TextBox();
			this.txtAutore = new System.Windows.Forms.TextBox();
			this.lblTItoloLibro = new System.Windows.Forms.Label();
			this.lblAutore = new System.Windows.Forms.Label();
			this.cmbGenere = new System.Windows.Forms.ComboBox();
			this.lblGenere = new System.Windows.Forms.Label();
			this.lblAnno = new System.Windows.Forms.Label();
			this.txtAnno = new System.Windows.Forms.TextBox();
			this.lblPagine = new System.Windows.Forms.Label();
			this.txtPagine = new System.Windows.Forms.TextBox();
			this.chcDisponibile = new System.Windows.Forms.CheckBox();
			this.lblCodice = new System.Windows.Forms.Label();
			this.txtCodice = new System.Windows.Forms.TextBox();
			this.lblFiltraGenere = new System.Windows.Forms.Label();
			this.cmbFiltraGenere = new System.Windows.Forms.ComboBox();
			this.btnFiltraGenere = new System.Windows.Forms.Button();
			this.lblFiltraAutore = new System.Windows.Forms.Label();
			this.txtFiltraAutore = new System.Windows.Forms.TextBox();
			this.btnFiltraAutore = new System.Windows.Forms.Button();
			this.rdbAZ = new System.Windows.Forms.RadioButton();
			this.rdbAnnoPubblicazione = new System.Windows.Forms.RadioButton();
			this.lblOrdinamento = new System.Windows.Forms.Label();
			this.btnOrdinamento = new System.Windows.Forms.Button();
			this.btnStatistiche = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.Location = new System.Drawing.Point(331, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(140, 16);
			this.lblTitolo.TabIndex = 0;
			this.lblTitolo.Text = "Biblioteca digitalizzata";
			// 
			// lstLibri
			// 
			this.lstLibri.FormattingEnabled = true;
			this.lstLibri.ItemHeight = 16;
			this.lstLibri.Location = new System.Drawing.Point(12, 25);
			this.lstLibri.Name = "lstLibri";
			this.lstLibri.Size = new System.Drawing.Size(832, 452);
			this.lstLibri.TabIndex = 1;
			// 
			// btnAggiungi
			// 
			this.btnAggiungi.Location = new System.Drawing.Point(850, 415);
			this.btnAggiungi.Name = "btnAggiungi";
			this.btnAggiungi.Size = new System.Drawing.Size(139, 57);
			this.btnAggiungi.TabIndex = 2;
			this.btnAggiungi.Text = "Aggiungi libro";
			this.btnAggiungi.UseVisualStyleBackColor = true;
			this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
			// 
			// txtTitoloLibro
			// 
			this.txtTitoloLibro.Location = new System.Drawing.Point(850, 48);
			this.txtTitoloLibro.Name = "txtTitoloLibro";
			this.txtTitoloLibro.Size = new System.Drawing.Size(139, 22);
			this.txtTitoloLibro.TabIndex = 3;
			this.txtTitoloLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitoloLibro_KeyPress);
			// 
			// txtAutore
			// 
			this.txtAutore.Location = new System.Drawing.Point(850, 95);
			this.txtAutore.Name = "txtAutore";
			this.txtAutore.Size = new System.Drawing.Size(139, 22);
			this.txtAutore.TabIndex = 4;
			this.txtAutore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutore_KeyPress);
			// 
			// lblTItoloLibro
			// 
			this.lblTItoloLibro.AutoSize = true;
			this.lblTItoloLibro.Location = new System.Drawing.Point(851, 25);
			this.lblTItoloLibro.Name = "lblTItoloLibro";
			this.lblTItoloLibro.Size = new System.Drawing.Size(85, 16);
			this.lblTItoloLibro.TabIndex = 6;
			this.lblTItoloLibro.Text = "Inserire titolo:";
			// 
			// lblAutore
			// 
			this.lblAutore.AutoSize = true;
			this.lblAutore.Location = new System.Drawing.Point(851, 76);
			this.lblAutore.Name = "lblAutore";
			this.lblAutore.Size = new System.Drawing.Size(95, 16);
			this.lblAutore.TabIndex = 7;
			this.lblAutore.Text = "Inserire autore:";
			// 
			// cmbGenere
			// 
			this.cmbGenere.FormattingEnabled = true;
			this.cmbGenere.Location = new System.Drawing.Point(850, 148);
			this.cmbGenere.Name = "cmbGenere";
			this.cmbGenere.Size = new System.Drawing.Size(139, 24);
			this.cmbGenere.TabIndex = 8;
			// 
			// lblGenere
			// 
			this.lblGenere.AutoSize = true;
			this.lblGenere.Location = new System.Drawing.Point(851, 129);
			this.lblGenere.Name = "lblGenere";
			this.lblGenere.Size = new System.Drawing.Size(100, 16);
			this.lblGenere.TabIndex = 9;
			this.lblGenere.Text = "Inserire genere:";
			// 
			// lblAnno
			// 
			this.lblAnno.AutoSize = true;
			this.lblAnno.Location = new System.Drawing.Point(851, 178);
			this.lblAnno.Name = "lblAnno";
			this.lblAnno.Size = new System.Drawing.Size(108, 32);
			this.lblAnno.TabIndex = 11;
			this.lblAnno.Text = "Inserire anno \r\ndi pubblicazione:";
			// 
			// txtAnno
			// 
			this.txtAnno.Location = new System.Drawing.Point(850, 213);
			this.txtAnno.Name = "txtAnno";
			this.txtAnno.Size = new System.Drawing.Size(139, 22);
			this.txtAnno.TabIndex = 10;
			this.txtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnno_KeyPress);
			// 
			// lblPagine
			// 
			this.lblPagine.AutoSize = true;
			this.lblPagine.Location = new System.Drawing.Point(851, 243);
			this.lblPagine.Name = "lblPagine";
			this.lblPagine.Size = new System.Drawing.Size(102, 32);
			this.lblPagine.TabIndex = 13;
			this.lblPagine.Text = "Inserire numero \r\ndi pagine:";
			// 
			// txtPagine
			// 
			this.txtPagine.Location = new System.Drawing.Point(850, 278);
			this.txtPagine.Name = "txtPagine";
			this.txtPagine.Size = new System.Drawing.Size(139, 22);
			this.txtPagine.TabIndex = 12;
			this.txtPagine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagine_KeyPress);
			// 
			// chcDisponibile
			// 
			this.chcDisponibile.AutoSize = true;
			this.chcDisponibile.Location = new System.Drawing.Point(850, 315);
			this.chcDisponibile.Name = "chcDisponibile";
			this.chcDisponibile.Size = new System.Drawing.Size(97, 20);
			this.chcDisponibile.TabIndex = 14;
			this.chcDisponibile.Text = "Disponibile";
			this.chcDisponibile.UseVisualStyleBackColor = true;
			// 
			// lblCodice
			// 
			this.lblCodice.AutoSize = true;
			this.lblCodice.Location = new System.Drawing.Point(851, 349);
			this.lblCodice.Name = "lblCodice";
			this.lblCodice.Size = new System.Drawing.Size(132, 16);
			this.lblCodice.TabIndex = 16;
			this.lblCodice.Text = "Inserire codice ISBN:";
			// 
			// txtCodice
			// 
			this.txtCodice.Location = new System.Drawing.Point(850, 372);
			this.txtCodice.Name = "txtCodice";
			this.txtCodice.Size = new System.Drawing.Size(139, 22);
			this.txtCodice.TabIndex = 15;
			this.txtCodice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodice_KeyPress);
			// 
			// lblFiltraGenere
			// 
			this.lblFiltraGenere.AutoSize = true;
			this.lblFiltraGenere.Location = new System.Drawing.Point(14, 508);
			this.lblFiltraGenere.Name = "lblFiltraGenere";
			this.lblFiltraGenere.Size = new System.Drawing.Size(100, 16);
			this.lblFiltraGenere.TabIndex = 18;
			this.lblFiltraGenere.Text = "Inserire genere:";
			// 
			// cmbFiltraGenere
			// 
			this.cmbFiltraGenere.FormattingEnabled = true;
			this.cmbFiltraGenere.Location = new System.Drawing.Point(13, 527);
			this.cmbFiltraGenere.Name = "cmbFiltraGenere";
			this.cmbFiltraGenere.Size = new System.Drawing.Size(139, 24);
			this.cmbFiltraGenere.TabIndex = 17;
			// 
			// btnFiltraGenere
			// 
			this.btnFiltraGenere.Location = new System.Drawing.Point(180, 494);
			this.btnFiltraGenere.Name = "btnFiltraGenere";
			this.btnFiltraGenere.Size = new System.Drawing.Size(139, 57);
			this.btnFiltraGenere.TabIndex = 19;
			this.btnFiltraGenere.Text = "Filtra per genere";
			this.btnFiltraGenere.UseVisualStyleBackColor = true;
			this.btnFiltraGenere.Click += new System.EventHandler(this.btnFiltraGenere_Click);
			// 
			// lblFiltraAutore
			// 
			this.lblFiltraAutore.AutoSize = true;
			this.lblFiltraAutore.Location = new System.Drawing.Point(14, 573);
			this.lblFiltraAutore.Name = "lblFiltraAutore";
			this.lblFiltraAutore.Size = new System.Drawing.Size(95, 16);
			this.lblFiltraAutore.TabIndex = 21;
			this.lblFiltraAutore.Text = "Inserire autore:";
			// 
			// txtFiltraAutore
			// 
			this.txtFiltraAutore.Location = new System.Drawing.Point(13, 592);
			this.txtFiltraAutore.Name = "txtFiltraAutore";
			this.txtFiltraAutore.Size = new System.Drawing.Size(139, 22);
			this.txtFiltraAutore.TabIndex = 20;
			// 
			// btnFiltraAutore
			// 
			this.btnFiltraAutore.Location = new System.Drawing.Point(180, 557);
			this.btnFiltraAutore.Name = "btnFiltraAutore";
			this.btnFiltraAutore.Size = new System.Drawing.Size(139, 57);
			this.btnFiltraAutore.TabIndex = 22;
			this.btnFiltraAutore.Text = "Filtra per autore";
			this.btnFiltraAutore.UseVisualStyleBackColor = true;
			this.btnFiltraAutore.Click += new System.EventHandler(this.btnFiltraAutore_Click);
			// 
			// rdbAZ
			// 
			this.rdbAZ.AutoSize = true;
			this.rdbAZ.Location = new System.Drawing.Point(395, 527);
			this.rdbAZ.Name = "rdbAZ";
			this.rdbAZ.Size = new System.Drawing.Size(143, 20);
			this.rdbAZ.TabIndex = 23;
			this.rdbAZ.TabStop = true;
			this.rdbAZ.Text = "Titolo dalla A alla Z";
			this.rdbAZ.UseVisualStyleBackColor = true;
			// 
			// rdbAnnoPubblicazione
			// 
			this.rdbAnnoPubblicazione.AutoSize = true;
			this.rdbAnnoPubblicazione.Location = new System.Drawing.Point(395, 557);
			this.rdbAnnoPubblicazione.Name = "rdbAnnoPubblicazione";
			this.rdbAnnoPubblicazione.Size = new System.Drawing.Size(160, 20);
			this.rdbAnnoPubblicazione.TabIndex = 24;
			this.rdbAnnoPubblicazione.TabStop = true;
			this.rdbAnnoPubblicazione.Text = "Anno di pubblicazione";
			this.rdbAnnoPubblicazione.UseVisualStyleBackColor = true;
			// 
			// lblOrdinamento
			// 
			this.lblOrdinamento.AutoSize = true;
			this.lblOrdinamento.Location = new System.Drawing.Point(392, 494);
			this.lblOrdinamento.Name = "lblOrdinamento";
			this.lblOrdinamento.Size = new System.Drawing.Size(229, 16);
			this.lblOrdinamento.TabIndex = 25;
			this.lblOrdinamento.Text = "Selezionare il criterio di ordinamento: ";
			// 
			// btnOrdinamento
			// 
			this.btnOrdinamento.Location = new System.Drawing.Point(627, 520);
			this.btnOrdinamento.Name = "btnOrdinamento";
			this.btnOrdinamento.Size = new System.Drawing.Size(139, 57);
			this.btnOrdinamento.TabIndex = 26;
			this.btnOrdinamento.Text = "Ordina in base al criterio scelto";
			this.btnOrdinamento.UseVisualStyleBackColor = true;
			this.btnOrdinamento.Click += new System.EventHandler(this.btnOrdinamento_Click);
			// 
			// btnStatistiche
			// 
			this.btnStatistiche.Location = new System.Drawing.Point(850, 520);
			this.btnStatistiche.Name = "btnStatistiche";
			this.btnStatistiche.Size = new System.Drawing.Size(139, 57);
			this.btnStatistiche.TabIndex = 27;
			this.btnStatistiche.Text = "Visualizza statistiche";
			this.btnStatistiche.UseVisualStyleBackColor = true;
			this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 640);
			this.Controls.Add(this.btnStatistiche);
			this.Controls.Add(this.btnOrdinamento);
			this.Controls.Add(this.lblOrdinamento);
			this.Controls.Add(this.rdbAnnoPubblicazione);
			this.Controls.Add(this.rdbAZ);
			this.Controls.Add(this.btnFiltraAutore);
			this.Controls.Add(this.lblFiltraAutore);
			this.Controls.Add(this.txtFiltraAutore);
			this.Controls.Add(this.btnFiltraGenere);
			this.Controls.Add(this.lblFiltraGenere);
			this.Controls.Add(this.cmbFiltraGenere);
			this.Controls.Add(this.lblCodice);
			this.Controls.Add(this.txtCodice);
			this.Controls.Add(this.chcDisponibile);
			this.Controls.Add(this.lblPagine);
			this.Controls.Add(this.txtPagine);
			this.Controls.Add(this.lblAnno);
			this.Controls.Add(this.txtAnno);
			this.Controls.Add(this.lblGenere);
			this.Controls.Add(this.cmbGenere);
			this.Controls.Add(this.lblAutore);
			this.Controls.Add(this.lblTItoloLibro);
			this.Controls.Add(this.txtAutore);
			this.Controls.Add(this.txtTitoloLibro);
			this.Controls.Add(this.btnAggiungi);
			this.Controls.Add(this.lstLibri);
			this.Controls.Add(this.lblTitolo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.ListBox lstLibri;
		private System.Windows.Forms.Button btnAggiungi;
		private System.Windows.Forms.TextBox txtTitoloLibro;
		private System.Windows.Forms.TextBox txtAutore;
		private System.Windows.Forms.Label lblTItoloLibro;
		private System.Windows.Forms.Label lblAutore;
		private System.Windows.Forms.ComboBox cmbGenere;
		private System.Windows.Forms.Label lblGenere;
		private System.Windows.Forms.Label lblAnno;
		private System.Windows.Forms.TextBox txtAnno;
		private System.Windows.Forms.Label lblPagine;
		private System.Windows.Forms.TextBox txtPagine;
		private System.Windows.Forms.CheckBox chcDisponibile;
		private System.Windows.Forms.Label lblCodice;
		private System.Windows.Forms.TextBox txtCodice;
		private System.Windows.Forms.Label lblFiltraGenere;
		private System.Windows.Forms.ComboBox cmbFiltraGenere;
		private System.Windows.Forms.Button btnFiltraGenere;
		private System.Windows.Forms.Label lblFiltraAutore;
		private System.Windows.Forms.TextBox txtFiltraAutore;
		private System.Windows.Forms.Button btnFiltraAutore;
		private System.Windows.Forms.RadioButton rdbAZ;
		private System.Windows.Forms.RadioButton rdbAnnoPubblicazione;
		private System.Windows.Forms.Label lblOrdinamento;
		private System.Windows.Forms.Button btnOrdinamento;
		private System.Windows.Forms.Button btnStatistiche;
	}
}

