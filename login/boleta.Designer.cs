/*
 * Created by SharpDevelop.
 * User: liset
 * Date: 12/12/2025
 * Time: 04:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
    partial class boleta
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreAlumno;

        private System.Windows.Forms.Label lblParcial1;
        private System.Windows.Forms.Label lblParcial2;
        private System.Windows.Forms.Label lblParcial3;
        private System.Windows.Forms.TextBox txtParcial1;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.TextBox txtParcial3;

        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cboEspecialidad;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.ComboBox cboAsignatura;

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.DataGridView dgvCalificaciones;

        private System.Windows.Forms.Label lblPromedioFinal;
        private System.Windows.Forms.TextBox txtPromedioFinal;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.lblTitulo = new System.Windows.Forms.Label();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.txtNombreAlumno = new System.Windows.Forms.TextBox();
        	this.lblParcial1 = new System.Windows.Forms.Label();
        	this.lblParcial2 = new System.Windows.Forms.Label();
        	this.lblParcial3 = new System.Windows.Forms.Label();
        	this.txtParcial1 = new System.Windows.Forms.TextBox();
        	this.txtParcial2 = new System.Windows.Forms.TextBox();
        	this.txtParcial3 = new System.Windows.Forms.TextBox();
        	this.lblGrado = new System.Windows.Forms.Label();
        	this.cboGrado = new System.Windows.Forms.ComboBox();
        	this.lblEspecialidad = new System.Windows.Forms.Label();
        	this.cboEspecialidad = new System.Windows.Forms.ComboBox();
        	this.lblFecha = new System.Windows.Forms.Label();
        	this.dtpFecha = new System.Windows.Forms.DateTimePicker();
        	this.lblAsignatura = new System.Windows.Forms.Label();
        	this.cboAsignatura = new System.Windows.Forms.ComboBox();
        	this.btnRegistrar = new System.Windows.Forms.Button();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnSalir = new System.Windows.Forms.Button();
        	this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
        	this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.colP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.colP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.colP3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.colPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.colAprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        	this.lblPromedioFinal = new System.Windows.Forms.Label();
        	this.txtPromedioFinal = new System.Windows.Forms.TextBox();
        	((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblTitulo
        	// 
        	this.lblTitulo.AutoSize = true;
        	this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        	this.lblTitulo.Location = new System.Drawing.Point(20, 15);
        	this.lblTitulo.Name = "lblTitulo";
        	this.lblTitulo.Size = new System.Drawing.Size(306, 30);
        	this.lblTitulo.TabIndex = 0;
        	this.lblTitulo.Text = "BOLETA DE CALIFICACIONES";
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Location = new System.Drawing.Point(20, 60);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(100, 13);
        	this.lblNombre.TabIndex = 1;
        	this.lblNombre.Text = "Nombre de Alumno:";
        	// 
        	// txtNombreAlumno
        	// 
        	this.txtNombreAlumno.Location = new System.Drawing.Point(160, 56);
        	this.txtNombreAlumno.Name = "txtNombreAlumno";
        	this.txtNombreAlumno.Size = new System.Drawing.Size(300, 20);
        	this.txtNombreAlumno.TabIndex = 2;
        	// 
        	// lblParcial1
        	// 
        	this.lblParcial1.Location = new System.Drawing.Point(0, 0);
        	this.lblParcial1.Name = "lblParcial1";
        	this.lblParcial1.Size = new System.Drawing.Size(100, 23);
        	this.lblParcial1.TabIndex = 3;
        	this.lblParcial1.Text = "Parcial 1:";
        	// 
        	// lblParcial2
        	// 
        	this.lblParcial2.Location = new System.Drawing.Point(0, 0);
        	this.lblParcial2.Name = "lblParcial2";
        	this.lblParcial2.Size = new System.Drawing.Size(100, 23);
        	this.lblParcial2.TabIndex = 5;
        	// 
        	// lblParcial3
        	// 
        	this.lblParcial3.Location = new System.Drawing.Point(596, 3);
        	this.lblParcial3.Name = "lblParcial3";
        	this.lblParcial3.Size = new System.Drawing.Size(100, 23);
        	this.lblParcial3.TabIndex = 7;
        	this.lblParcial3.Text = "parcial 3";
        	this.lblParcial3.Click += new System.EventHandler(this.LblParcial3Click);
        	// 
        	// txtParcial1
        	// 
        	this.txtParcial1.Location = new System.Drawing.Point(0, 0);
        	this.txtParcial1.Name = "txtParcial1";
        	this.txtParcial1.Size = new System.Drawing.Size(100, 20);
        	this.txtParcial1.TabIndex = 4;
        	// 
        	// txtParcial2
        	// 
        	this.txtParcial2.Location = new System.Drawing.Point(0, 0);
        	this.txtParcial2.Name = "txtParcial2";
        	this.txtParcial2.Size = new System.Drawing.Size(100, 20);
        	this.txtParcial2.TabIndex = 6;
        	// 
        	// txtParcial3
        	// 
        	this.txtParcial3.Location = new System.Drawing.Point(596, 29);
        	this.txtParcial3.Name = "txtParcial3";
        	this.txtParcial3.Size = new System.Drawing.Size(60, 20);
        	this.txtParcial3.TabIndex = 8;
        	// 
        	// lblGrado
        	// 
        	this.lblGrado.Location = new System.Drawing.Point(20, 95);
        	this.lblGrado.Name = "lblGrado";
        	this.lblGrado.Size = new System.Drawing.Size(100, 23);
        	this.lblGrado.TabIndex = 9;
        	this.lblGrado.Text = "Grado:";
        	// 
        	// cboGrado
        	// 
        	this.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboGrado.Items.AddRange(new object[] {
        	        	        	"1°",
        	        	        	"2°",
        	        	        	"3°",
        	        	        	"4°",
        	        	        	"5°",
        	        	        	"6°"});
        	this.cboGrado.Location = new System.Drawing.Point(70, 92);
        	this.cboGrado.Name = "cboGrado";
        	this.cboGrado.Size = new System.Drawing.Size(80, 21);
        	this.cboGrado.TabIndex = 10;
        	// 
        	// lblEspecialidad
        	// 
        	this.lblEspecialidad.Location = new System.Drawing.Point(170, 95);
        	this.lblEspecialidad.Name = "lblEspecialidad";
        	this.lblEspecialidad.Size = new System.Drawing.Size(100, 23);
        	this.lblEspecialidad.TabIndex = 11;
        	this.lblEspecialidad.Text = "Especialidad:";
        	// 
        	// cboEspecialidad
        	// 
        	this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboEspecialidad.Items.AddRange(new object[] {
        	        	        	"Programación",
        	        	        	"Mecatrónica",
        	        	        	"Electrónica",
        	        	        	"Logística",
        	        	        	"Administración"});
        	this.cboEspecialidad.Location = new System.Drawing.Point(255, 92);
        	this.cboEspecialidad.Name = "cboEspecialidad";
        	this.cboEspecialidad.Size = new System.Drawing.Size(205, 21);
        	this.cboEspecialidad.TabIndex = 12;
        	// 
        	// lblFecha
        	// 
        	this.lblFecha.Location = new System.Drawing.Point(480, 95);
        	this.lblFecha.Name = "lblFecha";
        	this.lblFecha.Size = new System.Drawing.Size(100, 23);
        	this.lblFecha.TabIndex = 13;
        	this.lblFecha.Text = "Fecha actual:";
        	// 
        	// dtpFecha
        	// 
        	this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.dtpFecha.Location = new System.Drawing.Point(560, 92);
        	this.dtpFecha.Name = "dtpFecha";
        	this.dtpFecha.Size = new System.Drawing.Size(180, 20);
        	this.dtpFecha.TabIndex = 14;
        	// 
        	// lblAsignatura
        	// 
        	this.lblAsignatura.Location = new System.Drawing.Point(20, 130);
        	this.lblAsignatura.Name = "lblAsignatura";
        	this.lblAsignatura.Size = new System.Drawing.Size(100, 23);
        	this.lblAsignatura.TabIndex = 15;
        	this.lblAsignatura.Text = "Asignatura o Submódulo:";
        	// 
        	// cboAsignatura
        	// 
        	this.cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cboAsignatura.Items.AddRange(new object[] {
        	        	        	"Matemáticas",
        	        	        	"Física",
        	        	        	"Química",
        	        	        	"Programación I",
        	        	        	"Programación II",
        	        	        	"Bases de Datos",
        	        	        	"Mecánica",
        	        	        	"Inglés"});
        	this.cboAsignatura.Location = new System.Drawing.Point(180, 127);
        	this.cboAsignatura.Name = "cboAsignatura";
        	this.cboAsignatura.Size = new System.Drawing.Size(300, 21);
        	this.cboAsignatura.TabIndex = 16;
        	// 
        	// btnRegistrar
        	// 
        	this.btnRegistrar.Location = new System.Drawing.Point(500, 123);
        	this.btnRegistrar.Name = "btnRegistrar";
        	this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
        	this.btnRegistrar.TabIndex = 17;
        	this.btnRegistrar.Text = "Registrar";
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(610, 123);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(75, 23);
        	this.btnCancelar.TabIndex = 18;
        	this.btnCancelar.Text = "Cancelar";
        	// 
        	// btnSalir
        	// 
        	this.btnSalir.Location = new System.Drawing.Point(720, 123);
        	this.btnSalir.Name = "btnSalir";
        	this.btnSalir.Size = new System.Drawing.Size(75, 23);
        	this.btnSalir.TabIndex = 19;
        	this.btnSalir.Text = "Salir";
        	// 
        	// dgvCalificaciones
        	// 
        	this.dgvCalificaciones.AllowUserToAddRows = false;
        	this.dgvCalificaciones.AllowUserToDeleteRows = false;
        	this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgvCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        	        	        	this.colAsignatura,
        	        	        	this.colP1,
        	        	        	this.colP2,
        	        	        	this.colP3,
        	        	        	this.colPromedio,
        	        	        	this.colAprobado});
        	this.dgvCalificaciones.Location = new System.Drawing.Point(20, 176);
        	this.dgvCalificaciones.Name = "dgvCalificaciones";
        	this.dgvCalificaciones.RowHeadersVisible = false;
        	this.dgvCalificaciones.Size = new System.Drawing.Size(795, 334);
        	this.dgvCalificaciones.TabIndex = 20;
        	// 
        	// colAsignatura
        	// 
        	this.colAsignatura.HeaderText = "Asignatura";
        	this.colAsignatura.Name = "colAsignatura";
        	// 
        	// colP1
        	// 
        	this.colP1.HeaderText = "Parcial 1";
        	this.colP1.Name = "colP1";
        	// 
        	// colP2
        	// 
        	this.colP2.HeaderText = "Parcial 2";
        	this.colP2.Name = "colP2";
        	// 
        	// colP3
        	// 
        	this.colP3.HeaderText = "Parcial 3";
        	this.colP3.Name = "colP3";
        	// 
        	// colPromedio
        	// 
        	this.colPromedio.HeaderText = "Promedio";
        	this.colPromedio.Name = "colPromedio";
        	// 
        	// colAprobado
        	// 
        	this.colAprobado.HeaderText = "Aprobado";
        	this.colAprobado.Name = "colAprobado";
        	// 
        	// lblPromedioFinal
        	// 
        	this.lblPromedioFinal.Location = new System.Drawing.Point(20, 525);
        	this.lblPromedioFinal.Name = "lblPromedioFinal";
        	this.lblPromedioFinal.Size = new System.Drawing.Size(100, 23);
        	this.lblPromedioFinal.TabIndex = 21;
        	this.lblPromedioFinal.Text = "PROMEDIO FINAL:";
        	// 
        	// txtPromedioFinal
        	// 
        	this.txtPromedioFinal.Location = new System.Drawing.Point(140, 521);
        	this.txtPromedioFinal.Name = "txtPromedioFinal";
        	this.txtPromedioFinal.ReadOnly = true;
        	this.txtPromedioFinal.Size = new System.Drawing.Size(80, 20);
        	this.txtPromedioFinal.TabIndex = 22;
        	// 
        	// boleta
        	// 
        	this.ClientSize = new System.Drawing.Size(900, 600);
        	this.Controls.Add(this.lblTitulo);
        	this.Controls.Add(this.lblNombre);
        	this.Controls.Add(this.txtNombreAlumno);
        	this.Controls.Add(this.lblParcial1);
        	this.Controls.Add(this.txtParcial1);
        	this.Controls.Add(this.lblParcial2);
        	this.Controls.Add(this.txtParcial2);
        	this.Controls.Add(this.lblParcial3);
        	this.Controls.Add(this.txtParcial3);
        	this.Controls.Add(this.lblGrado);
        	this.Controls.Add(this.cboGrado);
        	this.Controls.Add(this.lblEspecialidad);
        	this.Controls.Add(this.cboEspecialidad);
        	this.Controls.Add(this.lblFecha);
        	this.Controls.Add(this.dtpFecha);
        	this.Controls.Add(this.lblAsignatura);
        	this.Controls.Add(this.cboAsignatura);
        	this.Controls.Add(this.btnRegistrar);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnSalir);
        	this.Controls.Add(this.dgvCalificaciones);
        	this.Controls.Add(this.lblPromedioFinal);
        	this.Controls.Add(this.txtPromedioFinal);
        	this.Name = "boleta";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "BOLETA DE CALIFICACIONES - CBTIS 217";
        	((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
    }
}