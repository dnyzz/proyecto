/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of volumen.
	/// </summary>
	public partial class volumen : Form
	{
		public volumen()
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
        if (rdbEsfera.Checked)
        {
            double radio = double.Parse(txtRadio.Text);
            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
            MessageBox.Show("Volumen de la esfera: " + volumen);
        }
        else if (rdbCubo.Checked)
        {
            double lado = double.Parse(txtLado.Text);
            double volumen = Math.Pow(lado, 3);
            MessageBox.Show("Volumen del cubo: " + volumen);
        }
        else if (rdbPiramide.Checked)
        {
            double baseCuadrada = double.Parse(txtBase.Text);
            double altura = double.Parse(txtAltura.Text);
            double volumen = (1.0 / 3.0) * Math.Pow(baseCuadrada, 2) * altura;
            MessageBox.Show("Volumen de la pirámide: " + volumen);
        }
        else
        {
            MessageBox.Show("Selecciona una figura.");
        }
    }
    catch
    {
        MessageBox.Show("Ingresa valores numéricos válidos.");
    }

		}
	}
}
