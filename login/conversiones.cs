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
	/// Description of conversiones.
	/// </summary>
	public partial class conversiones : Form
	{
		public conversiones()
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
        if (rdbLongitud.Checked)
        {
            double km = double.Parse(txtKilometros.Text);
            double millas = km * 0.621371;
            MessageBox.Show("Kilómetros a millas: " + millas);
        }
        else if (rdbMasa.Checked)
        {
            double kg = double.Parse(txtKilogramos.Text);
            double libras = kg * 2.20462;
            MessageBox.Show("Kilogramos a libras: " + libras);
        }
        else if (rdbTemperatura.Checked)
        {
            double celcius = double.Parse(txtCelcius.Text);
            double fahrenheit = (celcius * 9 / 5) + 32;
            MessageBox.Show("Celsius a Fahrenheit: " + fahrenheit);
        }
        else
        {
            MessageBox.Show("Selecciona una categoría de conversión.");
        }
    }
    catch
    {
        MessageBox.Show("Ingresa valores numéricos válidos.");
    }

		}
	}
}
