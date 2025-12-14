/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class conversiones
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbTemperatura = new System.Windows.Forms.RadioButton();
			this.rdbMasa = new System.Windows.Forms.RadioButton();
			this.rdbLongitud = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.txtKilogramos = new System.Windows.Forms.TextBox();
			this.txtCelcius = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbTemperatura);
			this.panel1.Controls.Add(this.rdbMasa);
			this.panel1.Controls.Add(this.rdbLongitud);
			this.panel1.Location = new System.Drawing.Point(5, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(354, 61);
			this.panel1.TabIndex = 0;
			// 
			// rdbTemperatura
			// 
			this.rdbTemperatura.Location = new System.Drawing.Point(254, 22);
			this.rdbTemperatura.Name = "rdbTemperatura";
			this.rdbTemperatura.Size = new System.Drawing.Size(97, 24);
			this.rdbTemperatura.TabIndex = 2;
			this.rdbTemperatura.TabStop = true;
			this.rdbTemperatura.Text = "Temperatura";
			this.rdbTemperatura.UseVisualStyleBackColor = true;
			// 
			// rdbMasa
			// 
			this.rdbMasa.Location = new System.Drawing.Point(129, 22);
			this.rdbMasa.Name = "rdbMasa";
			this.rdbMasa.Size = new System.Drawing.Size(133, 24);
			this.rdbMasa.TabIndex = 1;
			this.rdbMasa.TabStop = true;
			this.rdbMasa.Text = "Masa";
			this.rdbMasa.UseVisualStyleBackColor = true;
			// 
			// rdbLongitud
			// 
			this.rdbLongitud.Location = new System.Drawing.Point(8, 22);
			this.rdbLongitud.Name = "rdbLongitud";
			this.rdbLongitud.Size = new System.Drawing.Size(115, 24);
			this.rdbLongitud.TabIndex = 0;
			this.rdbLongitud.TabStop = true;
			this.rdbLongitud.Text = "Longitud";
			this.rdbLongitud.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "kilometros:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(134, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "kilogramos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(259, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Celcius";
			// 
			// txtKilometros
			// 
			this.txtKilometros.Location = new System.Drawing.Point(5, 108);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(82, 20);
			this.txtKilometros.TabIndex = 4;
			// 
			// txtKilogramos
			// 
			this.txtKilogramos.Location = new System.Drawing.Point(134, 107);
			this.txtKilogramos.Name = "txtKilogramos";
			this.txtKilogramos.Size = new System.Drawing.Size(79, 20);
			this.txtKilogramos.TabIndex = 5;
			// 
			// txtCelcius
			// 
			this.txtCelcius.Location = new System.Drawing.Point(259, 107);
			this.txtCelcius.Name = "txtCelcius";
			this.txtCelcius.Size = new System.Drawing.Size(73, 20);
			this.txtCelcius.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(5, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "a millas";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(134, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "a libras";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(259, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "a Farenheit";
		
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(138, 184);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 10;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// conversiones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(376, 237);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCelcius);
			this.Controls.Add(this.txtKilogramos);
			this.Controls.Add(this.txtKilometros);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "conversiones";
			this.Text = "conversiones";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCelcius;
		private System.Windows.Forms.TextBox txtKilogramos;
		private System.Windows.Forms.TextBox txtKilometros;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbLongitud;
		private System.Windows.Forms.RadioButton rdbMasa;
		private System.Windows.Forms.RadioButton rdbTemperatura;
		private System.Windows.Forms.Panel panel1;
	}
}
