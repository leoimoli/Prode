namespace Prode
{
    partial class MasterWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterWF));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFirmaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.periciasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = global::Prode.Properties.Resources.icono_de_inicio_silueta;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torneosToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::Prode.Properties.Resources.configuraciones;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.clientesToolStripMenuItem.Text = "Configuraciones";
            // 
            // torneosToolStripMenuItem
            // 
            this.torneosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarTorneoToolStripMenuItem,
            this.cargarFechaToolStripMenuItem});
            this.torneosToolStripMenuItem.Image = global::Prode.Properties.Resources.primer_lugar_trofeo;
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            this.torneosToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.torneosToolStripMenuItem.Text = "Torneos";
            // 
            // cargarTorneoToolStripMenuItem
            // 
            this.cargarTorneoToolStripMenuItem.Image = global::Prode.Properties.Resources.accesorios;
            this.cargarTorneoToolStripMenuItem.Name = "cargarTorneoToolStripMenuItem";
            this.cargarTorneoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.cargarTorneoToolStripMenuItem.Text = "Cargar Torneo";
            this.cargarTorneoToolStripMenuItem.Click += new System.EventHandler(this.cargarTorneoToolStripMenuItem_Click);
            // 
            // cargarFechaToolStripMenuItem
            // 
            this.cargarFechaToolStripMenuItem.Image = global::Prode.Properties.Resources.jugadores_de_futbol_en_el_campo;
            this.cargarFechaToolStripMenuItem.Name = "cargarFechaToolStripMenuItem";
            this.cargarFechaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.cargarFechaToolStripMenuItem.Text = "Cargar Partidos";
            // 
            // periciasToolStripMenuItem
            // 
            this.periciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPartidosToolStripMenuItem,
            this.resultadosToolStripMenuItem});
            this.periciasToolStripMenuItem.Image = global::Prode.Properties.Resources.betting;
            this.periciasToolStripMenuItem.Name = "periciasToolStripMenuItem";
            this.periciasToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.periciasToolStripMenuItem.Text = "Jugadas";
            // 
            // cargarPartidosToolStripMenuItem
            // 
            this.cargarPartidosToolStripMenuItem.Image = global::Prode.Properties.Resources.betting;
            this.cargarPartidosToolStripMenuItem.Name = "cargarPartidosToolStripMenuItem";
            this.cargarPartidosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cargarPartidosToolStripMenuItem.Text = "Cargar Jugadas";
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resultadosToolStripMenuItem.Text = "Resultados Jugadas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.cargarFirmaEmailToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::Prode.Properties.Resources.usuario_hombre_1_;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // cargarFirmaEmailToolStripMenuItem
            // 
            this.cargarFirmaEmailToolStripMenuItem.Name = "cargarFirmaEmailToolStripMenuItem";
            this.cargarFirmaEmailToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.cargarFirmaEmailToolStripMenuItem.Text = "Cargar Datos Email";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Prode.Properties.Resources.desconectarte;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 28);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(627, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prode Versión-1.0.0";
            // 
            // MasterWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterWF";
            this.Text = "MasterWF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFirmaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFechaToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}