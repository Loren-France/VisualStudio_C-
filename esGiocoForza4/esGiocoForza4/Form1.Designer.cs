
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvGriglia = new System.Windows.Forms.DataGridView();
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvGriglia)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvGriglia
			// 
			this.dgvGriglia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGriglia.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvGriglia.Location = new System.Drawing.Point(12, 28);
			this.dgvGriglia.Name = "dgvGriglia";
			this.dgvGriglia.ReadOnly = true;
			this.dgvGriglia.RowHeadersWidth = 51;
			this.dgvGriglia.RowTemplate.Height = 24;
			this.dgvGriglia.Size = new System.Drawing.Size(829, 577);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(849, 611);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.lblTitolo);
			this.Controls.Add(this.dgvGriglia);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGriglia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvGriglia;
		private System.Windows.Forms.Label lblTitolo;
		private Label lblTurno;
	}
}

