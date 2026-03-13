namespace esCavalli
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtRazza = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAnno = new System.Windows.Forms.TextBox();
			this.lblAnno = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rdbF = new System.Windows.Forms.RadioButton();
			this.rdbM = new System.Windows.Forms.RadioButton();
			this.btnSalva = new System.Windows.Forms.Button();
			this.lstCavalli = new System.Windows.Forms.ListBox();
			this.btnFile = new System.Windows.Forms.Button();
			this.btnFiltra = new System.Windows.Forms.Button();
			this.btnModifica = new System.Windows.Forms.Button();
			this.btnRimozione = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(21, 35);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(166, 22);
			this.txtNome.TabIndex = 0;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// txtRazza
			// 
			this.txtRazza.Location = new System.Drawing.Point(248, 35);
			this.txtRazza.Name = "txtRazza";
			this.txtRazza.Size = new System.Drawing.Size(169, 22);
			this.txtRazza.TabIndex = 1;
			this.txtRazza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazza_KeyPress);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(18, 16);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(169, 16);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Inserire il nome del cavallo:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(245, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Inserire la razza del cavallo:";
			// 
			// txtAnno
			// 
			this.txtAnno.Location = new System.Drawing.Point(21, 94);
			this.txtAnno.Name = "txtAnno";
			this.txtAnno.Size = new System.Drawing.Size(150, 22);
			this.txtAnno.TabIndex = 4;
			this.txtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnno_KeyPress);
			// 
			// lblAnno
			// 
			this.lblAnno.AutoSize = true;
			this.lblAnno.Location = new System.Drawing.Point(18, 75);
			this.lblAnno.Name = "lblAnno";
			this.lblAnno.Size = new System.Drawing.Size(153, 16);
			this.lblAnno.TabIndex = 5;
			this.lblAnno.Text = "Inserire l\'anno di nascita:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Inseire il sesso del cavallo:";
			// 
			// rdbF
			// 
			this.rdbF.AutoSize = true;
			this.rdbF.Location = new System.Drawing.Point(248, 96);
			this.rdbF.Name = "rdbF";
			this.rdbF.Size = new System.Drawing.Size(36, 20);
			this.rdbF.TabIndex = 7;
			this.rdbF.TabStop = true;
			this.rdbF.Text = "F";
			this.rdbF.UseVisualStyleBackColor = true;
			// 
			// rdbM
			// 
			this.rdbM.AutoSize = true;
			this.rdbM.Location = new System.Drawing.Point(290, 96);
			this.rdbM.Name = "rdbM";
			this.rdbM.Size = new System.Drawing.Size(39, 20);
			this.rdbM.TabIndex = 8;
			this.rdbM.TabStop = true;
			this.rdbM.Text = "M";
			this.rdbM.UseVisualStyleBackColor = true;
			// 
			// btnSalva
			// 
			this.btnSalva.Location = new System.Drawing.Point(540, 45);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(134, 46);
			this.btnSalva.TabIndex = 9;
			this.btnSalva.Text = "Salva cavallo";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// lstCavalli
			// 
			this.lstCavalli.FormattingEnabled = true;
			this.lstCavalli.ItemHeight = 16;
			this.lstCavalli.Location = new System.Drawing.Point(21, 146);
			this.lstCavalli.Name = "lstCavalli";
			this.lstCavalli.Size = new System.Drawing.Size(487, 292);
			this.lstCavalli.TabIndex = 10;
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(540, 159);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(134, 46);
			this.btnFile.TabIndex = 11;
			this.btnFile.Text = "Crea File";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// btnFiltra
			// 
			this.btnFiltra.Location = new System.Drawing.Point(540, 233);
			this.btnFiltra.Name = "btnFiltra";
			this.btnFiltra.Size = new System.Drawing.Size(134, 46);
			this.btnFiltra.TabIndex = 12;
			this.btnFiltra.Text = "Filtra per nome";
			this.btnFiltra.UseVisualStyleBackColor = true;
			this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
			// 
			// btnModifica
			// 
			this.btnModifica.Location = new System.Drawing.Point(540, 315);
			this.btnModifica.Name = "btnModifica";
			this.btnModifica.Size = new System.Drawing.Size(134, 46);
			this.btnModifica.TabIndex = 13;
			this.btnModifica.Text = "Modifica parametri";
			this.btnModifica.UseVisualStyleBackColor = true;
			this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
			// 
			// btnRimozione
			// 
			this.btnRimozione.Location = new System.Drawing.Point(540, 389);
			this.btnRimozione.Name = "btnRimozione";
			this.btnRimozione.Size = new System.Drawing.Size(134, 46);
			this.btnRimozione.TabIndex = 14;
			this.btnRimozione.Text = "Rimuovi cavallo";
			this.btnRimozione.UseVisualStyleBackColor = true;
			this.btnRimozione.Click += new System.EventHandler(this.btnRimozione_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRimozione);
			this.Controls.Add(this.btnModifica);
			this.Controls.Add(this.btnFiltra);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.lstCavalli);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.rdbM);
			this.Controls.Add(this.rdbF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblAnno);
			this.Controls.Add(this.txtAnno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtRazza);
			this.Controls.Add(this.txtNome);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtRazza;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAnno;
		private System.Windows.Forms.Label lblAnno;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbF;
		private System.Windows.Forms.RadioButton rdbM;
		private System.Windows.Forms.Button btnSalva;
		private System.Windows.Forms.ListBox lstCavalli;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.Button btnFiltra;
		private System.Windows.Forms.Button btnModifica;
		private System.Windows.Forms.Button btnRimozione;
	}
}

