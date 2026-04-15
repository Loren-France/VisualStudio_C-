namespace esStazioneMeteo
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
			this.lstDatiStazioni = new System.Windows.Forms.ListBox();
			this.btnCerca = new System.Windows.Forms.Button();
			this.txtStazione = new System.Windows.Forms.TextBox();
			this.lblStazione = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblReset = new System.Windows.Forms.Label();
			this.txtReset = new System.Windows.Forms.TextBox();
			this.lblNum = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtBar = new System.Windows.Forms.TextBox();
			this.lblBar = new System.Windows.Forms.Label();
			this.txtTerm1 = new System.Windows.Forms.TextBox();
			this.lblTerm = new System.Windows.Forms.Label();
			this.txtPluv = new System.Windows.Forms.TextBox();
			this.lblPluv = new System.Windows.Forms.Label();
			this.txtIgro = new System.Windows.Forms.TextBox();
			this.lblIgro = new System.Windows.Forms.Label();
			this.txtAnem = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAggiungi = new System.Windows.Forms.Button();
			this.txtTerm4 = new System.Windows.Forms.TextBox();
			this.txtTerm2 = new System.Windows.Forms.TextBox();
			this.txtTerm3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitolo.Location = new System.Drawing.Point(278, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(289, 29);
			this.lblTitolo.TabIndex = 0;
			this.lblTitolo.Text = "Stazione metereologica";
			// 
			// lstDatiStazioni
			// 
			this.lstDatiStazioni.FormattingEnabled = true;
			this.lstDatiStazioni.ItemHeight = 16;
			this.lstDatiStazioni.Location = new System.Drawing.Point(12, 50);
			this.lstDatiStazioni.Name = "lstDatiStazioni";
			this.lstDatiStazioni.Size = new System.Drawing.Size(821, 388);
			this.lstDatiStazioni.TabIndex = 1;
			// 
			// btnCerca
			// 
			this.btnCerca.Location = new System.Drawing.Point(917, 133);
			this.btnCerca.Name = "btnCerca";
			this.btnCerca.Size = new System.Drawing.Size(126, 50);
			this.btnCerca.TabIndex = 2;
			this.btnCerca.Text = "Cerca";
			this.btnCerca.UseVisualStyleBackColor = true;
			this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
			// 
			// txtStazione
			// 
			this.txtStazione.Location = new System.Drawing.Point(917, 89);
			this.txtStazione.MaxLength = 1000;
			this.txtStazione.Name = "txtStazione";
			this.txtStazione.Size = new System.Drawing.Size(61, 22);
			this.txtStazione.TabIndex = 3;
			this.txtStazione.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblStazione
			// 
			this.lblStazione.AutoSize = true;
			this.lblStazione.Location = new System.Drawing.Point(914, 66);
			this.lblStazione.Name = "lblStazione";
			this.lblStazione.Size = new System.Drawing.Size(214, 16);
			this.lblStazione.TabIndex = 4;
			this.lblStazione.Text = "Inserire un numero di una stazione: ";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(917, 267);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(126, 60);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Resetta stazione";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblReset
			// 
			this.lblReset.AutoSize = true;
			this.lblReset.Location = new System.Drawing.Point(914, 214);
			this.lblReset.Name = "lblReset";
			this.lblReset.Size = new System.Drawing.Size(214, 16);
			this.lblReset.TabIndex = 7;
			this.lblReset.Text = "Inserire un numero di una stazione: ";
			// 
			// txtReset
			// 
			this.txtReset.Location = new System.Drawing.Point(917, 237);
			this.txtReset.MaxLength = 1000;
			this.txtReset.Name = "txtReset";
			this.txtReset.Size = new System.Drawing.Size(61, 22);
			this.txtReset.TabIndex = 6;
			this.txtReset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblNum
			// 
			this.lblNum.AutoSize = true;
			this.lblNum.Location = new System.Drawing.Point(12, 482);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(188, 16);
			this.lblNum.TabIndex = 8;
			this.lblNum.Text = "Inserire il numero identificativo:";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(15, 501);
			this.txtNum.MaxLength = 1000;
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(61, 22);
			this.txtNum.TabIndex = 9;
			this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// txtBar
			// 
			this.txtBar.Location = new System.Drawing.Point(236, 501);
			this.txtBar.MaxLength = 1000;
			this.txtBar.Name = "txtBar";
			this.txtBar.Size = new System.Drawing.Size(124, 22);
			this.txtBar.TabIndex = 11;
			this.txtBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblBar
			// 
			this.lblBar.AutoSize = true;
			this.lblBar.Location = new System.Drawing.Point(233, 482);
			this.lblBar.Name = "lblBar";
			this.lblBar.Size = new System.Drawing.Size(194, 16);
			this.lblBar.TabIndex = 10;
			this.lblBar.Text = "Inserire il valore del barometro: ";
			// 
			// txtTerm1
			// 
			this.txtTerm1.Location = new System.Drawing.Point(443, 501);
			this.txtTerm1.MaxLength = 1000;
			this.txtTerm1.Name = "txtTerm1";
			this.txtTerm1.Size = new System.Drawing.Size(124, 22);
			this.txtTerm1.TabIndex = 13;
			this.txtTerm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblTerm
			// 
			this.lblTerm.AutoSize = true;
			this.lblTerm.Location = new System.Drawing.Point(440, 482);
			this.lblTerm.Name = "lblTerm";
			this.lblTerm.Size = new System.Drawing.Size(192, 16);
			this.lblTerm.TabIndex = 12;
			this.lblTerm.Text = "Inserire i valori del termometro: ";
			// 
			// txtPluv
			// 
			this.txtPluv.Location = new System.Drawing.Point(660, 501);
			this.txtPluv.MaxLength = 1000;
			this.txtPluv.Name = "txtPluv";
			this.txtPluv.Size = new System.Drawing.Size(124, 22);
			this.txtPluv.TabIndex = 15;
			this.txtPluv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblPluv
			// 
			this.lblPluv.AutoSize = true;
			this.lblPluv.Location = new System.Drawing.Point(657, 482);
			this.lblPluv.Name = "lblPluv";
			this.lblPluv.Size = new System.Drawing.Size(202, 16);
			this.lblPluv.TabIndex = 14;
			this.lblPluv.Text = "Inserire il valore del pluviometro: ";
			// 
			// txtIgro
			// 
			this.txtIgro.Location = new System.Drawing.Point(875, 501);
			this.txtIgro.MaxLength = 1000;
			this.txtIgro.Name = "txtIgro";
			this.txtIgro.Size = new System.Drawing.Size(124, 22);
			this.txtIgro.TabIndex = 17;
			this.txtIgro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// lblIgro
			// 
			this.lblIgro.AutoSize = true;
			this.lblIgro.Location = new System.Drawing.Point(872, 482);
			this.lblIgro.Name = "lblIgro";
			this.lblIgro.Size = new System.Drawing.Size(189, 16);
			this.lblIgro.TabIndex = 16;
			this.lblIgro.Text = "Inserire il valore del igrometro: ";
			// 
			// txtAnem
			// 
			this.txtAnem.Location = new System.Drawing.Point(15, 559);
			this.txtAnem.MaxLength = 1000;
			this.txtAnem.Name = "txtAnem";
			this.txtAnem.Size = new System.Drawing.Size(124, 22);
			this.txtAnem.TabIndex = 19;
			this.txtAnem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 540);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Inserire il valore del anemometro: ";
			// 
			// btnAggiungi
			// 
			this.btnAggiungi.Location = new System.Drawing.Point(259, 541);
			this.btnAggiungi.Name = "btnAggiungi";
			this.btnAggiungi.Size = new System.Drawing.Size(101, 66);
			this.btnAggiungi.TabIndex = 20;
			this.btnAggiungi.Text = "Aggiungi stazione";
			this.btnAggiungi.UseVisualStyleBackColor = true;
			this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
			// 
			// txtTerm4
			// 
			this.txtTerm4.Location = new System.Drawing.Point(443, 585);
			this.txtTerm4.MaxLength = 1000;
			this.txtTerm4.Name = "txtTerm4";
			this.txtTerm4.Size = new System.Drawing.Size(124, 22);
			this.txtTerm4.TabIndex = 21;
			this.txtTerm4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// txtTerm2
			// 
			this.txtTerm2.Location = new System.Drawing.Point(443, 529);
			this.txtTerm2.MaxLength = 1000;
			this.txtTerm2.Name = "txtTerm2";
			this.txtTerm2.Size = new System.Drawing.Size(124, 22);
			this.txtTerm2.TabIndex = 22;
			this.txtTerm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// txtTerm3
			// 
			this.txtTerm3.Location = new System.Drawing.Point(443, 557);
			this.txtTerm3.MaxLength = 1000;
			this.txtTerm3.Name = "txtTerm3";
			this.txtTerm3.Size = new System.Drawing.Size(124, 22);
			this.txtTerm3.TabIndex = 23;
			this.txtTerm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStazione_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(573, 507);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "00:00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(573, 535);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 16);
			this.label3.TabIndex = 25;
			this.label3.Text = "06:00";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(573, 562);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 16);
			this.label4.TabIndex = 26;
			this.label4.Text = "12:00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(573, 591);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "18:00";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 647);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTerm3);
			this.Controls.Add(this.txtTerm2);
			this.Controls.Add(this.txtTerm4);
			this.Controls.Add(this.btnAggiungi);
			this.Controls.Add(this.txtAnem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIgro);
			this.Controls.Add(this.lblIgro);
			this.Controls.Add(this.txtPluv);
			this.Controls.Add(this.lblPluv);
			this.Controls.Add(this.txtTerm1);
			this.Controls.Add(this.lblTerm);
			this.Controls.Add(this.txtBar);
			this.Controls.Add(this.lblBar);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.lblNum);
			this.Controls.Add(this.lblReset);
			this.Controls.Add(this.txtReset);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblStazione);
			this.Controls.Add(this.txtStazione);
			this.Controls.Add(this.btnCerca);
			this.Controls.Add(this.lstDatiStazioni);
			this.Controls.Add(this.lblTitolo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.ListBox lstDatiStazioni;
		private System.Windows.Forms.Button btnCerca;
		private System.Windows.Forms.TextBox txtStazione;
		private System.Windows.Forms.Label lblStazione;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblReset;
		private System.Windows.Forms.TextBox txtReset;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.TextBox txtBar;
		private System.Windows.Forms.Label lblBar;
		private System.Windows.Forms.TextBox txtTerm1;
		private System.Windows.Forms.Label lblTerm;
		private System.Windows.Forms.TextBox txtPluv;
		private System.Windows.Forms.Label lblPluv;
		private System.Windows.Forms.TextBox txtIgro;
		private System.Windows.Forms.Label lblIgro;
		private System.Windows.Forms.TextBox txtAnem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAggiungi;
		private System.Windows.Forms.TextBox txtTerm4;
		private System.Windows.Forms.TextBox txtTerm2;
		private System.Windows.Forms.TextBox txtTerm3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

