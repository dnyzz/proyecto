/*
 * Created by SharpDevelop.
 * User: CC1_PC09
 * Date: 08/12/2025
 * Time: 02:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto_final
{
	partial class pasteleria
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
									"PRODUCTO"}, -1, System.Drawing.Color.Red, System.Drawing.Color.Empty, null);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.lblSelectProd = new System.Windows.Forms.Label();
			this.cmbSelectProd = new System.Windows.Forms.ComboBox();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.lblSubT = new System.Windows.Forms.Label();
			this.txtSubT = new System.Windows.Forms.TextBox();
			this.lblDesc = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.lblIImporteNeto = new System.Windows.Forms.Label();
			this.txtImpNet = new System.Windows.Forms.TextBox();
			this.lblImpPag = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.txtImpPag = new System.Windows.Forms.TextBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnImprimir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(0, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(509, 72);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rdbDulce
			// 
			this.rdbDulce.Location = new System.Drawing.Point(76, 75);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(104, 24);
			this.rdbDulce.TabIndex = 1;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "dulce";
			this.rdbDulce.UseVisualStyleBackColor = true;
			// 
			// rdbSalado
			// 
			this.rdbSalado.Location = new System.Drawing.Point(262, 75);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(104, 24);
			this.rdbSalado.TabIndex = 2;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = true;
			// 
			// lblSelectProd
			// 
			this.lblSelectProd.Location = new System.Drawing.Point(12, 102);
			this.lblSelectProd.Name = "lblSelectProd";
			this.lblSelectProd.Size = new System.Drawing.Size(113, 23);
			this.lblSelectProd.TabIndex = 3;
			this.lblSelectProd.Text = "Seleccionar producto";
			// 
			// cmbSelectProd
			// 
			this.cmbSelectProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cmbSelectProd.FormattingEnabled = true;
			this.cmbSelectProd.Location = new System.Drawing.Point(131, 105);
			this.cmbSelectProd.Name = "cmbSelectProd";
			this.cmbSelectProd.Size = new System.Drawing.Size(121, 21);
			this.cmbSelectProd.TabIndex = 4;
			this.cmbSelectProd.SelectedIndexChanged += new System.EventHandler(this.CmbSelectProdSelectedIndexChanged);
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(12, 134);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 23);
			this.lblPrecio.TabIndex = 5;
			this.lblPrecio.Text = "Precio";
			// 
			// lblCantidad
			// 
			this.lblCantidad.Location = new System.Drawing.Point(131, 134);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 23);
			this.lblCantidad.TabIndex = 6;
			this.lblCantidad.Text = "Cantidad";
			// 
			// lblTotal
			// 
			this.lblTotal.Location = new System.Drawing.Point(252, 134);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 7;
			this.lblTotal.Text = "Total";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(372, 134);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(120, 23);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar producto";
			this.btnEliminar.UseVisualStyleBackColor = false;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.ForeColor = System.Drawing.Color.Black;
			this.btnAgregar.Location = new System.Drawing.Point(372, 97);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(120, 23);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar producto";
			this.btnAgregar.UseVisualStyleBackColor = false;
			// 
			// listView1
			// 
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1});
			this.listView1.Location = new System.Drawing.Point(0, 157);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(509, 97);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Tile;
			// 
			// lblSubT
			// 
			this.lblSubT.Location = new System.Drawing.Point(12, 260);
			this.lblSubT.Name = "lblSubT";
			this.lblSubT.Size = new System.Drawing.Size(51, 23);
			this.lblSubT.TabIndex = 11;
			this.lblSubT.Text = "Subtotal:";
			// 
			// txtSubT
			// 
			this.txtSubT.Location = new System.Drawing.Point(56, 260);
			this.txtSubT.Name = "txtSubT";
			this.txtSubT.Size = new System.Drawing.Size(56, 20);
			this.txtSubT.TabIndex = 12;
			// 
			// lblDesc
			// 
			this.lblDesc.Location = new System.Drawing.Point(118, 260);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(67, 23);
			this.lblDesc.TabIndex = 13;
			this.lblDesc.Text = "Descuento:";
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(191, 260);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(100, 20);
			this.txtDesc.TabIndex = 14;
			// 
			// lblIImporteNeto
			// 
			this.lblIImporteNeto.Location = new System.Drawing.Point(298, 260);
			this.lblIImporteNeto.Name = "lblIImporteNeto";
			this.lblIImporteNeto.Size = new System.Drawing.Size(82, 23);
			this.lblIImporteNeto.TabIndex = 15;
			this.lblIImporteNeto.Text = "Importe Neto:";
			// 
			// txtImpNet
			// 
			this.txtImpNet.Location = new System.Drawing.Point(396, 263);
			this.txtImpNet.Name = "txtImpNet";
			this.txtImpNet.Size = new System.Drawing.Size(80, 20);
			this.txtImpNet.TabIndex = 16;
			// 
			// lblImpPag
			// 
			this.lblImpPag.Location = new System.Drawing.Point(298, 290);
			this.lblImpPag.Name = "lblImpPag";
			this.lblImpPag.Size = new System.Drawing.Size(92, 23);
			this.lblImpPag.TabIndex = 17;
			this.lblImpPag.Text = "Importe Pagado:";
			// 
			// lblCambio
			// 
			this.lblCambio.Location = new System.Drawing.Point(298, 323);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(68, 23);
			this.lblCambio.TabIndex = 18;
			this.lblCambio.Text = "Cambio:";
			// 
			// txtImpPag
			// 
			this.txtImpPag.Location = new System.Drawing.Point(396, 290);
			this.txtImpPag.Name = "txtImpPag";
			this.txtImpPag.Size = new System.Drawing.Size(80, 20);
			this.txtImpPag.TabIndex = 19;
			// 
			// txtCambio
			// 
			this.txtCambio.Location = new System.Drawing.Point(396, 323);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(80, 20);
			this.txtCambio.TabIndex = 20;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Location = new System.Drawing.Point(67, 294);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 21;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrar.Location = new System.Drawing.Point(105, 323);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 22;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImprimir.Location = new System.Drawing.Point(156, 294);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 23;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			// 
			// pasteleria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(507, 375);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.txtImpPag);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.lblImpPag);
			this.Controls.Add(this.txtImpNet);
			this.Controls.Add(this.lblIImporteNeto);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.txtSubT);
			this.Controls.Add(this.lblSubT);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.cmbSelectProd);
			this.Controls.Add(this.lblSelectProd);
			this.Controls.Add(this.rdbSalado);
			this.Controls.Add(this.rdbDulce);
			this.Controls.Add(this.pictureBox1);
			this.Name = "pasteleria";
			this.Text = "POSTRES (PASTELERIA)";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.TextBox txtImpPag;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Label lblImpPag;
		private System.Windows.Forms.TextBox txtImpNet;
		private System.Windows.Forms.Label lblIImporteNeto;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.TextBox txtSubT;
		private System.Windows.Forms.Label lblSubT;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.ComboBox cmbSelectProd;
		private System.Windows.Forms.Label lblSelectProd;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
