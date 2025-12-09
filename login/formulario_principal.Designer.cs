/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 05:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class formulario_principal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.factorialfibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialfibonacciToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.circunferenciaToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaDeCalificacionesToolStripMenuItem,
									this.pasteleriaToolStripMenuItem,
									this.empleadosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(655, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// factorialfibonacciToolStripMenuItem
			// 
			this.factorialfibonacciToolStripMenuItem.Name = "factorialfibonacciToolStripMenuItem";
			this.factorialfibonacciToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.factorialfibonacciToolStripMenuItem.Text = "Aplicaciones";
			this.factorialfibonacciToolStripMenuItem.Click += new System.EventHandler(this.FactorialfibonacciToolStripMenuItemClick);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.areaToolStripMenuItem.Text = "Area";
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.perimetroToolStripMenuItem.Text = "perimetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.circunferenciaToolStripMenuItem.Text = "volumen";
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.conversionesToolStripMenuItem.Text = "conversiones";
			// 
			// boletaDeCalificacionesToolStripMenuItem
			// 
			this.boletaDeCalificacionesToolStripMenuItem.Name = "boletaDeCalificacionesToolStripMenuItem";
			this.boletaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
			this.boletaDeCalificacionesToolStripMenuItem.Text = "boleta de calificaciones";
			// 
			// pasteleriaToolStripMenuItem
			// 
			this.pasteleriaToolStripMenuItem.Name = "pasteleriaToolStripMenuItem";
			this.pasteleriaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.pasteleriaToolStripMenuItem.Text = "pasteleria";
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.empleadosToolStripMenuItem.Text = "empleados";
			// 
			// formulario_principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "formulario_principal";
			this.Text = "formulario_principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteleriaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boletaDeCalificacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialfibonacciToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		void FactorialfibonacciToolStripMenuItemClick(object sender, System.EventArgs e)
		{
		aplicaciones app = new aplicaciones();
        app.Show();                  
        this.Hide();            	
		}
	}
}
