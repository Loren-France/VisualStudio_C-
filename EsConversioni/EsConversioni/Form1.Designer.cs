namespace EsConversioni
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.cmbSelezione = new System.Windows.Forms.ComboBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.lblInput = new System.Windows.Forms.Label();
			this.lblSelezione = new System.Windows.Forms.Label();
			this.btnConverti = new System.Windows.Forms.Button();
			this.lblConverti2 = new System.Windows.Forms.Label();
			this.lblInput2 = new System.Windows.Forms.Label();
			this.lblOutput2 = new System.Windows.Forms.Label();
			this.cmbConverti2 = new System.Windows.Forms.ComboBox();
			this.txtOutput2 = new System.Windows.Forms.TextBox();
			this.txtInput2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(73, 87);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(163, 22);
			this.txtInput.TabIndex = 1;
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(568, 87);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(177, 22);
			this.txtOutput.TabIndex = 2;
			// 
			// cmbSelezione
			// 
			this.cmbSelezione.FormattingEnabled = true;
			this.cmbSelezione.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
			this.cmbSelezione.Location = new System.Drawing.Point(332, 87);
			this.cmbSelezione.Name = "cmbSelezione";
			this.cmbSelezione.Size = new System.Drawing.Size(121, 24);
			this.cmbSelezione.TabIndex = 3;
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(616, 51);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(84, 33);
			this.lblOutput.TabIndex = 4;
			this.lblOutput.Text = "Output temperatura:";
			// 
			// lblInput
			// 
			this.lblInput.Location = new System.Drawing.Point(101, 51);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(99, 33);
			this.lblInput.TabIndex = 5;
			this.lblInput.Text = "Input temperatura:";
			// 
			// lblSelezione
			// 
			this.lblSelezione.Location = new System.Drawing.Point(353, 51);
			this.lblSelezione.Name = "lblSelezione";
			this.lblSelezione.Size = new System.Drawing.Size(84, 33);
			this.lblSelezione.TabIndex = 6;
			this.lblSelezione.Text = "Output temperatura:";
			this.lblSelezione.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnConverti
			// 
			this.btnConverti.Location = new System.Drawing.Point(332, 160);
			this.btnConverti.Name = "btnConverti";
			this.btnConverti.Size = new System.Drawing.Size(121, 67);
			this.btnConverti.TabIndex = 7;
			this.btnConverti.Text = "Converti";
			this.btnConverti.UseVisualStyleBackColor = true;
			this.btnConverti.Click += new System.EventHandler(this.btnConverti_Click);
			// 
			// lblConverti2
			// 
			this.lblConverti2.Location = new System.Drawing.Point(353, 270);
			this.lblConverti2.Name = "lblConverti2";
			this.lblConverti2.Size = new System.Drawing.Size(84, 33);
			this.lblConverti2.TabIndex = 13;
			this.lblConverti2.Text = "Output temperatura:";
			this.lblConverti2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblInput2
			// 
			this.lblInput2.Location = new System.Drawing.Point(101, 270);
			this.lblInput2.Name = "lblInput2";
			this.lblInput2.Size = new System.Drawing.Size(69, 33);
			this.lblInput2.TabIndex = 12;
			this.lblInput2.Text = "Input distanza:";
			// 
			// lblOutput2
			// 
			this.lblOutput2.Location = new System.Drawing.Point(609, 270);
			this.lblOutput2.Name = "lblOutput2";
			this.lblOutput2.Size = new System.Drawing.Size(91, 33);
			this.lblOutput2.TabIndex = 11;
			this.lblOutput2.Text = "Output distanza:";
			// 
			// cmbConverti2
			// 
			this.cmbConverti2.FormattingEnabled = true;
			this.cmbConverti2.Items.AddRange(new object[] {
            "Kilometri",
            "Miglia"});
			this.cmbConverti2.Location = new System.Drawing.Point(332, 306);
			this.cmbConverti2.Name = "cmbConverti2";
			this.cmbConverti2.Size = new System.Drawing.Size(121, 24);
			this.cmbConverti2.TabIndex = 10;
			// 
			// txtOutput2
			// 
			this.txtOutput2.Location = new System.Drawing.Point(568, 308);
			this.txtOutput2.Multiline = true;
			this.txtOutput2.Name = "txtOutput2";
			this.txtOutput2.ReadOnly = true;
			this.txtOutput2.Size = new System.Drawing.Size(177, 22);
			this.txtOutput2.TabIndex = 9;
			// 
			// txtInput2
			// 
			this.txtInput2.Location = new System.Drawing.Point(73, 306);
			this.txtInput2.Name = "txtInput2";
			this.txtInput2.Size = new System.Drawing.Size(163, 22);
			this.txtInput2.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 480);
			this.Controls.Add(this.lblConverti2);
			this.Controls.Add(this.lblInput2);
			this.Controls.Add(this.lblOutput2);
			this.Controls.Add(this.cmbConverti2);
			this.Controls.Add(this.txtOutput2);
			this.Controls.Add(this.txtInput2);
			this.Controls.Add(this.btnConverti);
			this.Controls.Add(this.lblSelezione);
			this.Controls.Add(this.lblInput);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.cmbSelezione);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.txtInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.ComboBox cmbSelezione;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Label lblSelezione;
		private System.Windows.Forms.Button btnConverti;
		private System.Windows.Forms.Label lblConverti2;
		private System.Windows.Forms.Label lblInput2;
		private System.Windows.Forms.Label lblOutput2;
		private System.Windows.Forms.ComboBox cmbConverti2;
		private System.Windows.Forms.TextBox txtOutput2;
		private System.Windows.Forms.TextBox txtInput2;
	}
}

