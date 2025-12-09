/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 06:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of aplicaciones.
	/// </summary>
	public partial class aplicaciones : Form
	{
		public aplicaciones()
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
     int numero = int.Parse(txtResultado.Text);
if (rdbFactorial.Checked)
{
    int fact = 1;
    for (int i = 1; i <= numero; i++)
    {
        fact = fact * i;
    }
    MessageBox.Show(string.Format("Factorial: {0}", fact));
}
else if (rdbFibonacci.Checked)
{
    if (numero == 0)
    {
        MessageBox.Show("Fibonacci: 0");
    }
    else if (numero == 1)
    {
        MessageBox.Show("Fibonacci: 1");
    }
    else
    {
        int a=0, b=1, c=0;
        for (int i = 2; i <= numero; i++)
        {
            c=a+b;
            a=b;
            b=c;
        }
        MessageBox.Show(string.Format("Fibonacci: {0}", c));
    }
}
    
	
		}
	}
		}
	

