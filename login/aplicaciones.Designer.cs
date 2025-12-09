/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 06:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class aplicaciones
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
			this.rdbFactorial = new System.Windows.Forms.RadioButton();
			this.rdbFibonacci = new System.Windows.Forms.RadioButton();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdbFactorial
			// 
			this.rdbFactorial.Location = new System.Drawing.Point(27, 12);
			this.rdbFactorial.Name = "rdbFactorial";
			this.rdbFactorial.Size = new System.Drawing.Size(104, 24);
			this.rdbFactorial.TabIndex = 0;
			this.rdbFactorial.TabStop = true;
			this.rdbFactorial.Text = "factorial";
			this.rdbFactorial.UseVisualStyleBackColor = true;
			// 
			// rdbFibonacci
			// 
			this.rdbFibonacci.Location = new System.Drawing.Point(178, 12);
			this.rdbFibonacci.Name = "rdbFibonacci";
			this.rdbFibonacci.Size = new System.Drawing.Size(104, 24);
			this.rdbFibonacci.TabIndex = 1;
			this.rdbFibonacci.TabStop = true;
			this.rdbFibonacci.Text = "Fibonacci";
			this.rdbFibonacci.UseVisualStyleBackColor = true;
			// 
			// txtResultado
			// 
			this.txtResultado.Location = new System.Drawing.Point(64, 51);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(146, 20);
			this.txtResultado.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(96, 77);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// aplicaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 115);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.rdbFibonacci);
			this.Controls.Add(this.rdbFactorial);
			this.Name = "aplicaciones";
			this.Text = "aplicaciones";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.RadioButton rdbFibonacci;
		private System.Windows.Forms.RadioButton rdbFactorial;
	}
}
