/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 05:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class MainForm
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
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(13, 13);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(100, 23);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuario:";
			// 
			// lblContraseña
			// 
			this.lblContraseña.Location = new System.Drawing.Point(13, 52);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 23);
			this.lblContraseña.TabIndex = 1;
			this.lblContraseña.Text = "Contraseña:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(140, 15);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(140, 54);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(100, 20);
			this.txtContraseña.TabIndex = 3;
			this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseñaTextChanged);
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(13, 92);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 23);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(140, 92);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 130);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblUsuario);
			this.Name = "MainForm";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
	}
}
