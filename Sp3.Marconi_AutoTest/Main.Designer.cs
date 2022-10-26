namespace Sp3.Marconi_AutoTest
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcTurnos = new System.Windows.Forms.GroupBox();
            this.numFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNumerodeturno = new System.Windows.Forms.TextBox();
            this.lblNumerodeturno = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.txtAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidaddeturnos = new System.Windows.Forms.TextBox();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblAntiguo = new System.Windows.Forms.Label();
            this.lblCantidaddeturnos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFabricacion)).BeginInit();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTurnos
            // 
            this.mrcTurnos.Controls.Add(this.numFabricacion);
            this.mrcTurnos.Controls.Add(this.txtTitular);
            this.mrcTurnos.Controls.Add(this.txtDominio);
            this.mrcTurnos.Controls.Add(this.txtNumerodeturno);
            this.mrcTurnos.Controls.Add(this.lblNumerodeturno);
            this.mrcTurnos.Controls.Add(this.lblDominio);
            this.mrcTurnos.Controls.Add(this.lblFabricacion);
            this.mrcTurnos.Controls.Add(this.lblTitular);
            this.mrcTurnos.Location = new System.Drawing.Point(12, 12);
            this.mrcTurnos.Name = "mrcTurnos";
            this.mrcTurnos.Size = new System.Drawing.Size(608, 213);
            this.mrcTurnos.TabIndex = 0;
            this.mrcTurnos.TabStop = false;
            this.mrcTurnos.Text = "Registro de Turnos";
            this.mrcTurnos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numFabricacion
            // 
            this.numFabricacion.Location = new System.Drawing.Point(131, 122);
            this.numFabricacion.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numFabricacion.Name = "numFabricacion";
            this.numFabricacion.Size = new System.Drawing.Size(69, 20);
            this.numFabricacion.TabIndex = 3;
            this.numFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numFabricacion.ValueChanged += new System.EventHandler(this.numFabricacion_ValueChanged);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(134, 165);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(404, 20);
            this.txtTitular.TabIndex = 10;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(134, 77);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(117, 20);
            this.txtDominio.TabIndex = 11;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged);
            //this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            // 
            // txtNumerodeturno
            // 
            this.txtNumerodeturno.Location = new System.Drawing.Point(134, 43);
            this.txtNumerodeturno.MaxLength = 99999;
            this.txtNumerodeturno.Name = "txtNumerodeturno";
            this.txtNumerodeturno.Size = new System.Drawing.Size(76, 20);
            this.txtNumerodeturno.TabIndex = 12;
            this.txtNumerodeturno.TextChanged += new System.EventHandler(this.txtNumerodeturno_TextChanged);
            this.txtNumerodeturno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerodeturno_KeyPress);
            // 
            // lblNumerodeturno
            // 
            this.lblNumerodeturno.AutoSize = true;
            this.lblNumerodeturno.Location = new System.Drawing.Point(16, 46);
            this.lblNumerodeturno.Name = "lblNumerodeturno";
            this.lblNumerodeturno.Size = new System.Drawing.Size(90, 13);
            this.lblNumerodeturno.TabIndex = 3;
            this.lblNumerodeturno.Text = "Numero de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(16, 80);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 4;
            this.lblDominio.Text = "Dominio";
            // 
            // lblFabricacion
            // 
            this.lblFabricacion.AutoSize = true;
            this.lblFabricacion.Location = new System.Drawing.Point(16, 122);
            this.lblFabricacion.Name = "lblFabricacion";
            this.lblFabricacion.Size = new System.Drawing.Size(99, 13);
            this.lblFabricacion.TabIndex = 5;
            this.lblFabricacion.Text = "Año de Fabricacion";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(16, 168);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 6;
            this.lblTitular.Text = "Titular";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txtCaracteres);
            this.mrcEstadisticas.Controls.Add(this.txtAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantidaddeturnos);
            this.mrcEstadisticas.Controls.Add(this.lblCaracteres);
            this.mrcEstadisticas.Controls.Add(this.lblAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantidaddeturnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(12, 251);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(608, 159);
            this.mrcEstadisticas.TabIndex = 0;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Enabled = false;
            this.txtCaracteres.Location = new System.Drawing.Point(243, 118);
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(100, 20);
            this.txtCaracteres.TabIndex = 13;
            // 
            // txtAntiguo
            // 
            this.txtAntiguo.Enabled = false;
            this.txtAntiguo.Location = new System.Drawing.Point(243, 81);
            this.txtAntiguo.Name = "txtAntiguo";
            this.txtAntiguo.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguo.TabIndex = 14;
            // 
            // txtCantidaddeturnos
            // 
            this.txtCantidaddeturnos.Enabled = false;
            this.txtCantidaddeturnos.Location = new System.Drawing.Point(243, 45);
            this.txtCantidaddeturnos.Name = "txtCantidaddeturnos";
            this.txtCantidaddeturnos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidaddeturnos.TabIndex = 15;
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(16, 121);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(194, 13);
            this.lblCaracteres.TabIndex = 9;
            this.lblCaracteres.Text = "Cantidad de Dominios con 6 Caracteres";
            // 
            // lblAntiguo
            // 
            this.lblAntiguo.AutoSize = true;
            this.lblAntiguo.Location = new System.Drawing.Point(16, 84);
            this.lblAntiguo.Name = "lblAntiguo";
            this.lblAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblAntiguo.TabIndex = 8;
            this.lblAntiguo.Text = "Año del mas Antiguo";
            // 
            // lblCantidaddeturnos
            // 
            this.lblCantidaddeturnos.AutoSize = true;
            this.lblCantidaddeturnos.Location = new System.Drawing.Point(16, 48);
            this.lblCantidaddeturnos.Name = "lblCantidaddeturnos";
            this.lblCantidaddeturnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantidaddeturnos.TabIndex = 7;
            this.lblCantidaddeturnos.Text = "Cantidad de Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(660, 30);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 41);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(660, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 43);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(660, 265);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 47);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcTurnos);
            this.Name = "Main";
            this.Text = "Auto Test";
            this.mrcTurnos.ResumeLayout(false);
            this.mrcTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFabricacion)).EndInit();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTurnos;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.NumericUpDown numFabricacion;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumerodeturno;
        private System.Windows.Forms.Label lblNumerodeturno;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblFabricacion;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.TextBox txtAntiguo;
        private System.Windows.Forms.TextBox txtCantidaddeturnos;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblAntiguo;
        private System.Windows.Forms.Label lblCantidaddeturnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}

