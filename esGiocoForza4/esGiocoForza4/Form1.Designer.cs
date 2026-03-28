
using System.Windows.Forms;

namespace esGiocoForza4
{
	partial class Form1 : Form
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvGriglia = new System.Windows.Forms.DataGridView();
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.pnlStat = new System.Windows.Forms.Panel();
			this.lblTitoloVittorie = new System.Windows.Forms.Label();
			this.lblVIttorieRosse = new System.Windows.Forms.Label();
			this.lblVittorieGialle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvGriglia)).BeginInit();
			this.pnlStat.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvGriglia
			// 
			this.dgvGriglia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGriglia.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvGriglia.Location = new System.Drawing.Point(12, 37);
			this.dgvGriglia.Name = "dgvGriglia";
			this.dgvGriglia.ReadOnly = true;
			this.dgvGriglia.RowHeadersWidth = 51;
			this.dgvGriglia.RowTemplate.Height = 24;
			this.dgvGriglia.Size = new System.Drawing.Size(837, 577);
			this.dgvGriglia.TabIndex = 0;
			this.dgvGriglia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGriglia_CellClick);
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.Location = new System.Drawing.Point(412, 5);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(51, 16);
			this.lblTitolo.TabIndex = 1;
			this.lblTitolo.Text = "Forza 4";
			// 
			// lblTurno
			// 
			this.lblTurno.AutoSize = true;
			this.lblTurno.Location = new System.Drawing.Point(9, 5);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(48, 16);
			this.lblTurno.TabIndex = 2;
			this.lblTurno.Text = "Turno: ";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(902, 12);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(109, 26);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// pnlStat
			// 
			this.pnlStat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.pnlStat.Controls.Add(this.lblVittorieGialle);
			this.pnlStat.Controls.Add(this.lblVIttorieRosse);
			this.pnlStat.Controls.Add(this.lblTitoloVittorie);
			this.pnlStat.Location = new System.Drawing.Point(855, 116);
			this.pnlStat.Name = "pnlStat";
			this.pnlStat.Size = new System.Drawing.Size(156, 183);
			this.pnlStat.TabIndex = 4;
			this.pnlStat.Visible = false;
			// 
			// lblTitoloVittorie
			// 
			this.lblTitoloVittorie.AutoSize = true;
			this.lblTitoloVittorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitoloVittorie.Location = new System.Drawing.Point(30, 15);
			this.lblTitoloVittorie.Name = "lblTitoloVittorie";
			this.lblTitoloVittorie.Size = new System.Drawing.Size(96, 29);
			this.lblTitoloVittorie.TabIndex = 0;
			this.lblTitoloVittorie.Text = "Vittorie";
			// 
			// lblVIttorieRosse
			// 
			this.lblVIttorieRosse.AutoSize = true;
			this.lblVIttorieRosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVIttorieRosse.Location = new System.Drawing.Point(21, 80);
			this.lblVIttorieRosse.Name = "lblVIttorieRosse";
			this.lblVIttorieRosse.Size = new System.Drawing.Size(85, 25);
			this.lblVIttorieRosse.TabIndex = 1;
			this.lblVIttorieRosse.Text = "Rosse: ";
			// 
			// lblVittorieGialle
			// 
			this.lblVittorieGialle.AutoSize = true;
			this.lblVittorieGialle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVittorieGialle.Location = new System.Drawing.Point(21, 136);
			this.lblVittorieGialle.Name = "lblVittorieGialle";
			this.lblVittorieGialle.Size = new System.Drawing.Size(80, 25);
			this.lblVittorieGialle.TabIndex = 2;
			this.lblVittorieGialle.Text = "Gialle: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1023, 622);
			this.Controls.Add(this.pnlStat);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.lblTitolo);
			this.Controls.Add(this.dgvGriglia);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGriglia)).EndInit();
			this.pnlStat.ResumeLayout(false);
			this.pnlStat.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvGriglia;
		private System.Windows.Forms.Label lblTitolo;
		private Label lblTurno;
		private Button btnReset;
		private Panel pnlStat;
		private Label lblTitoloVittorie;
		private Label lblVittorieGialle;
		private Label lblVIttorieRosse;
	}
}

