namespace esUEFA
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
			this.lstPartite = new System.Windows.Forms.ListBox();
			this.btnAggiunta = new System.Windows.Forms.Button();
			this.txtCasa = new System.Windows.Forms.TextBox();
			this.txtOspite = new System.Windows.Forms.TextBox();
			this.lblCasa = new System.Windows.Forms.Label();
			this.lblOspite = new System.Windows.Forms.Label();
			this.lblGol2 = new System.Windows.Forms.Label();
			this.lblGol1 = new System.Windows.Forms.Label();
			this.txtGol2 = new System.Windows.Forms.TextBox();
			this.txtGol1 = new System.Windows.Forms.TextBox();
			this.btnFile = new System.Windows.Forms.Button();
			this.btnStatistiche = new System.Windows.Forms.Button();
			this.btnFiltra = new System.Windows.Forms.Button();
			this.txtFiltra = new System.Windows.Forms.TextBox();
			this.lblFiltra = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstPartite
			// 
			this.lstPartite.FormattingEnabled = true;
			this.lstPartite.ItemHeight = 16;
			this.lstPartite.Location = new System.Drawing.Point(12, 220);
			this.lstPartite.Name = "lstPartite";
			this.lstPartite.Size = new System.Drawing.Size(834, 340);
			this.lstPartite.TabIndex = 0;
			// 
			// btnAggiunta
			// 
			this.btnAggiunta.Location = new System.Drawing.Point(568, 35);
			this.btnAggiunta.Name = "btnAggiunta";
			this.btnAggiunta.Size = new System.Drawing.Size(117, 50);
			this.btnAggiunta.TabIndex = 1;
			this.btnAggiunta.Text = "Aggiungi partita";
			this.btnAggiunta.UseVisualStyleBackColor = true;
			this.btnAggiunta.Click += new System.EventHandler(this.btnAggiunta_Click);
			// 
			// txtCasa
			// 
			this.txtCasa.Location = new System.Drawing.Point(30, 63);
			this.txtCasa.Name = "txtCasa";
			this.txtCasa.Size = new System.Drawing.Size(139, 22);
			this.txtCasa.TabIndex = 2;
			this.txtCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCasa_KeyPress);
			// 
			// txtOspite
			// 
			this.txtOspite.Location = new System.Drawing.Point(284, 63);
			this.txtOspite.Name = "txtOspite";
			this.txtOspite.Size = new System.Drawing.Size(139, 22);
			this.txtOspite.TabIndex = 3;
			this.txtOspite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOspite_KeyPress);
			// 
			// lblCasa
			// 
			this.lblCasa.AutoSize = true;
			this.lblCasa.Location = new System.Drawing.Point(27, 44);
			this.lblCasa.Name = "lblCasa";
			this.lblCasa.Size = new System.Drawing.Size(108, 16);
			this.lblCasa.TabIndex = 4;
			this.lblCasa.Text = "Squadra in casa:";
			// 
			// lblOspite
			// 
			this.lblOspite.AutoSize = true;
			this.lblOspite.Location = new System.Drawing.Point(281, 44);
			this.lblOspite.Name = "lblOspite";
			this.lblOspite.Size = new System.Drawing.Size(115, 16);
			this.lblOspite.TabIndex = 5;
			this.lblOspite.Text = "Squadra in ospite:";
			// 
			// lblGol2
			// 
			this.lblGol2.AutoSize = true;
			this.lblGol2.Location = new System.Drawing.Point(281, 119);
			this.lblGol2.Name = "lblGol2";
			this.lblGol2.Size = new System.Drawing.Size(84, 16);
			this.lblGol2.TabIndex = 9;
			this.lblGol2.Text = "Gol in ospite:";
			// 
			// lblGol1
			// 
			this.lblGol1.AutoSize = true;
			this.lblGol1.Location = new System.Drawing.Point(27, 119);
			this.lblGol1.Name = "lblGol1";
			this.lblGol1.Size = new System.Drawing.Size(77, 16);
			this.lblGol1.TabIndex = 8;
			this.lblGol1.Text = "Gol in casa:";
			// 
			// txtGol2
			// 
			this.txtGol2.Location = new System.Drawing.Point(284, 138);
			this.txtGol2.Name = "txtGol2";
			this.txtGol2.Size = new System.Drawing.Size(139, 22);
			this.txtGol2.TabIndex = 7;
			this.txtGol2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGol2_KeyPress);
			// 
			// txtGol1
			// 
			this.txtGol1.Location = new System.Drawing.Point(30, 138);
			this.txtGol1.Name = "txtGol1";
			this.txtGol1.Size = new System.Drawing.Size(139, 22);
			this.txtGol1.TabIndex = 6;
			this.txtGol1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGol1_KeyPress);
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(568, 110);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(117, 50);
			this.btnFile.TabIndex = 10;
			this.btnFile.Text = "Salva in un file";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// btnStatistiche
			// 
			this.btnStatistiche.Location = new System.Drawing.Point(714, 35);
			this.btnStatistiche.Name = "btnStatistiche";
			this.btnStatistiche.Size = new System.Drawing.Size(117, 50);
			this.btnStatistiche.TabIndex = 11;
			this.btnStatistiche.Text = "Controlla statistiche";
			this.btnStatistiche.UseVisualStyleBackColor = true;
			this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
			// 
			// btnFiltra
			// 
			this.btnFiltra.Location = new System.Drawing.Point(714, 151);
			this.btnFiltra.Name = "btnFiltra";
			this.btnFiltra.Size = new System.Drawing.Size(117, 50);
			this.btnFiltra.TabIndex = 12;
			this.btnFiltra.Text = "FIltra per squadra";
			this.btnFiltra.UseVisualStyleBackColor = true;
			this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
			// 
			// txtFiltra
			// 
			this.txtFiltra.Location = new System.Drawing.Point(714, 112);
			this.txtFiltra.Name = "txtFiltra";
			this.txtFiltra.Size = new System.Drawing.Size(116, 22);
			this.txtFiltra.TabIndex = 13;
			this.txtFiltra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltra_KeyPress);
			// 
			// lblFiltra
			// 
			this.lblFiltra.AutoSize = true;
			this.lblFiltra.Location = new System.Drawing.Point(711, 93);
			this.lblFiltra.Name = "lblFiltra";
			this.lblFiltra.Size = new System.Drawing.Size(120, 16);
			this.lblFiltra.TabIndex = 14;
			this.lblFiltra.Text = "Squadra da filtrare:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 572);
			this.Controls.Add(this.lblFiltra);
			this.Controls.Add(this.txtFiltra);
			this.Controls.Add(this.btnFiltra);
			this.Controls.Add(this.btnStatistiche);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.lblGol2);
			this.Controls.Add(this.lblGol1);
			this.Controls.Add(this.txtGol2);
			this.Controls.Add(this.txtGol1);
			this.Controls.Add(this.lblOspite);
			this.Controls.Add(this.lblCasa);
			this.Controls.Add(this.txtOspite);
			this.Controls.Add(this.txtCasa);
			this.Controls.Add(this.btnAggiunta);
			this.Controls.Add(this.lstPartite);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstPartite;
		private System.Windows.Forms.Button btnAggiunta;
		private System.Windows.Forms.TextBox txtCasa;
		private System.Windows.Forms.TextBox txtOspite;
		private System.Windows.Forms.Label lblCasa;
		private System.Windows.Forms.Label lblOspite;
		private System.Windows.Forms.Label lblGol2;
		private System.Windows.Forms.Label lblGol1;
		private System.Windows.Forms.TextBox txtGol2;
		private System.Windows.Forms.TextBox txtGol1;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.Button btnStatistiche;
		private System.Windows.Forms.Button btnFiltra;
		private System.Windows.Forms.TextBox txtFiltra;
		private System.Windows.Forms.Label lblFiltra;
	}
}

