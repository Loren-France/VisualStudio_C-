namespace esDanceDanceRevolution
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
			this.pnlDati = new System.Windows.Forms.Panel();
			this.lblNickname = new System.Windows.Forms.Label();
			this.txtNickname = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lblGiocatore = new System.Windows.Forms.Label();
			this.lblPunteggio = new System.Windows.Forms.Label();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btnCentro = new System.Windows.Forms.Button();
			this.pnlDati.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDati
			// 
			this.pnlDati.Controls.Add(this.lblNickname);
			this.pnlDati.Controls.Add(this.txtNickname);
			this.pnlDati.Controls.Add(this.btnStart);
			this.pnlDati.Location = new System.Drawing.Point(1202, 752);
			this.pnlDati.Name = "pnlDati";
			this.pnlDati.Size = new System.Drawing.Size(295, 208);
			this.pnlDati.TabIndex = 0;
			// 
			// lblNickname
			// 
			this.lblNickname.AutoSize = true;
			this.lblNickname.Location = new System.Drawing.Point(23, 20);
			this.lblNickname.Name = "lblNickname";
			this.lblNickname.Size = new System.Drawing.Size(206, 16);
			this.lblNickname.TabIndex = 2;
			this.lblNickname.Text = "Inserire il nickname del giocatore:";
			// 
			// txtNickname
			// 
			this.txtNickname.Location = new System.Drawing.Point(26, 43);
			this.txtNickname.Name = "txtNickname";
			this.txtNickname.Size = new System.Drawing.Size(249, 22);
			this.txtNickname.TabIndex = 1;
			this.txtNickname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNickname_KeyPress);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(92, 107);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(109, 68);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitolo.Location = new System.Drawing.Point(322, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(410, 42);
			this.lblTitolo.TabIndex = 1;
			this.lblTitolo.Text = "Dance Dance Revolution";
			// 
			// lblGiocatore
			// 
			this.lblGiocatore.AutoSize = true;
			this.lblGiocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGiocatore.Location = new System.Drawing.Point(385, 63);
			this.lblGiocatore.Name = "lblGiocatore";
			this.lblGiocatore.Size = new System.Drawing.Size(294, 32);
			this.lblGiocatore.TabIndex = 3;
			this.lblGiocatore.Text = "Giocatore: nickname";
			// 
			// lblPunteggio
			// 
			this.lblPunteggio.AutoSize = true;
			this.lblPunteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPunteggio.Location = new System.Drawing.Point(299, 127);
			this.lblPunteggio.Name = "lblPunteggio";
			this.lblPunteggio.Size = new System.Drawing.Size(111, 25);
			this.lblPunteggio.TabIndex = 9;
			this.lblPunteggio.Text = "Punteggio: ";
			// 
			// btn1
			// 
			this.btn1.BackgroundImage = global::esDanceDanceRevolution.Properties.Resources.freccia_su;
			this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn1.Location = new System.Drawing.Point(466, 172);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(156, 156);
			this.btn1.TabIndex = 8;
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			this.btn2.BackgroundImage = global::esDanceDanceRevolution.Properties.Resources.freccia_sx;
			this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn2.Location = new System.Drawing.Point(304, 334);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(156, 156);
			this.btn2.TabIndex = 7;
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// btn4
			// 
			this.btn4.BackgroundImage = global::esDanceDanceRevolution.Properties.Resources.freccia_giu;
			this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn4.Location = new System.Drawing.Point(466, 496);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(156, 156);
			this.btn4.TabIndex = 6;
			this.btn4.UseVisualStyleBackColor = true;
			// 
			// btn3
			// 
			this.btn3.BackgroundImage = global::esDanceDanceRevolution.Properties.Resources.freccia_dx;
			this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn3.Location = new System.Drawing.Point(628, 334);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(156, 156);
			this.btn3.TabIndex = 5;
			this.btn3.UseVisualStyleBackColor = true;
			// 
			// btnCentro
			// 
			this.btnCentro.BackgroundImage = global::esDanceDanceRevolution.Properties.Resources.centro;
			this.btnCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCentro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCentro.Location = new System.Drawing.Point(466, 334);
			this.btnCentro.Name = "btnCentro";
			this.btnCentro.Size = new System.Drawing.Size(156, 156);
			this.btnCentro.TabIndex = 4;
			this.btnCentro.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1525, 972);
			this.Controls.Add(this.lblPunteggio);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btnCentro);
			this.Controls.Add(this.lblGiocatore);
			this.Controls.Add(this.lblTitolo);
			this.Controls.Add(this.pnlDati);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlDati.ResumeLayout(false);
			this.pnlDati.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlDati;
		private System.Windows.Forms.TextBox txtNickname;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.Label lblNickname;
		private System.Windows.Forms.Label lblGiocatore;
		private System.Windows.Forms.Button btnCentro;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Label lblPunteggio;
	}
}

