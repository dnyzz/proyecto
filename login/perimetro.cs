/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of perimetro.
	/// </summary>
	public partial class perimetro : Form
	{
		public perimetro()
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
        if (rdbTrapecio.Checked)
        {
            double baseMayor = double.Parse(txtBaseMayor.Text);
            double baseMenor = double.Parse(txtBaseMenor.Text);
            double ladoIzq = double.Parse(txtLadoIzquierdo.Text);
            double ladoDer = double.Parse(txtLadoDerecho.Text);
            double perimetro = baseMayor + baseMenor + ladoIzq + ladoDer;
            MessageBox.Show("Perímetro del trapecio: " + perimetro);
        }
        else if (rdbCirculo.Checked)
        {
            double radio = double.Parse(txtRadio.Text);
            double circunferencia = 2 * Math.PI * radio;
            MessageBox.Show("Circunferencia del círculo: " + circunferencia);
        }
        else
        {
            MessageBox.Show("Selecciona una figura.");
        }
    }
    catch
    {
        MessageBox.Show("ingresa numeros correctos");
    }
}
	
		}
	}

