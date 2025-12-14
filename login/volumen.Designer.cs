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
	partial class volumen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volumen));
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbPiramide = new System.Windows.Forms.RadioButton();
			this.rdbCubo = new System.Windows.Forms.RadioButton();
			this.rdbEsfera = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRadio = new System.Windows.Forms.TextBox();
			this.txtLado = new System.Windows.Forms.TextBox();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbPiramide);
			this.panel1.Controls.Add(this.rdbCubo);
			this.panel1.Controls.Add(this.rdbEsfera);
			this.panel1.Location = new System.Drawing.Point(0, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(396, 64);
			this.panel1.TabIndex = 0;
			// 
			// rdbPiramide
			// 
			this.rdbPiramide.Location = new System.Drawing.Point(268, 26);
			this.rdbPiramide.Name = "rdbPiramide";
			this.rdbPiramide.Size = new System.Drawing.Size(104, 24);
			this.rdbPiramide.TabIndex = 2;
			this.rdbPiramide.TabStop = true;
			this.rdbPiramide.Text = "Piramide";
			this.rdbPiramide.UseVisualStyleBackColor = true;
			// 
			// rdbCubo
			// 
			this.rdbCubo.Location = new System.Drawing.Point(157, 25);
			this.rdbCubo.Name = "rdbCubo";
			this.rdbCubo.Size = new System.Drawing.Size(104, 24);
			this.rdbCubo.TabIndex = 1;
			this.rdbCubo.TabStop = true;
			this.rdbCubo.Text = "Cubo";
			this.rdbCubo.UseVisualStyleBackColor = true;
			// 
			// rdbEsfera
			// 
			this.rdbEsfera.Location = new System.Drawing.Point(35, 26);
			this.rdbEsfera.Name = "rdbEsfera";
			this.rdbEsfera.Size = new System.Drawing.Size(104, 24);
			this.rdbEsfera.TabIndex = 0;
			this.rdbEsfera.TabStop = true;
			this.rdbEsfera.Text = "Esfera";
			this.rdbEsfera.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(138, 68);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(268, 68);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 50);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "radio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(138, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "lado";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(268, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "base";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(268, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Altura";
			// 
			// txtRadio
			// 
			this.txtRadio.Location = new System.Drawing.Point(12, 152);
			this.txtRadio.Name = "txtRadio";
			this.txtRadio.Size = new System.Drawing.Size(100, 20);
			this.txtRadio.TabIndex = 8;
			// 
			// txtLado
			// 
			this.txtLado.Location = new System.Drawing.Point(138, 151);
			this.txtLado.Name = "txtLado";
			this.txtLado.Size = new System.Drawing.Size(100, 20);
			this.txtLado.TabIndex = 9;
			// 
			// txtBase
			// 
			this.txtBase.Location = new System.Drawing.Point(268, 151);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(100, 20);
			this.txtBase.TabIndex = 10;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(268, 210);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 20);
			this.txtAltura.TabIndex = 11;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(403, 24);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 12;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// volumen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 261);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.txtLado);
			this.Controls.Add(this.txtRadio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "volumen";
			this.Text = "volumen";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.TextBox txtLado;
		private System.Windows.Forms.TextBox txtRadio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rdbEsfera;
		private System.Windows.Forms.RadioButton rdbCubo;
		private System.Windows.Forms.RadioButton rdbPiramide;
		private System.Windows.Forms.Panel panel1;
	}
}
