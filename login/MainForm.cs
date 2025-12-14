/*
 * Created by SharpDevelop.
 * User: CC2-PC42
 * Date: 08/12/2025
 * Time: 05:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void TxtContraseñaTextChanged(object sender, EventArgs e)
		{
txtContraseña.PasswordChar = '*';			
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
		if (txtUsuario.Text == "root" && txtContraseña.Text == "root")
{

			formulario_principal menu = new formulario_principal();
        menu.Show();                 
        this.Hide();             
}
else
{
    MessageBox.Show("Error");
}

			}
		
				
		}
	}



