namespace Prode
{
    partial class AsignarJugadorEquipoWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarJugadorEquipoWF));
            this.lblId = new System.Windows.Forms.Label();
            this.lblJugadorEdit = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarApellidoNombre = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.lblPlantel = new System.Windows.Forms.Label();
            this.dgvPlantel = new System.Windows.Forms.DataGridView();
            this.btnBuscarEquipos = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chcMasiva = new System.Windows.Forms.CheckBox();
            this.chcPersonal = new System.Windows.Forms.CheckBox();
            this.dgvMasiva = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasiva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(411, 133);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 17);
            this.lblId.TabIndex = 63;
            this.lblId.Text = "@";
            this.lblId.Visible = false;
            // 
            // lblJugadorEdit
            // 
            this.lblJugadorEdit.AutoSize = true;
            this.lblJugadorEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblJugadorEdit.Location = new System.Drawing.Point(326, 43);
            this.lblJugadorEdit.Name = "lblJugadorEdit";
            this.lblJugadorEdit.Size = new System.Drawing.Size(32, 25);
            this.lblJugadorEdit.TabIndex = 60;
            this.lblJugadorEdit.Text = "@";
            this.lblJugadorEdit.Visible = false;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblJugador.Location = new System.Drawing.Point(213, 43);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(107, 29);
            this.lblJugador.TabIndex = 59;
            this.lblJugador.Text = "Jugador:";
            this.lblJugador.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarApellidoNombre);
            this.groupBox1.Controls.Add(this.lblDniOApellidoNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 78);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Prode.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(577, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarApellidoNombre
            // 
            this.txtBuscarApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarApellidoNombre.Location = new System.Drawing.Point(170, 28);
            this.txtBuscarApellidoNombre.Name = "txtBuscarApellidoNombre";
            this.txtBuscarApellidoNombre.Size = new System.Drawing.Size(401, 23);
            this.txtBuscarApellidoNombre.TabIndex = 37;
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(8, 28);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(156, 20);
            this.lblDniOApellidoNombre.TabIndex = 39;
            this.lblDniOApellidoNombre.Text = "Apellido y Nombre(*):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblIdEquipo);
            this.groupBox2.Controls.Add(this.lblPlantel);
            this.groupBox2.Controls.Add(this.dgvPlantel);
            this.groupBox2.Controls.Add(this.btnBuscarEquipos);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 466);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipo a Asignar";
            this.groupBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 407);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 110;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // lblIdEquipo
            // 
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEquipo.Location = new System.Drawing.Point(225, 54);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(22, 17);
            this.lblIdEquipo.TabIndex = 67;
            this.lblIdEquipo.Text = "@";
            this.lblIdEquipo.Visible = false;
            // 
            // lblPlantel
            // 
            this.lblPlantel.AutoSize = true;
            this.lblPlantel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantel.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPlantel.Location = new System.Drawing.Point(253, 54);
            this.lblPlantel.Name = "lblPlantel";
            this.lblPlantel.Size = new System.Drawing.Size(131, 25);
            this.lblPlantel.TabIndex = 66;
            this.lblPlantel.Text = "Plantel Actual";
            this.lblPlantel.Visible = false;
            // 
            // dgvPlantel
            // 
            this.dgvPlantel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantel.Location = new System.Drawing.Point(116, 82);
            this.dgvPlantel.Name = "dgvPlantel";
            this.dgvPlantel.Size = new System.Drawing.Size(422, 375);
            this.dgvPlantel.TabIndex = 65;
            this.dgvPlantel.Visible = false;
            this.dgvPlantel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBoton);
            this.dgvPlantel.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPlantel_CellPainting);
            // 
            // btnBuscarEquipos
            // 
            this.btnBuscarEquipos.Image = global::Prode.Properties.Resources.buscar;
            this.btnBuscarEquipos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarEquipos.Location = new System.Drawing.Point(564, 16);
            this.btnBuscarEquipos.Name = "btnBuscarEquipos";
            this.btnBuscarEquipos.Size = new System.Drawing.Size(49, 39);
            this.btnBuscarEquipos.TabIndex = 5;
            this.btnBuscarEquipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarEquipos.UseVisualStyleBackColor = true;
            this.btnBuscarEquipos.Click += new System.EventHandler(this.btnBuscarEquipos_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(157, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(401, 23);
            this.txtBuscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Equipo(*):";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Prode.Properties.Resources.deshacer;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(217, 688);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 51);
            this.btnVolver.TabIndex = 132;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Prode.Properties.Resources.error;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(303, 688);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 51);
            this.btnCancelar.TabIndex = 131;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Image = global::Prode.Properties.Resources.pasar1;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAsignar.Location = new System.Drawing.Point(390, 688);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(80, 51);
            this.btnAsignar.TabIndex = 130;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(288, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // chcMasiva
            // 
            this.chcMasiva.AutoSize = true;
            this.chcMasiva.Location = new System.Drawing.Point(390, 12);
            this.chcMasiva.Name = "chcMasiva";
            this.chcMasiva.Size = new System.Drawing.Size(115, 17);
            this.chcMasiva.TabIndex = 133;
            this.chcMasiva.Text = "Asignación Masiva";
            this.chcMasiva.UseVisualStyleBackColor = true;
            this.chcMasiva.CheckedChanged += new System.EventHandler(this.chcMasiva_CheckedChanged);
            // 
            // chcPersonal
            // 
            this.chcPersonal.AutoSize = true;
            this.chcPersonal.Checked = true;
            this.chcPersonal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chcPersonal.Location = new System.Drawing.Point(202, 12);
            this.chcPersonal.Name = "chcPersonal";
            this.chcPersonal.Size = new System.Drawing.Size(122, 17);
            this.chcPersonal.TabIndex = 134;
            this.chcPersonal.Text = "Asignación Personal";
            this.chcPersonal.UseVisualStyleBackColor = true;
            this.chcPersonal.CheckedChanged += new System.EventHandler(this.chcPersonal_CheckedChanged);
            // 
            // dgvMasiva
            // 
            this.dgvMasiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasiva.Location = new System.Drawing.Point(158, 111);
            this.dgvMasiva.Name = "dgvMasiva";
            this.dgvMasiva.Size = new System.Drawing.Size(412, 110);
            this.dgvMasiva.TabIndex = 111;
            this.dgvMasiva.Visible = false;
            this.dgvMasiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasiva_CellContentClick);
            // 
            // AsignarJugadorEquipoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 743);
            this.Controls.Add(this.dgvMasiva);
            this.Controls.Add(this.chcPersonal);
            this.Controls.Add(this.chcMasiva);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblJugadorEdit);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarJugadorEquipoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Jugador a Equipo";
            this.Load += new System.EventHandler(this.AsignarJugadorEquipoWF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJugadorEdit;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarApellidoNombre;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPlantel;
        private System.Windows.Forms.Button btnBuscarEquipos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlantel;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblIdEquipo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chcMasiva;
        private System.Windows.Forms.CheckBox chcPersonal;
        private System.Windows.Forms.DataGridView dgvMasiva;
    }
}