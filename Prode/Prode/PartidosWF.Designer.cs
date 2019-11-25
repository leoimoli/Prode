namespace Prode
{
    partial class PartidosWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartidosWF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarAlineacion = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoPartido = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarAlineacion);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevoPartido);
            this.groupBox1.Controls.Add(this.btnEstadistica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 552);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // btnEditarAlineacion
            // 
            this.btnEditarAlineacion.Image = global::Prode.Properties.Resources.hombre1;
            this.btnEditarAlineacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAlineacion.Location = new System.Drawing.Point(9, 224);
            this.btnEditarAlineacion.Name = "btnEditarAlineacion";
            this.btnEditarAlineacion.Size = new System.Drawing.Size(133, 55);
            this.btnEditarAlineacion.TabIndex = 10;
            this.btnEditarAlineacion.Text = "Alineación de Equipo";
            this.btnEditarAlineacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAlineacion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarAlineacion.UseVisualStyleBackColor = true;
            this.btnEditarAlineacion.Click += new System.EventHandler(this.btnEditarAlineacion_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Prode.Properties.Resources.puntuacion_final2;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(9, 135);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 55);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar Partido";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPartido
            // 
            this.btnNuevoPartido.Image = global::Prode.Properties.Resources.jugadores_de_futbol_en_el_campo3;
            this.btnNuevoPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPartido.Location = new System.Drawing.Point(9, 47);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(133, 55);
            this.btnNuevoPartido.TabIndex = 7;
            this.btnNuevoPartido.Text = "Nuevo Partido";
            this.btnNuevoPartido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPartido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoPartido.UseVisualStyleBackColor = true;
            this.btnNuevoPartido.Click += new System.EventHandler(this.btnNuevoPartido_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Image = global::Prode.Properties.Resources.dato;
            this.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadistica.Location = new System.Drawing.Point(9, 332);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(133, 55);
            this.btnEstadistica.TabIndex = 0;
            this.btnEstadistica.Text = "Estadistica Partido";
            this.btnEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // PartidosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 743);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartidosWF";
            this.Text = "Partidos";
            this.Load += new System.EventHandler(this.PartidosWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarAlineacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoPartido;
        private System.Windows.Forms.Button btnEstadistica;
    }
}