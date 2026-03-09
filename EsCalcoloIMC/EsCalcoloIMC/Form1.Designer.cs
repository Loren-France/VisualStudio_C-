using System.Windows.Forms;

namespace EsCalcoloIMC
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
			this.lstPersone = new System.Windows.Forms.ListBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.txtCognomeNome = new System.Windows.Forms.TextBox();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.txtAltezza = new System.Windows.Forms.TextBox();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblAltezza = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSalva = new System.Windows.Forms.Button();
			this.btnEsegui = new System.Windows.Forms.Button();
			this.rdbVarianzaIMC = new System.Windows.Forms.RadioButton();
			this.rdbMedianaIMC = new System.Windows.Forms.RadioButton();
			this.rdbModaIMC = new System.Windows.Forms.RadioButton();
			this.rdbMediaIMC = new System.Windows.Forms.RadioButton();
			this.rdbCalcoloIMC = new System.Windows.Forms.RadioButton();
			this.lblCognomeNome = new System.Windows.Forms.Label();
			this.btnFile = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstPersone
			// 
			this.lstPersone.FormattingEnabled = true;
			this.lstPersone.ItemHeight = 16;
			this.lstPersone.Location = new System.Drawing.Point(12, 65);
			this.lstPersone.Name = "lstPersone";
			this.lstPersone.Size = new System.Drawing.Size(766, 260);
			this.lstPersone.TabIndex = 0;
			// 
			// lblOutput
			// 
			this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOutput.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblOutput.Location = new System.Drawing.Point(12, 385);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(766, 56);
			this.lblOutput.TabIndex = 1;
			this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCognomeNome
			// 
			this.txtCognomeNome.Location = new System.Drawing.Point(12, 12);
			this.txtCognomeNome.Multiline = true;
			this.txtCognomeNome.Name = "txtCognomeNome";
			this.txtCognomeNome.Size = new System.Drawing.Size(139, 39);
			this.txtCognomeNome.TabIndex = 2;
			this.txtCognomeNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCognomeNome_KeyPress);
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(310, 22);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(99, 22);
			this.txtPeso.TabIndex = 4;
			this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
			// 
			// txtAltezza
			// 
			this.txtAltezza.Location = new System.Drawing.Point(554, 22);
			this.txtAltezza.Name = "txtAltezza";
			this.txtAltezza.Size = new System.Drawing.Size(101, 22);
			this.txtAltezza.TabIndex = 5;
			this.txtAltezza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltezza_KeyPress);
			// 
			// lblPeso
			// 
			this.lblPeso.Location = new System.Drawing.Point(415, 12);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(123, 42);
			this.lblPeso.TabIndex = 6;
			this.lblPeso.Text = "Peso (in kg)";
			this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAltezza
			// 
			this.lblAltezza.Location = new System.Drawing.Point(661, 12);
			this.lblAltezza.Name = "lblAltezza";
			this.lblAltezza.Size = new System.Drawing.Size(123, 42);
			this.lblAltezza.TabIndex = 7;
			this.lblAltezza.Text = "Altezza (in cm)";
			this.lblAltezza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnFile);
			this.panel1.Controls.Add(this.btnSalva);
			this.panel1.Controls.Add(this.btnEsegui);
			this.panel1.Controls.Add(this.rdbVarianzaIMC);
			this.panel1.Controls.Add(this.rdbMedianaIMC);
			this.panel1.Controls.Add(this.rdbModaIMC);
			this.panel1.Controls.Add(this.rdbMediaIMC);
			this.panel1.Controls.Add(this.rdbCalcoloIMC);
			this.panel1.Location = new System.Drawing.Point(12, 331);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(766, 51);
			this.panel1.TabIndex = 8;
			// 
			// btnSalva
			// 
			this.btnSalva.Location = new System.Drawing.Point(612, 14);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(75, 23);
			this.btnSalva.TabIndex = 6;
			this.btnSalva.Text = "SALVA";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// btnEsegui
			// 
			this.btnEsegui.Location = new System.Drawing.Point(531, 14);
			this.btnEsegui.Name = "btnEsegui";
			this.btnEsegui.Size = new System.Drawing.Size(75, 23);
			this.btnEsegui.TabIndex = 5;
			this.btnEsegui.Text = "ESEGUI";
			this.btnEsegui.UseVisualStyleBackColor = true;
			this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
			// 
			// rdbVarianzaIMC
			// 
			this.rdbVarianzaIMC.AutoSize = true;
			this.rdbVarianzaIMC.Location = new System.Drawing.Point(418, 17);
			this.rdbVarianzaIMC.Name = "rdbVarianzaIMC";
			this.rdbVarianzaIMC.Size = new System.Drawing.Size(107, 20);
			this.rdbVarianzaIMC.TabIndex = 4;
			this.rdbVarianzaIMC.TabStop = true;
			this.rdbVarianzaIMC.Text = "Varianza IMC";
			this.rdbVarianzaIMC.UseVisualStyleBackColor = true;
			// 
			// rdbMedianaIMC
			// 
			this.rdbMedianaIMC.AutoSize = true;
			this.rdbMedianaIMC.Location = new System.Drawing.Point(305, 17);
			this.rdbMedianaIMC.Name = "rdbMedianaIMC";
			this.rdbMedianaIMC.Size = new System.Drawing.Size(107, 20);
			this.rdbMedianaIMC.TabIndex = 3;
			this.rdbMedianaIMC.TabStop = true;
			this.rdbMedianaIMC.Text = "Mediana IMC";
			this.rdbMedianaIMC.UseVisualStyleBackColor = true;
			// 
			// rdbModaIMC
			// 
			this.rdbModaIMC.AutoSize = true;
			this.rdbModaIMC.Location = new System.Drawing.Point(207, 17);
			this.rdbModaIMC.Name = "rdbModaIMC";
			this.rdbModaIMC.Size = new System.Drawing.Size(89, 20);
			this.rdbModaIMC.TabIndex = 2;
			this.rdbModaIMC.TabStop = true;
			this.rdbModaIMC.Text = "Moda IMC";
			this.rdbModaIMC.UseVisualStyleBackColor = true;
			// 
			// rdbMediaIMC
			// 
			this.rdbMediaIMC.AutoSize = true;
			this.rdbMediaIMC.Location = new System.Drawing.Point(109, 17);
			this.rdbMediaIMC.Name = "rdbMediaIMC";
			this.rdbMediaIMC.Size = new System.Drawing.Size(92, 20);
			this.rdbMediaIMC.TabIndex = 1;
			this.rdbMediaIMC.TabStop = true;
			this.rdbMediaIMC.Text = "Media IMC";
			this.rdbMediaIMC.UseVisualStyleBackColor = true;
			// 
			// rdbCalcoloIMC
			// 
			this.rdbCalcoloIMC.AutoSize = true;
			this.rdbCalcoloIMC.Location = new System.Drawing.Point(3, 17);
			this.rdbCalcoloIMC.Name = "rdbCalcoloIMC";
			this.rdbCalcoloIMC.Size = new System.Drawing.Size(100, 20);
			this.rdbCalcoloIMC.TabIndex = 0;
			this.rdbCalcoloIMC.TabStop = true;
			this.rdbCalcoloIMC.Text = "Calcolo IMC";
			this.rdbCalcoloIMC.UseVisualStyleBackColor = true;
			// 
			// lblCognomeNome
			// 
			this.lblCognomeNome.Location = new System.Drawing.Point(157, 12);
			this.lblCognomeNome.Name = "lblCognomeNome";
			this.lblCognomeNome.Size = new System.Drawing.Size(123, 42);
			this.lblCognomeNome.TabIndex = 9;
			this.lblCognomeNome.Text = "Cognome Nome";
			this.lblCognomeNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(688, 3);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(75, 45);
			this.btnFile.TabIndex = 7;
			this.btnFile.Text = "CREA\r\nFILE";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblCognomeNome);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblAltezza);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.txtAltezza);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.txtCognomeNome);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.lstPersone);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstPersone;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.TextBox txtCognomeNome;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.TextBox txtAltezza;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblAltezza;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rdbCalcoloIMC;
		private System.Windows.Forms.Label lblCognomeNome;
		private System.Windows.Forms.RadioButton rdbMediaIMC;
		private System.Windows.Forms.RadioButton rdbVarianzaIMC;
		private System.Windows.Forms.RadioButton rdbMedianaIMC;
		private System.Windows.Forms.RadioButton rdbModaIMC;
		private System.Windows.Forms.Button btnSalva;
		private System.Windows.Forms.Button btnEsegui;
		private Button btnFile;
	}
}

