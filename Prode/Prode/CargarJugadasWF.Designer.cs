namespace Prode
{
    partial class CargarJugadasWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarJugadasWF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarApellidoNombre = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblidApostador = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.lblDniEdit = new System.Windows.Forms.Label();
            this.lblApellidoNombreEdit = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaPartido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarApellidoNombre);
            this.groupBox1.Controls.Add(this.lblDniOApellidoNombre);
            this.groupBox1.Location = new System.Drawing.Point(313, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Prode.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(575, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarApellidoNombre
            // 
            this.txtBuscarApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarApellidoNombre.Location = new System.Drawing.Point(168, 28);
            this.txtBuscarApellidoNombre.Name = "txtBuscarApellidoNombre";
            this.txtBuscarApellidoNombre.Size = new System.Drawing.Size(401, 20);
            this.txtBuscarApellidoNombre.TabIndex = 0;
            this.txtBuscarApellidoNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarApellidoNombre_KeyDown);
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(6, 26);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(156, 20);
            this.lblDniOApellidoNombre.TabIndex = 33;
            this.lblDniOApellidoNombre.Text = "Apellido y Nombre(*):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SeaGreen;
            this.label18.Location = new System.Drawing.Point(573, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 25);
            this.label18.TabIndex = 30;
            this.label18.Text = "Cargar Jugadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMensaje);
            this.groupBox2.Controls.Add(this.lblidApostador);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lblDniEdit);
            this.groupBox2.Controls.Add(this.lblApellidoNombreEdit);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTorneo);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(194, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 557);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            this.groupBox2.Visible = false;
            // 
            // lblidApostador
            // 
            this.lblidApostador.AutoSize = true;
            this.lblidApostador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidApostador.Location = new System.Drawing.Point(398, 30);
            this.lblidApostador.Name = "lblidApostador";
            this.lblidApostador.Size = new System.Drawing.Size(25, 20);
            this.lblidApostador.TabIndex = 121;
            this.lblidApostador.Text = "@";
            this.lblidApostador.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(276, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 120;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Prode.Properties.Resources.apoyo;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(452, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Prode.Properties.Resources.error;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(354, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(65, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(140, 20);
            this.label26.TabIndex = 41;
            this.label26.Text = "Apellido y Nombre:";
            // 
            // lblDniEdit
            // 
            this.lblDniEdit.AutoSize = true;
            this.lblDniEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEdit.Location = new System.Drawing.Point(637, 30);
            this.lblDniEdit.Name = "lblDniEdit";
            this.lblDniEdit.Size = new System.Drawing.Size(25, 20);
            this.lblDniEdit.TabIndex = 40;
            this.lblDniEdit.Text = "@";
            // 
            // lblApellidoNombreEdit
            // 
            this.lblApellidoNombreEdit.AutoSize = true;
            this.lblApellidoNombreEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombreEdit.Location = new System.Drawing.Point(211, 30);
            this.lblApellidoNombreEdit.Name = "lblApellidoNombreEdit";
            this.lblApellidoNombreEdit.Size = new System.Drawing.Size(25, 20);
            this.lblApellidoNombreEdit.TabIndex = 39;
            this.lblApellidoNombreEdit.Text = "@";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(590, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 20);
            this.label27.TabIndex = 38;
            this.label27.Text = "Dni:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(593, 69);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(225, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Torneo(*):";
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(151, 70);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(200, 21);
            this.cmbTorneo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Partido,
            this.DiaPartido,
            this.Estadio,
            this.Local,
            this.EquipoLocal,
            this.Empate,
            this.EquipoVisitante,
            this.Visitante});
            this.dataGridView1.Location = new System.Drawing.Point(10, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 347);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // Partido
            // 
            this.Partido.HeaderText = "Nro.Partido";
            this.Partido.Name = "Partido";
            this.Partido.ReadOnly = true;
            this.Partido.Width = 65;
            // 
            // DiaPartido
            // 
            this.DiaPartido.HeaderText = "Día de partido";
            this.DiaPartido.Name = "DiaPartido";
            this.DiaPartido.ReadOnly = true;
            this.DiaPartido.Width = 80;
            // 
            // Estadio
            // 
            this.Estadio.HeaderText = "Estadio";
            this.Estadio.Name = "Estadio";
            this.Estadio.ReadOnly = true;
            this.Estadio.Width = 150;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.Width = 50;
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.HeaderText = "Equipo Local";
            this.EquipoLocal.Name = "EquipoLocal";
            this.EquipoLocal.ReadOnly = true;
            this.EquipoLocal.Width = 200;
            // 
            // Empate
            // 
            this.Empate.HeaderText = "Empate";
            this.Empate.Name = "Empate";
            this.Empate.Width = 50;
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.HeaderText = "Equipo Visitante";
            this.EquipoVisitante.Name = "EquipoVisitante";
            this.EquipoVisitante.ReadOnly = true;
            this.EquipoVisitante.Width = 200;
            // 
            // Visitante
            // 
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.Name = "Visitante";
            this.Visitante.Width = 50;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(7, 454);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(416, 20);
            this.lblMensaje.TabIndex = 122;
            this.lblMensaje.Text = "Atención solo indique con una \"X\" el resultado del partido.";
            this.lblMensaje.Visible = false;
            // 
            // CargarJugadasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargarJugadasWF";
            this.Text = "Cargar Jugadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CargarJugadasWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarApellidoNombre;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblDniEdit;
        private System.Windows.Forms.Label lblApellidoNombreEdit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitante;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblidApostador;
        private System.Windows.Forms.Label lblMensaje;
    }
}