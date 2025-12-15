/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of boleta.
	/// </summary>
	public partial class boleta : Form
	{
		public boleta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}


        
        void BtnRegistrarClick(object sender, EventArgs e)
        {
        	 double p1 = 0, p2 = 0, p3 = 0;
            double.TryParse(txtPrimerParcial.Text, out p1);
            double.TryParse(txtSegundoParcial.Text, out p2);
            double.TryParse(txtTercerParcial.Text, out p3);

            double promedio = (p1 + p2 + p3) / 3.0;
            string aprobado = promedio >= 6.0 ? "Sí" : "No";

            var fila = new ListViewItem(cboAsignatura.Text ?? string.Empty);
            fila.SubItems.Add(p1.ToString("0.00"));
            fila.SubItems.Add(p2.ToString("0.00"));
            fila.SubItems.Add(p3.ToString("0.00"));
            fila.SubItems.Add(promedio.ToString("0.00"));
            fila.SubItems.Add(aprobado);
            listView1.Items.Add(fila);

            double suma = 0;
            int total = listView1.Items.Count;
            foreach (ListViewItem item in listView1.Items)
            {
                double prom;
                if (double.TryParse(item.SubItems[4].Text, out prom))
                    suma += prom;
            }
            txtPromedioFinal.Text = (total > 0 ? (suma / total).ToString("0.00") : "0.00");

        }
	
	
	
      
	
        }
	}


