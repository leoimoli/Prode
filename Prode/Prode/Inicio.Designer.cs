﻿namespace Prode
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.fechasToolStripMenuItem,
            this.apuestasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // fechasToolStripMenuItem
            // 
            this.fechasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarFechaToolStripMenuItem});
            this.fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            this.fechasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fechasToolStripMenuItem.Text = "Fechas";
            // 
            // cargarFechaToolStripMenuItem
            // 
            this.cargarFechaToolStripMenuItem.Name = "cargarFechaToolStripMenuItem";
            this.cargarFechaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cargarFechaToolStripMenuItem.Text = "Cargar Fecha";
            // 
            // apuestasToolStripMenuItem
            // 
            this.apuestasToolStripMenuItem.Name = "apuestasToolStripMenuItem";
            this.apuestasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.apuestasToolStripMenuItem.Text = "Apuestas";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 431);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuestasToolStripMenuItem;
    }
}

