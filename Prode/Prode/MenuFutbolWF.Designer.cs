namespace Prode
{
    partial class MenuFutbolWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFutbolWF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTorneo = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnPracticas = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnPartido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTorneo);
            this.groupBox1.Controls.Add(this.btnEquipos);
            this.groupBox1.Controls.Add(this.btnPracticas);
            this.groupBox1.Controls.Add(this.btnJugadores);
            this.groupBox1.Controls.Add(this.btnPartido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 552);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // btnTorneo
            // 
            this.btnTorneo.Image = global::Prode.Properties.Resources.primer_lugar_trofeo;
            this.btnTorneo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTorneo.Location = new System.Drawing.Point(9, 96);
            this.btnTorneo.Name = "btnTorneo";
            this.btnTorneo.Size = new System.Drawing.Size(133, 55);
            this.btnTorneo.TabIndex = 8;
            this.btnTorneo.Text = "Torneo";
            this.btnTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTorneo.UseVisualStyleBackColor = true;
            this.btnTorneo.Click += new System.EventHandler(this.btnTorneo_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.Image = global::Prode.Properties.Resources.equipo1;
            this.btnEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEquipos.Location = new System.Drawing.Point(9, 25);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(133, 55);
            this.btnEquipos.TabIndex = 7;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEquipos.UseVisualStyleBackColor = true;
            // 
            // btnPracticas
            // 
            this.btnPracticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticas.Image = global::Prode.Properties.Resources.herramienta_de_senalizacion_de_cono_de_trafico_para_trafico;
            this.btnPracticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPracticas.Location = new System.Drawing.Point(9, 315);
            this.btnPracticas.Name = "btnPracticas";
            this.btnPracticas.Size = new System.Drawing.Size(133, 55);
            this.btnPracticas.TabIndex = 6;
            this.btnPracticas.Text = "Prácticas";
            this.btnPracticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracticas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPracticas.UseVisualStyleBackColor = true;
            // 
            // btnJugadores
            // 
            this.btnJugadores.Image = global::Prode.Properties.Resources.jugador_de_futbol_de_pie_con_el_balon_debajo_de_un_pie;
            this.btnJugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJugadores.Location = new System.Drawing.Point(9, 168);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(133, 55);
            this.btnJugadores.TabIndex = 1;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnPartido
            // 
            this.btnPartido.Image = global::Prode.Properties.Resources.marcador2;
            this.btnPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPartido.Location = new System.Drawing.Point(9, 242);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(133, 55);
            this.btnPartido.TabIndex = 0;
            this.btnPartido.Text = "Partidos";
            this.btnPartido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // MenuFutbolWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 743);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuFutbolWF";
            this.Text = "Menú Fútbol";
            this.Load += new System.EventHandler(this.MenuFutbolWF_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPracticas;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnTorneo;
    }
}