﻿namespace Prode
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLiga = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grbResultados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EquipoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbApostadores = new System.Windows.Forms.GroupBox();
            this.dgvResultaApostadores = new System.Windows.Forms.DataGridView();
            this.grbEstadisticaRecaudacion = new System.Windows.Forms.GroupBox();
            this.lblMontoRecaudado = new System.Windows.Forms.Label();
            this.lblJugadoresParticipantes = new System.Windows.Forms.Label();
            this.lblCantidadJugadas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbFiltros.SuspendLayout();
            this.grbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbApostadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultaApostadores)).BeginInit();
            this.grbEstadisticaRecaudacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Prode.Properties.Resources.simbolo_correcto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(934, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(689, 30);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(225, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Torneo(*):";
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(403, 30);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(200, 21);
            this.cmbTorneo.TabIndex = 1;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.label4);
            this.grbFiltros.Controls.Add(this.btnBuscar);
            this.grbFiltros.Controls.Add(this.cmbLiga);
            this.grbFiltros.Controls.Add(this.txtFecha);
            this.grbFiltros.Controls.Add(this.label2);
            this.grbFiltros.Controls.Add(this.label1);
            this.grbFiltros.Controls.Add(this.cmbTorneo);
            this.grbFiltros.Location = new System.Drawing.Point(140, 76);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(1021, 75);
            this.grbFiltros.TabIndex = 34;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 129;
            this.label4.Text = "Liga(*):";
            // 
            // cmbLiga
            // 
            this.cmbLiga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiga.FormattingEnabled = true;
            this.cmbLiga.Location = new System.Drawing.Point(101, 30);
            this.cmbLiga.Name = "cmbLiga";
            this.cmbLiga.Size = new System.Drawing.Size(200, 21);
            this.cmbLiga.TabIndex = 0;
            this.cmbLiga.SelectedIndexChanged += new System.EventHandler(this.cmbLiga_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SeaGreen;
            this.label18.Location = new System.Drawing.Point(487, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(224, 25);
            this.label18.TabIndex = 123;
            this.label18.Text = "Estadísticas de Jugadas";
            // 
            // grbResultados
            // 
            this.grbResultados.Controls.Add(this.dataGridView1);
            this.grbResultados.Location = new System.Drawing.Point(576, 173);
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
            this.dataGridView1.ReadOnly = true;
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
            this.Local.ReadOnly = true;
            this.Local.Width = 50;
            // 
            // Visitante
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Visitante.DefaultCellStyle = dataGridViewCellStyle2;
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.Name = "Visitante";
            this.Visitante.ReadOnly = true;
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
            this.grbApostadores.Location = new System.Drawing.Point(44, 173);
            this.grbApostadores.Name = "grbApostadores";
            this.grbApostadores.Size = new System.Drawing.Size(440, 302);
            this.grbApostadores.TabIndex = 125;
            this.grbApostadores.TabStop = false;
            this.grbApostadores.Text = "Resultados Aciertos";
            this.grbApostadores.Visible = false;
            // 
            // dgvResultaApostadores
            // 
            this.dgvResultaApostadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultaApostadores.Location = new System.Drawing.Point(3, 16);
            this.dgvResultaApostadores.Name = "dgvResultaApostadores";
            this.dgvResultaApostadores.Size = new System.Drawing.Size(426, 280);
            this.dgvResultaApostadores.TabIndex = 0;
            this.dgvResultaApostadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickBoton);
            this.dgvResultaApostadores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResultaApostadores_CellPainting);
            // 
            // grbEstadisticaRecaudacion
            // 
            this.grbEstadisticaRecaudacion.Controls.Add(this.lblMontoRecaudado);
            this.grbEstadisticaRecaudacion.Controls.Add(this.lblJugadoresParticipantes);
            this.grbEstadisticaRecaudacion.Controls.Add(this.lblCantidadJugadas);
            this.grbEstadisticaRecaudacion.Controls.Add(this.label7);
            this.grbEstadisticaRecaudacion.Controls.Add(this.label6);
            this.grbEstadisticaRecaudacion.Controls.Add(this.label5);
            this.grbEstadisticaRecaudacion.Location = new System.Drawing.Point(44, 481);
            this.grbEstadisticaRecaudacion.Name = "grbEstadisticaRecaudacion";
            this.grbEstadisticaRecaudacion.Size = new System.Drawing.Size(440, 180);
            this.grbEstadisticaRecaudacion.TabIndex = 126;
            this.grbEstadisticaRecaudacion.TabStop = false;
            this.grbEstadisticaRecaudacion.Text = "Estadísticas";
            this.grbEstadisticaRecaudacion.Visible = false;
            // 
            // lblMontoRecaudado
            // 
            this.lblMontoRecaudado.AutoSize = true;
            this.lblMontoRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoRecaudado.Location = new System.Drawing.Point(236, 126);
            this.lblMontoRecaudado.Name = "lblMontoRecaudado";
            this.lblMontoRecaudado.Size = new System.Drawing.Size(22, 17);
            this.lblMontoRecaudado.TabIndex = 5;
            this.lblMontoRecaudado.Text = "@";
            // 
            // lblJugadoresParticipantes
            // 
            this.lblJugadoresParticipantes.AutoSize = true;
            this.lblJugadoresParticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadoresParticipantes.Location = new System.Drawing.Point(236, 81);
            this.lblJugadoresParticipantes.Name = "lblJugadoresParticipantes";
            this.lblJugadoresParticipantes.Size = new System.Drawing.Size(22, 17);
            this.lblJugadoresParticipantes.TabIndex = 4;
            this.lblJugadoresParticipantes.Text = "@";
            // 
            // lblCantidadJugadas
            // 
            this.lblCantidadJugadas.AutoSize = true;
            this.lblCantidadJugadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadJugadas.Location = new System.Drawing.Point(236, 35);
            this.lblCantidadJugadas.Name = "lblCantidadJugadas";
            this.lblCantidadJugadas.Size = new System.Drawing.Size(22, 17);
            this.lblCantidadJugadas.TabIndex = 3;
            this.lblCantidadJugadas.Text = "@";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Monto Recaudado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Jugadores Participantes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad de Jugadas:";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Prode.Properties.Resources.deshacer;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(576, 662);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 51);
            this.btnVolver.TabIndex = 127;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ResultadoJugadasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 743);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grbEstadisticaRecaudacion);
            this.Controls.Add(this.grbApostadores);
            this.Controls.Add(this.grbResultados);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.grbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultadoJugadasWF";
            this.Text = "Resultado Jugadas";
            this.Load += new System.EventHandler(this.ResultadoJugadasWF_Load);
            this.Controls.SetChildIndex(this.grbFiltros, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.grbResultados, 0);
            this.Controls.SetChildIndex(this.grbApostadores, 0);
            this.Controls.SetChildIndex(this.grbEstadisticaRecaudacion, 0);
            this.Controls.SetChildIndex(this.btnVolver, 0);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.grbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbApostadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultaApostadores)).EndInit();
            this.grbEstadisticaRecaudacion.ResumeLayout(false);
            this.grbEstadisticaRecaudacion.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbEstadisticaRecaudacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidadJugadas;
        private System.Windows.Forms.Label lblMontoRecaudado;
        private System.Windows.Forms.Label lblJugadoresParticipantes;
        private System.Windows.Forms.Button btnVolver;
    }
}