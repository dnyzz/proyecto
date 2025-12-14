/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class perimetro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perimetro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbCirculo = new System.Windows.Forms.RadioButton();
			this.rdbTrapecio = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBaseMayor = new System.Windows.Forms.TextBox();
			this.txtBaseMenor = new System.Windows.Forms.TextBox();
			this.txtLadoIzquierdo = new System.Windows.Forms.TextBox();
			this.txtLadoDerecho = new System.Windows.Forms.TextBox();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbCirculo);
			this.panel1.Controls.Add(this.rdbTrapecio);
			this.panel1.Location = new System.Drawing.Point(-2, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(249, 57);
			this.panel1.TabIndex = 1;
			// 
			// rdbCirculo
			// 
			this.rdbCirculo.Location = new System.Drawing.Point(146, 23);
			this.rdbCirculo.Name = "rdbCirculo";
			this.rdbCirculo.Size = new System.Drawing.Size(100, 24);
			this.rdbCirculo.TabIndex = 1;
			this.rdbCirculo.TabStop = true;
			this.rdbCirculo.Text = "Circulo";
			this.rdbCirculo.UseVisualStyleBackColor = true;
			// 
			// rdbTrapecio
			// 
			this.rdbTrapecio.Location = new System.Drawing.Point(15, 23);
			this.rdbTrapecio.Name = "rdbTrapecio";
			this.rdbTrapecio.Size = new System.Drawing.Size(104, 24);
			this.rdbTrapecio.TabIndex = 0;
			this.rdbTrapecio.TabStop = true;
			this.rdbTrapecio.Text = "Trapecio";
			this.rdbTrapecio.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 50);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(145, 62);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(60, 50);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(263, 22);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-2, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Base Mayor";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-2, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Base Menor";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-2, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Lado izquierdo";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-2, 257);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "lado derecho";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(144, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "radio";
			// 
			// txtBaseMayor
			// 
			this.txtBaseMayor.Location = new System.Drawing.Point(-2, 147);
			this.txtBaseMayor.Name = "txtBaseMayor";
			this.txtBaseMayor.Size = new System.Drawing.Size(100, 20);
			this.txtBaseMayor.TabIndex = 10;
			// 
			// txtBaseMenor
			// 
			this.txtBaseMenor.Location = new System.Drawing.Point(-2, 192);
			this.txtBaseMenor.Name = "txtBaseMenor";
			this.txtBaseMenor.Size = new System.Drawing.Size(100, 20);
			this.txtBaseMenor.TabIndex = 11;
			// 
			// txtLadoIzquierdo
			// 
			this.txtLadoIzquierdo.Location = new System.Drawing.Point(-2, 234);
			this.txtLadoIzquierdo.Name = "txtLadoIzquierdo";
			this.txtLadoIzquierdo.Size = new System.Drawing.Size(100, 20);
			this.txtLadoIzquierdo.TabIndex = 12;
			// 
			// txtLadoDerecho
			// 
			this.txtLadoDerecho.Location = new System.Drawing.Point(-2, 280);
			this.txtLadoDerecho.Name = "txtLadoDerecho";
			this.txtLadoDerecho.Size = new System.Drawing.Size(100, 20);
			this.txtLadoDerecho.TabIndex = 13;
			// 
			// txtRadio
			// 
			this.txtRadio.Location = new System.Drawing.Point(145, 147);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(100, 20);
			this.txtRadio.TabIndex = 14;
			// 
			// perimetro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(361, 312);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.txtLadoDerecho);
			this.Controls.Add(this.txtLadoIzquierdo);
			this.Controls.Add(this.txtBaseMenor);
			this.Controls.Add(this.txtBaseMayor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "perimetro";
			this.Text = "perimetro";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.TextBox txtLadoDerecho;
		private System.Windows.Forms.TextBox txtLadoIzquierdo;
		private System.Windows.Forms.TextBox txtBaseMenor;
		private System.Windows.Forms.TextBox txtBaseMayor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rdbTrapecio;
		private System.Windows.Forms.RadioButton rdbCirculo;
		private System.Windows.Forms.Panel panel1;
	}
}
