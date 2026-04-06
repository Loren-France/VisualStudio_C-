namespace esFantasiaPark
{
	partial class Form_GestioneBiglietti
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitolo = new System.Windows.Forms.Label();
			this.lstBiglietti = new System.Windows.Forms.ListBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.dttData = new System.Windows.Forms.DateTimePicker();
			this.btnCrea = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnElimina = new System.Windows.Forms.Button();
			this.btnCerca = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitolo
			// 
			this.lblTitolo.AutoSize = true;
			this.lblTitolo.BackColor = System.Drawing.Color.Transparent;
			this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.lblTitolo.Location = new System.Drawing.Point(273, 9);
			this.lblTitolo.Name = "lblTitolo";
			this.lblTitolo.Size = new System.Drawing.Size(257, 36);
			this.lblTitolo.TabIndex = 1;
			this.lblTitolo.Text = "Gestione Biglietti";
			this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstBiglietti
			// 
			this.lstBiglietti.FormattingEnabled = true;
			this.lstBiglietti.ItemHeight = 16;
			this.lstBiglietti.Location = new System.Drawing.Point(12, 77);
			this.lstBiglietti.Name = "lstBiglietti";
			this.lstBiglietti.Size = new System.Drawing.Size(543, 388);
			this.lstBiglietti.TabIndex = 2;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(634, 60);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(217, 22);
			this.txtNome.TabIndex = 4;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(634, 114);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(217, 24);
			this.cmbTipo.TabIndex = 5;
			// 
			// dttData
			// 
			this.dttData.Location = new System.Drawing.Point(634, 178);
			this.dttData.Name = "dttData";
			this.dttData.Size = new System.Drawing.Size(217, 22);
			this.dttData.TabIndex = 6;
			this.dttData.Value = new System.DateTime(2026, 3, 31, 9, 13, 38, 0);
			// 
			// btnCrea
			// 
			this.btnCrea.Location = new System.Drawing.Point(677, 226);
			this.btnCrea.Name = "btnCrea";
			this.btnCrea.Size = new System.Drawing.Size(130, 49);
			this.btnCrea.TabIndex = 7;
			this.btnCrea.Text = "Crea biglietto";
			this.btnCrea.UseVisualStyleBackColor = true;
			this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(571, 381);
			this.txtNumero.MaxLength = 4;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(45, 22);
			this.txtNumero.TabIndex = 8;
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
			// 
			// btnElimina
			// 
			this.btnElimina.Location = new System.Drawing.Point(823, 378);
			this.btnElimina.Name = "btnElimina";
			this.btnElimina.Size = new System.Drawing.Size(110, 29);
			this.btnElimina.TabIndex = 9;
			this.btnElimina.Text = "Elimina biglietto";
			this.btnElimina.UseVisualStyleBackColor = true;
			this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
			// 
			// btnCerca
			// 
			this.btnCerca.Location = new System.Drawing.Point(695, 378);
			this.btnCerca.Name = "btnCerca";
			this.btnCerca.Size = new System.Drawing.Size(110, 29);
			this.btnCerca.TabIndex = 10;
			this.btnCerca.Text = "Cerca Biglietto";
			this.btnCerca.UseVisualStyleBackColor = true;
			this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.BackColor = System.Drawing.Color.Transparent;
			this.lblNome.Location = new System.Drawing.Point(647, 25);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(190, 32);
			this.lblNome.TabIndex = 11;
			this.lblNome.Text = "Inserire il nome dell\'intestatario\r\n del biglietto:";
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.BackColor = System.Drawing.Color.Transparent;
			this.lblTipo.Location = new System.Drawing.Point(635, 95);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(215, 16);
			this.lblTipo.TabIndex = 12;
			this.lblTipo.Text = "Selezionare la tipologia di biglietto:";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.BackColor = System.Drawing.Color.Transparent;
			this.lblData.Location = new System.Drawing.Point(665, 143);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(154, 32);
			this.lblData.TabIndex = 13;
			this.lblData.Text = "Inserire la data per cui si \r\nvuole prenotare:";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero.Location = new System.Drawing.Point(571, 343);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(119, 32);
			this.lblNumero.TabIndex = 14;
			this.lblNumero.Text = "Inserire un numero \r\ndi un biglietto:";
			// 
			// Form_GestioneBiglietti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::esFantasiaPark.Properties.Resources.Screenshot_2026_03_31_082243;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(956, 536);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.btnCerca);
			this.Controls.Add(this.btnElimina);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.btnCrea);
			this.Controls.Add(this.dttData);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lstBiglietti);
			this.Controls.Add(this.lblTitolo);
			this.DoubleBuffered = true;
			this.Name = "Form_GestioneBiglietti";
			this.Text = "Gestione Biglietti";
			this.Load += new System.EventHandler(this.Form_GestioneBiglietti_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitolo;
		private System.Windows.Forms.ListBox lstBiglietti;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.DateTimePicker dttData;
		private System.Windows.Forms.Button btnCrea;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnElimina;
		private System.Windows.Forms.Button btnCerca;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblNumero;
	}
}