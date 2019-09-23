namespace Prode
{
    partial class ConsultarFechaWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFechaWF));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnPdf);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTorneo);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(232, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 591);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            this.groupBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(275, 505);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 120;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Image = global::Prode.Properties.Resources.apoyo;
            this.btnPdf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPdf.Location = new System.Drawing.Point(441, 534);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(80, 51);
            this.btnPdf.TabIndex = 3;
            this.btnPdf.Text = "PDF";
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::Prode.Properties.Resources.deshacer;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolver.Location = new System.Drawing.Point(343, 534);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 51);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(593, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(225, 20);
            this.txtFecha.TabIndex = 1;
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 444);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.SeaGreen;
            this.label18.Location = new System.Drawing.Point(582, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "Consultar Fecha";
            // 
            // ConsultarFechaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarFechaWF";
            this.Text = "Consultar Fecha";
            this.Load += new System.EventHandler(this.ConsultarFechaWF_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitante;
        private System.Windows.Forms.Label label18;
    }
}