/*
 * Created by SharpDevelop.
 * User: CC1_PC09
 * Date: 08/12/2025
 * Time: 02:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using proyecto_final;


namespace proyecto_final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class pasteleria : Form
	{
		string[] Dulces = { "Pastel", "Brownie", "Donas", "Flan", "Helado", "Pay de Queso" };
		string[] Salados = { "Crepas", "Pizza", "Agua Fresca" };



		public pasteleria()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CmbSelectProdSelectedIndexChanged(object sender, EventArgs e)
		{
	
    
		}
		
		void RdbDulceCheckedChanged(object sender, EventArgs e)
		{
			cmbSelectProd.Items.Clear();
           cmbSelectProd.Items.AddRange(Dulces);
            cmbSelectProd.SelectedIndex = 0;
		}
		
		void RdbSaladoCheckedChanged(object sender, EventArgs e)
		{
			if (rdbSalado.Checked)
    {
        cmbSelectProd.Items.Clear(); 
        cmbSelectProd.Items.AddRange(Salados); 
     	cmbSelectProd.SelectedIndex = 0; 
    }

		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{

    string producto = cmbSelectProd.SelectedItem.ToString();
    string precioTexto = txtPrecio.Text;
    string cantidadTexto = txtCantidad.Text;
    decimal precio;
    int cantidad;
    bool precioValido = decimal.TryParse(precioTexto, out precio);
    bool cantidadValida = int.TryParse(cantidadTexto, out cantidad);

    if (!precioValido || !cantidadValida)
    {
        MessageBox.Show("Precio o cantidad inválidos.");
        return;
    }

    decimal total = precio * cantidad;

    ListViewItem item = new ListViewItem(producto);        
    item.SubItems.Add(precio.ToString("0.00"));           
    item.SubItems.Add(cantidad.ToString());                 
    item.SubItems.Add(total.ToString("0.00"));            
    listView1.Items.Add(item);
    txtTotal.Text = total.ToString("0.00");
    txtPrecio.Clear();
    txtCantidad.Clear();
    cmbSelectProd.SelectedIndex = -1;


		}
	}
}
