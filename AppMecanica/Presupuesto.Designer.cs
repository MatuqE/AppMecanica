﻿namespace AppMecanica
{
    partial class Presupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVolverPresupuesto = new Button();
            btnGuardar = new Button();
            txtTitular = new TextBox();
            lblPatente = new Label();
            lblTitular = new Label();
            lblMarca = new Label();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblModelo = new Label();
            lblAño = new Label();
            txtModelo = new TextBox();
            txtAño = new TextBox();
            lblCantidadHoras = new Label();
            lblPrecioHora = new Label();
            txtCantidadHoras = new TextBox();
            txtPrecioHora = new TextBox();
            dataGridView1 = new DataGridView();
            NombreRespuesto = new DataGridViewTextBoxColumn();
            CantidadRepuesto = new DataGridViewTextBoxColumn();
            PrecioRepuesto = new DataGridViewTextBoxColumn();
            lblNombreRepo = new Label();
            txtNombreRepo = new TextBox();
            nupCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecioUni = new TextBox();
            lblPrecioUni = new Label();
            btnAgregarPresu = new Button();
            btnEliminarPresu = new Button();
            groupBox1 = new GroupBox();
            txtKm = new TextBox();
            lblKm = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            lblTelefono = new Label();
            groupBox2 = new GroupBox();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            labelDesc = new Label();
            textBoxDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolverPresupuesto
            // 
            btnVolverPresupuesto.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverPresupuesto.Location = new Point(909, 595);
            btnVolverPresupuesto.Margin = new Padding(3, 2, 3, 2);
            btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            btnVolverPresupuesto.Size = new Size(116, 38);
            btnVolverPresupuesto.TabIndex = 2;
            btnVolverPresupuesto.Text = "Volver";
            btnVolverPresupuesto.UseVisualStyleBackColor = true;
            btnVolverPresupuesto.Click += btnVolverPresupuesto_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(909, 31);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar En Registros";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(142, 25);
            txtTitular.Margin = new Padding(3, 2, 3, 2);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(153, 25);
            txtTitular.TabIndex = 4;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPatente.Location = new Point(355, 60);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(65, 20);
            lblPatente.TabIndex = 5;
            lblPatente.Text = "Patente:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTitular.Location = new Point(75, 30);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(58, 20);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblMarca.Location = new Point(360, 27);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(56, 20);
            lblMarca.TabIndex = 8;
            lblMarca.Text = "Marca:";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(422, 55);
            txtPatente.Margin = new Padding(3, 2, 3, 2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(153, 25);
            txtPatente.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(422, 22);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(153, 25);
            txtMarca.TabIndex = 11;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblModelo.Location = new Point(9, 134);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(128, 20);
            lblModelo.TabIndex = 12;
            lblModelo.Text = "Modelo del Auto:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblAño.Location = new Point(375, 132);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(41, 20);
            lblAño.TabIndex = 13;
            lblAño.Text = "Año:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(141, 129);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(153, 25);
            txtModelo.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(422, 127);
            txtAño.Margin = new Padding(3, 2, 3, 2);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(153, 25);
            txtAño.TabIndex = 15;
            // 
            // lblCantidadHoras
            // 
            lblCantidadHoras.AutoSize = true;
            lblCantidadHoras.BackColor = Color.LightSkyBlue;
            lblCantidadHoras.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidadHoras.Location = new Point(104, 500);
            lblCantidadHoras.Name = "lblCantidadHoras";
            lblCantidadHoras.Size = new Size(210, 20);
            lblCantidadHoras.TabIndex = 18;
            lblCantidadHoras.Text = "Cantidad de Horas Estimadas:";
            // 
            // lblPrecioHora
            // 
            lblPrecioHora.AutoSize = true;
            lblPrecioHora.BackColor = Color.LightSkyBlue;
            lblPrecioHora.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioHora.Location = new Point(438, 500);
            lblPrecioHora.Name = "lblPrecioHora";
            lblPrecioHora.Size = new Size(121, 20);
            lblPrecioHora.TabIndex = 19;
            lblPrecioHora.Text = "Precio Por Hora:";
            // 
            // txtCantidadHoras
            // 
            txtCantidadHoras.Location = new Point(320, 497);
            txtCantidadHoras.Margin = new Padding(3, 2, 3, 2);
            txtCantidadHoras.Name = "txtCantidadHoras";
            txtCantidadHoras.Size = new Size(64, 23);
            txtCantidadHoras.TabIndex = 20;
            // 
            // txtPrecioHora
            // 
            txtPrecioHora.Location = new Point(565, 497);
            txtPrecioHora.Margin = new Padding(3, 2, 3, 2);
            txtPrecioHora.Name = "txtPrecioHora";
            txtPrecioHora.Size = new Size(69, 23);
            txtPrecioHora.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreRespuesto, CantidadRepuesto, PrecioRepuesto });
            dataGridView1.Location = new Point(104, 342);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 139);
            dataGridView1.TabIndex = 26;
            // 
            // NombreRespuesto
            // 
            NombreRespuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombreRespuesto.HeaderText = "Nombre Repuesto";
            NombreRespuesto.MinimumWidth = 6;
            NombreRespuesto.Name = "NombreRespuesto";
            NombreRespuesto.ReadOnly = true;
            NombreRespuesto.Width = 350;
            // 
            // CantidadRepuesto
            // 
            CantidadRepuesto.HeaderText = "Cantidad";
            CantidadRepuesto.MinimumWidth = 6;
            CantidadRepuesto.Name = "CantidadRepuesto";
            CantidadRepuesto.ReadOnly = true;
            // 
            // PrecioRepuesto
            // 
            PrecioRepuesto.HeaderText = "Precio";
            PrecioRepuesto.MinimumWidth = 6;
            PrecioRepuesto.Name = "PrecioRepuesto";
            PrecioRepuesto.ReadOnly = true;
            // 
            // lblNombreRepo
            // 
            lblNombreRepo.AutoSize = true;
            lblNombreRepo.BackColor = Color.LightSkyBlue;
            lblNombreRepo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblNombreRepo.Location = new Point(8, 24);
            lblNombreRepo.Name = "lblNombreRepo";
            lblNombreRepo.Size = new Size(158, 20);
            lblNombreRepo.TabIndex = 27;
            lblNombreRepo.Text = "Nombre del Repuesto";
            // 
            // txtNombreRepo
            // 
            txtNombreRepo.Location = new Point(8, 54);
            txtNombreRepo.Margin = new Padding(3, 2, 3, 2);
            txtNombreRepo.Name = "txtNombreRepo";
            txtNombreRepo.Size = new Size(153, 27);
            txtNombreRepo.TabIndex = 28;
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(202, 54);
            nupCantidad.Margin = new Padding(3, 2, 3, 2);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(75, 27);
            nupCantidad.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.LightSkyBlue;
            lblCantidad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCantidad.Location = new Point(202, 24);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 20);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecioUni
            // 
            txtPrecioUni.Location = new Point(317, 57);
            txtPrecioUni.Margin = new Padding(3, 2, 3, 2);
            txtPrecioUni.Multiline = true;
            txtPrecioUni.Name = "txtPrecioUni";
            txtPrecioUni.Size = new Size(67, 24);
            txtPrecioUni.TabIndex = 31;
            // 
            // lblPrecioUni
            // 
            lblPrecioUni.AutoSize = true;
            lblPrecioUni.BackColor = Color.LightSkyBlue;
            lblPrecioUni.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPrecioUni.Location = new Point(317, 24);
            lblPrecioUni.Name = "lblPrecioUni";
            lblPrecioUni.Size = new Size(52, 20);
            lblPrecioUni.TabIndex = 32;
            lblPrecioUni.Text = "Precio";
            // 
            // btnAgregarPresu
            // 
            btnAgregarPresu.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarPresu.FlatStyle = FlatStyle.Popup;
            btnAgregarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresu.Location = new Point(413, 50);
            btnAgregarPresu.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPresu.Name = "btnAgregarPresu";
            btnAgregarPresu.Size = new Size(79, 31);
            btnAgregarPresu.TabIndex = 33;
            btnAgregarPresu.Text = "Agregar";
            btnAgregarPresu.UseVisualStyleBackColor = false;
            btnAgregarPresu.Click += btnAgregarPresu_Click;
            // 
            // btnEliminarPresu
            // 
            btnEliminarPresu.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminarPresu.FlatStyle = FlatStyle.Popup;
            btnEliminarPresu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPresu.Location = new Point(524, 50);
            btnEliminarPresu.Margin = new Padding(3, 2, 3, 2);
            btnEliminarPresu.Name = "btnEliminarPresu";
            btnEliminarPresu.Size = new Size(79, 31);
            btnEliminarPresu.TabIndex = 34;
            btnEliminarPresu.Text = "Eliminar";
            btnEliminarPresu.UseVisualStyleBackColor = false;
            btnEliminarPresu.Click += btnEliminarPresu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(txtKm);
            groupBox1.Controls.Add(lblKm);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(lblDomicilio);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblTitular);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(lblPatente);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtPatente);
            groupBox1.Controls.Add(txtAño);
            groupBox1.Controls.Add(lblAño);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(104, 31);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(662, 178);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Registro";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(422, 93);
            txtKm.Margin = new Padding(3, 2, 3, 2);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(153, 25);
            txtKm.TabIndex = 21;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblKm.Location = new Point(334, 93);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(86, 20);
            lblKm.TabIndex = 20;
            lblKm.Text = "Kilometros:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(141, 91);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(153, 25);
            txtDomicilio.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(142, 58);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(153, 25);
            txtTelefono.TabIndex = 18;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDomicilio.Location = new Point(59, 96);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(78, 20);
            lblDomicilio.TabIndex = 17;
            lblDomicilio.Text = "Domicilio:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTelefono.Location = new Point(61, 63);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(72, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(lblNombreRepo);
            groupBox2.Controls.Add(btnEliminarPresu);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(nupCantidad);
            groupBox2.Controls.Add(btnAgregarPresu);
            groupBox2.Controls.Add(txtPrecioUni);
            groupBox2.Controls.Add(txtNombreRepo);
            groupBox2.Controls.Add(lblPrecioUni);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(104, 230);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(662, 90);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Repuestos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(909, 529);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 50);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar Presupuesto";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = SystemColors.MenuHighlight;
            btnGenerar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(909, 87);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(116, 50);
            btnGenerar.TabIndex = 39;
            btnGenerar.Text = "Generar Presupuesto";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.BackColor = Color.LightSkyBlue;
            labelDesc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelDesc.Location = new Point(104, 544);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(173, 20);
            labelDesc.TabIndex = 40;
            labelDesc.Text = "Descripcion del Trabajo:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(283, 544);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(263, 89);
            textBoxDesc.TabIndex = 41;
            // 
            // Presupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 661);
            Controls.Add(textBoxDesc);
            Controls.Add(labelDesc);
            Controls.Add(btnGenerar);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox2);
            Controls.Add(lblCantidadHoras);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblPrecioHora);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolverPresupuesto);
            Controls.Add(txtPrecioHora);
            Controls.Add(txtCantidadHoras);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Presupuesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presupuesto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolverPresupuesto;
        private Button btnGuardar;
        private TextBox txtTitular;
        private Label lblPatente;
        private Label lblTitular;
        private Label lblMarca;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblModelo;
        private Label lblAño;
        private TextBox txtModelo;
        private TextBox txtAño;
        private Label lblCantidadHoras;
        private Label lblPrecioHora;
        private TextBox txtCantidadHoras;
        private TextBox txtPrecioHora;
        private DataGridView dataGridView1;
        private Label lblNombreRepo;
        private TextBox txtNombreRepo;
        private NumericUpDown nupCantidad;
        private Label lblCantidad;
        private TextBox txtPrecioUni;
        private Label lblPrecioUni;
        private Button btnAgregarPresu;
        private Button btnEliminarPresu;
        private GroupBox groupBox1;
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private Label lblDomicilio;
        private Label lblTelefono;
        private GroupBox groupBox2;
        private Button btnLimpiar;
        private Button btnGenerar;
        private DataGridViewTextBoxColumn NombreRespuesto;
        private DataGridViewTextBoxColumn CantidadRepuesto;
        private DataGridViewTextBoxColumn PrecioRepuesto;
        private Label labelDesc;
        private TextBox textBoxDesc;
        private TextBox txtKm;
        private Label lblKm;
    }
}