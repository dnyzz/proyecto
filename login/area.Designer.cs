/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class area
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(area));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbTriangulo = new System.Windows.Forms.RadioButton();
			this.rdbRectangulo = new System.Windows.Forms.RadioButton();
			this.rdbCuadrado = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAlto = new System.Windows.Forms.TextBox();
			this.txtAncho = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(92, 50);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(63, 64);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(161, 40);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(79, 74);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbTriangulo);
			this.panel1.Controls.Add(this.rdbRectangulo);
			this.panel1.Controls.Add(this.rdbCuadrado);
			this.panel1.Location = new System.Drawing.Point(-4, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(286, 46);
			this.panel1.TabIndex = 6;
			// 
			// rdbTriangulo
			// 
			this.rdbTriangulo.Location = new System.Drawing.Point(165, 14);
			this.rdbTriangulo.Name = "rdbTriangulo";
			this.rdbTriangulo.Size = new System.Drawing.Size(104, 24);
			this.rdbTriangulo.TabIndex = 2;
			this.rdbTriangulo.TabStop = true;
			this.rdbTriangulo.Text = "Triangulo";
			this.rdbTriangulo.UseVisualStyleBackColor = true;
			// 
			// rdbRectangulo
			// 
			this.rdbRectangulo.Location = new System.Drawing.Point(96, 13);
			this.rdbRectangulo.Name = "rdbRectangulo";
			this.rdbRectangulo.Size = new System.Drawing.Size(104, 24);
			this.rdbRectangulo.TabIndex = 1;
			this.rdbRectangulo.TabStop = true;
			this.rdbRectangulo.Text = "Rectangulo";
			this.rdbRectangulo.UseVisualStyleBackColor = true;
			// 
			// rdbCuadrado
			// 
			this.rdbCuadrado.Location = new System.Drawing.Point(16, 14);
			this.rdbCuadrado.Name = "rdbCuadrado";
			this.rdbCuadrado.Size = new System.Drawing.Size(104, 24);
			this.rdbCuadrado.TabIndex = 0;
			this.rdbCuadrado.TabStop = true;
			this.rdbCuadrado.Text = "cuadrado";
			this.rdbCuadrado.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(278, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "alto:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(278, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "ancho:";
			// 
			// txtAlto
			// 
			this.txtAlto.Location = new System.Drawing.Point(322, 48);
			this.txtAlto.Name = "txtAlto";
			this.txtAlto.Size = new System.Drawing.Size(100, 20);
			this.txtAlto.TabIndex = 9;
			// 
			// txtAncho
			// 
			this.txtAncho.Location = new System.Drawing.Point(322, 78);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(100, 20);
			this.txtAncho.TabIndex = 10;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(190, 141);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 11;
			this.btnCalcular.Text = "calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// area
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 185);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtAncho);
			this.Controls.Add(this.txtAlto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "area";
			this.Text = "area";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.TextBox txtAlto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbCuadrado;
		private System.Windows.Forms.RadioButton rdbRectangulo;
		private System.Windows.Forms.RadioButton rdbTriangulo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
