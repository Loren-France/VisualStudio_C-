namespace EsPuffiFanCosì
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
			this.lblPunteggioG = new System.Windows.Forms.Label();
			this.lblPunteggioP = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.pnlCittà = new System.Windows.Forms.Panel();
			this.pnlGargamella = new System.Windows.Forms.Panel();
			this.pnlCasetta = new System.Windows.Forms.Panel();
			this.pnlPuffo = new System.Windows.Forms.Panel();
			this.pnlCittà.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPunteggioG
			// 
			this.lblPunteggioG.BackColor = System.Drawing.Color.Lime;
			this.lblPunteggioG.Location = new System.Drawing.Point(950, 0);
			this.lblPunteggioG.Name = "lblPunteggioG";
			this.lblPunteggioG.Size = new System.Drawing.Size(177, 24);
			this.lblPunteggioG.TabIndex = 3;
			this.lblPunteggioG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPunteggioP
			// 
			this.lblPunteggioP.BackColor = System.Drawing.Color.Lime;
			this.lblPunteggioP.Location = new System.Drawing.Point(-2, 0);
			this.lblPunteggioP.Name = "lblPunteggioP";
			this.lblPunteggioP.Size = new System.Drawing.Size(141, 24);
			this.lblPunteggioP.TabIndex = 2;
			this.lblPunteggioP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTurno
			// 
			this.lblTurno.BackColor = System.Drawing.Color.Lime;
			this.lblTurno.Location = new System.Drawing.Point(145, 0);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(799, 24);
			this.lblTurno.TabIndex = 4;
			this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlCittà
			// 
			this.pnlCittà.BackgroundImage = global::EsPuffiFanCosì.Properties.Resources.Copilot_20260303_182211;
			this.pnlCittà.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlCittà.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlCittà.Controls.Add(this.pnlGargamella);
			this.pnlCittà.Controls.Add(this.pnlCasetta);
			this.pnlCittà.Controls.Add(this.pnlPuffo);
			this.pnlCittà.Location = new System.Drawing.Point(1, 27);
			this.pnlCittà.Name = "pnlCittà";
			this.pnlCittà.Size = new System.Drawing.Size(1126, 693);
			this.pnlCittà.TabIndex = 0;
			// 
			// pnlGargamella
			// 
			this.pnlGargamella.BackColor = System.Drawing.Color.Black;
			this.pnlGargamella.BackgroundImage = global::EsPuffiFanCosì.Properties.Resources.gargamel_smurfs_the_lost_village_11546805852mrtajxrxqp;
			this.pnlGargamella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnlGargamella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlGargamella.Location = new System.Drawing.Point(627, 393);
			this.pnlGargamella.Name = "pnlGargamella";
			this.pnlGargamella.Size = new System.Drawing.Size(84, 107);
			this.pnlGargamella.TabIndex = 2;
			// 
			// pnlCasetta
			// 
			this.pnlCasetta.BackColor = System.Drawing.Color.Red;
			this.pnlCasetta.BackgroundImage = global::EsPuffiFanCosì.Properties.Resources.fecc1bda2a3cf7c6e5c858d602bb32b7;
			this.pnlCasetta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnlCasetta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlCasetta.Location = new System.Drawing.Point(375, 237);
			this.pnlCasetta.Name = "pnlCasetta";
			this.pnlCasetta.Size = new System.Drawing.Size(84, 107);
			this.pnlCasetta.TabIndex = 1;
			// 
			// pnlPuffo
			// 
			this.pnlPuffo.BackColor = System.Drawing.Color.Blue;
			this.pnlPuffo.BackgroundImage = global::EsPuffiFanCosì.Properties.Resources.brainy_smurf_11530967289fgqvkfukzv;
			this.pnlPuffo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnlPuffo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPuffo.Location = new System.Drawing.Point(741, 112);
			this.pnlPuffo.Name = "pnlPuffo";
			this.pnlPuffo.Size = new System.Drawing.Size(84, 107);
			this.pnlPuffo.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(1130, 723);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.pnlCittà);
			this.Controls.Add(this.lblPunteggioP);
			this.Controls.Add(this.lblPunteggioG);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.pnlCittà.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCittà;
		private System.Windows.Forms.Panel pnlPuffo;
		private System.Windows.Forms.Panel pnlCasetta;
		private System.Windows.Forms.Label lblPunteggioP;
		private System.Windows.Forms.Panel pnlGargamella;
		private System.Windows.Forms.Label lblPunteggioG;
		private System.Windows.Forms.Label lblTurno;
	}
}

