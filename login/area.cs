/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of area.
	/// </summary>
	public partial class area : Form
	{
		public area()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		void BtnCalcularClick(object sender, EventArgs e)
		{
	
    try
    {
        double alto = double.Parse(txtAlto.Text);
        double ancho = double.Parse(txtAncho.Text);
        double area = 0;

        if (rdbCuadrado.Checked)
        {
            area = alto * alto;
        }
        else if (rdbRectangulo.Checked)
        {
            area = alto * ancho;
        }
        else if (rdbTriangulo.Checked)
        {
            area = (alto * ancho) / 2;
        }
        else
        {
            MessageBox.Show("Selecciona una figura");
            return;
        }

        MessageBox.Show("El área es: " + area);
    }
    catch
    {
        MessageBox.Show("ingresa numeros validos");
    }

		}
}
}
	
