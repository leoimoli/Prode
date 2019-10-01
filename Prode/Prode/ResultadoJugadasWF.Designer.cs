namespace Prode
{
    partial class ResultadoJugadasWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoJugadasWF));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grbResultados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EquipoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbApostadores = new System.Windows.Forms.GroupBox();
            this.dgvResultaApostadores = new System.Windows.Forms.DataGridView();
            this.grbFiltros.SuspendLayout();
            this.grbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbApostadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultaApostadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Prode.Properties.Resources.simbolo_correcto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(838, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 30);
            this.btnBuscar.TabIndex = 121;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(593, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(225, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Torneo(*):";
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(151, 28);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(200, 21);
            this.cmbTorneo.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.txtFecha);
            this.grbFiltros.Controls.Add(this.label2);
            this.grbFiltros.Controls.Add(this.label1);
            this.grbFiltros.Controls.Add(this.cmbTorneo);
            this.grbFiltros.Location = new System.Drawing.Point(232, 76);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(906, 75);
            this.grbFiltros.TabIndex = 34;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SeaGreen;
            this.label18.Location = new System.Drawing.Point(579, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(224, 25);
            this.label18.TabIndex = 123;
            this.label18.Text = "Estadísticas de Jugadas";
            // 
            // grbResultados
            // 
            this.grbResultados.Controls.Add(this.dataGridView1);
            this.grbResultados.Location = new System.Drawing.Point(687, 173);
            this.grbResultados.Name = "grbResultados";
            this.grbResultados.Size = new System.Drawing.Size(606, 356);
            this.grbResultados.TabIndex = 124;
            this.grbResultados.TabStop = false;
            this.grbResultados.Text = "Resultados";
            this.grbResultados.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipoLocal,
            this.Local,
            this.Visitante,
            this.EquipoVisitante});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 324);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.HeaderText = "Equipo Local";
            this.EquipoLocal.Name = "EquipoLocal";
            this.EquipoLocal.ReadOnly = true;
            this.EquipoLocal.Width = 225;
            // 
            // Local
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Local.DefaultCellStyle = dataGridViewCellStyle1;
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.Width = 50;
            // 
            // Visitante
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Visitante.DefaultCellStyle = dataGridViewCellStyle2;
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.Name = "Visitante";
            this.Visitante.Width = 50;
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.HeaderText = "Equipo Visitante";
            this.EquipoVisitante.Name = "EquipoVisitante";
            this.EquipoVisitante.ReadOnly = true;
            this.EquipoVisitante.Width = 225;
            // 
            // grbApostadores
            // 
            this.grbApostadores.Controls.Add(this.dgvResultaApostadores);
            this.grbApostadores.Location = new System.Drawing.Point(44, 182);
            this.grbApostadores.Name = "grbApostadores";
            this.grbApostadores.Size = new System.Drawing.Size(372, 214);
            this.grbApostadores.TabIndex = 125;
            this.grbApostadores.TabStop = false;
            this.grbApostadores.Text = "Resultados Apostadores";
            this.grbApostadores.Visible = false;
            // 
            // dgvResultaApostadores
            // 
            this.dgvResultaApostadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultaApostadores.Location = new System.Drawing.Point(3, 16);
            this.dgvResultaApostadores.Name = "dgvResultaApostadores";
            this.dgvResultaApostadores.Size = new System.Drawing.Size(363, 192);
            this.dgvResultaApostadores.TabIndex = 0;
            // 
            // ResultadoJugadasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.grbApostadores);
            this.Controls.Add(this.grbResultados);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.grbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultadoJugadasWF";
            this.Text = "Resultado Jugadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResultadoJugadasWF_Load);
            this.Controls.SetChildIndex(this.grbFiltros, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.grbResultados, 0);
            this.Controls.SetChildIndex(this.grbApostadores, 0);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.grbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbApostadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultaApostadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbResultados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbApostadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoVisitante;
        private System.Windows.Forms.DataGridView dgvResultaApostadores;
    }
}