namespace esRubricaTelefonica
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
			this.label1 = new System.Windows.Forms.Label();
			this.lstContatti = new System.Windows.Forms.ListBox();
			this.btnAggiunta = new System.Windows.Forms.Button();
			this.btnRimozione = new System.Windows.Forms.Button();
			this.btnModifica = new System.Windows.Forms.Button();
			this.btnRicerca = new System.Windows.Forms.Button();
			this.txtNomeCognome = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEliminaRicerca = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(286, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Rubrica Telefonica";
			// 
			// lstContatti
			// 
			this.lstContatti.FormattingEnabled = true;
			this.lstContatti.ItemHeight = 16;
			this.lstContatti.Location = new System.Drawing.Point(12, 72);
			this.lstContatti.Name = "lstContatti";
			this.lstContatti.Size = new System.Drawing.Size(819, 452);
			this.lstContatti.TabIndex = 1;
			// 
			// btnAggiunta
			// 
			this.btnAggiunta.Location = new System.Drawing.Point(837, 295);
			this.btnAggiunta.Name = "btnAggiunta";
			this.btnAggiunta.Size = new System.Drawing.Size(130, 69);
			this.btnAggiunta.TabIndex = 2;
			this.btnAggiunta.Text = "Aggiungi contatto";
			this.btnAggiunta.UseVisualStyleBackColor = true;
			this.btnAggiunta.Click += new System.EventHandler(this.btnAggiunta_Click);
			// 
			// btnRimozione
			// 
			this.btnRimozione.Location = new System.Drawing.Point(837, 454);
			this.btnRimozione.Name = "btnRimozione";
			this.btnRimozione.Size = new System.Drawing.Size(130, 69);
			this.btnRimozione.TabIndex = 3;
			this.btnRimozione.Text = "Elimina contatto";
			this.btnRimozione.UseVisualStyleBackColor = true;
			this.btnRimozione.Click += new System.EventHandler(this.btnRimozione_Click);
			// 
			// btnModifica
			// 
			this.btnModifica.Location = new System.Drawing.Point(973, 295);
			this.btnModifica.Name = "btnModifica";
			this.btnModifica.Size = new System.Drawing.Size(130, 69);
			this.btnModifica.TabIndex = 4;
			this.btnModifica.Text = "Modifica contatto";
			this.btnModifica.UseVisualStyleBackColor = true;
			this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
			// 
			// btnRicerca
			// 
			this.btnRicerca.Location = new System.Drawing.Point(973, 454);
			this.btnRicerca.Name = "btnRicerca";
			this.btnRicerca.Size = new System.Drawing.Size(130, 69);
			this.btnRicerca.TabIndex = 5;
			this.btnRicerca.Text = "Ricerca contatto";
			this.btnRicerca.UseVisualStyleBackColor = true;
			this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
			// 
			// txtNomeCognome
			// 
			this.txtNomeCognome.Location = new System.Drawing.Point(837, 90);
			this.txtNomeCognome.Name = "txtNomeCognome";
			this.txtNomeCognome.Size = new System.Drawing.Size(266, 22);
			this.txtNomeCognome.TabIndex = 6;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(837, 140);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(266, 22);
			this.txtNumero.TabIndex = 7;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(834, 71);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(162, 16);
			this.lblNome.TabIndex = 9;
			this.lblNome.Text = "Inserire nome e cognome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(834, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Inserire numero di telefono:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(834, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Inserire data di nascita:";
			// 
			// dtpData
			// 
			this.dtpData.Location = new System.Drawing.Point(837, 243);
			this.dtpData.MaxDate = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(266, 22);
			this.dtpData.TabIndex = 12;
			this.dtpData.Value = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(834, 172);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(90, 16);
			this.lblNumero.TabIndex = 14;
			this.lblNumero.Text = "Inserire email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(837, 191);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(266, 22);
			this.txtEmail.TabIndex = 13;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(834, 396);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Inserire nome e cognome:";
			// 
			// txtEliminaRicerca
			// 
			this.txtEliminaRicerca.Location = new System.Drawing.Point(837, 415);
			this.txtEliminaRicerca.Name = "txtEliminaRicerca";
			this.txtEliminaRicerca.Size = new System.Drawing.Size(266, 22);
			this.txtEliminaRicerca.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1175, 579);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEliminaRicerca);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.dtpData);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtNomeCognome);
			this.Controls.Add(this.btnRicerca);
			this.Controls.Add(this.btnModifica);
			this.Controls.Add(this.btnRimozione);
			this.Controls.Add(this.btnAggiunta);
			this.Controls.Add(this.lstContatti);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstContatti;
		private System.Windows.Forms.Button btnAggiunta;
		private System.Windows.Forms.Button btnRimozione;
		private System.Windows.Forms.Button btnModifica;
		private System.Windows.Forms.Button btnRicerca;
		private System.Windows.Forms.TextBox txtNomeCognome;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEliminaRicerca;
	}
}

