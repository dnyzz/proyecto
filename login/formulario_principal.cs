/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 05:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using proyecto_final;
namespace login
{
	/// <summary>
	/// Description of formulario_principal.
	/// </summary>
	public partial class formulario_principal : Form
	{
		public formulario_principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void PasteleriaToolStripMenuItemClick(object sender, EventArgs e)
		{

    pasteleria Past = new pasteleria();
    Past.Show();



		
		}
		
		void AreaToolStripMenuItemClick(object sender, EventArgs e)
		{
		   area areaa = new area();
    areaa.Show();	
		}
		
		void PerimetroToolStripMenuItemClick(object sender, EventArgs e)
		{
			 perimetro per = new perimetro();
    per.Show();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			volumen vol = new volumen();
			vol.Show();
		}
		
		void ConversionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			conversiones con = new conversiones();
			con.Show();
		}
		
		void BoletaDeCalificacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			boleta bol = new boleta();
			bol.Show();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			empleados empl = new empleados();
			empl.Show();
		}
	}
	
}
