namespace Prode
{
    partial class JugadoresWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadoresWF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFutbol = new System.Windows.Forms.Button();
            this.btnFicha = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnJugador = new System.Windows.Forms.Button();
            this.btnEliminarJugadorMenu = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIdJugador = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApodo = new System.Windows.Forms.Label();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarApellidoNombre = new System.Windows.Forms.TextBox();
            this.lblDniOApellidoNombre = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFutbol);
            this.groupBox1.Controls.Add(this.btnFicha);
            this.groupBox1.Controls.Add(this.btnAsignar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnJugador);
            this.groupBox1.Controls.Add(this.btnEliminarJugadorMenu);
            this.groupBox1.Controls.Add(this.btnEstadistica);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 552);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // btnFutbol
            // 
            this.btnFutbol.Image = global::Prode.Properties.Resources.pelota_de_futbol;
            this.btnFutbol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFutbol.Location = new System.Drawing.Point(9, 466);
            this.btnFutbol.Name = "btnFutbol";
            this.btnFutbol.Size = new System.Drawing.Size(133, 55);
            this.btnFutbol.TabIndex = 11;
            this.btnFutbol.Text = "Fútbol";
            this.btnFutbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFutbol.UseVisualStyleBackColor = true;
            this.btnFutbol.Click += new System.EventHandler(this.btnFutbol_Click);
            // 
            // btnFicha
            // 
            this.btnFicha.Image = global::Prode.Properties.Resources.ficha_policial;
            this.btnFicha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFicha.Location = new System.Drawing.Point(9, 236);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(133, 55);
            this.btnFicha.TabIndex = 10;
            this.btnFicha.Text = "Ficha Técnica";
            this.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFicha.UseVisualStyleBackColor = true;
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::Prode.Properties.Resources.pasar;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.Location = new System.Drawing.Point(9, 312);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(133, 55);
            this.btnAsignar.TabIndex = 9;
            this.btnAsignar.Text = "Asignar a Equipo";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Prode.Properties.Resources.hombre;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(9, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 55);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar Jugador";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnJugador
            // 
            this.btnJugador.Image = global::Prode.Properties.Resources.jugador_de_futbol_de_pie_con_el_balon_debajo_de_un_pie1;
            this.btnJugador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJugador.Location = new System.Drawing.Point(9, 25);
            this.btnJugador.Name = "btnJugador";
            this.btnJugador.Size = new System.Drawing.Size(133, 55);
            this.btnJugador.TabIndex = 7;
            this.btnJugador.Text = "Nuevo Jugador";
            this.btnJugador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJugador.UseVisualStyleBackColor = true;
            this.btnJugador.Click += new System.EventHandler(this.btnJugador_Click);
            // 
            // btnEliminarJugadorMenu
            // 
            this.btnEliminarJugadorMenu.Image = global::Prode.Properties.Resources.boton_eliminar3;
            this.btnEliminarJugadorMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarJugadorMenu.Location = new System.Drawing.Point(9, 161);
            this.btnEliminarJugadorMenu.Name = "btnEliminarJugadorMenu";
            this.btnEliminarJugadorMenu.Size = new System.Drawing.Size(133, 55);
            this.btnEliminarJugadorMenu.TabIndex = 1;
            this.btnEliminarJugadorMenu.Text = "Eliminar Jugador";
            this.btnEliminarJugadorMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarJugadorMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarJugadorMenu.UseVisualStyleBackColor = true;
            this.btnEliminarJugadorMenu.Click += new System.EventHandler(this.btnEliminarJugadorMenu_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Image = global::Prode.Properties.Resources.dato;
            this.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadistica.Location = new System.Drawing.Point(10, 391);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(133, 55);
            this.btnEstadistica.TabIndex = 0;
            this.btnEstadistica.Text = "Estadistica Jugador";
            this.btnEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIdJugador);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Controls.Add(this.txtAltura);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.lblImagen);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnCargarImagen);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblAltura);
            this.groupBox2.Controls.Add(this.lblPeso);
            this.groupBox2.Controls.Add(this.dtFechaNacimiento);
            this.groupBox2.Controls.Add(this.cmbSexo);
            this.groupBox2.Controls.Add(this.lblFechaNacimiento);
            this.groupBox2.Controls.Add(this.lblApodo);
            this.groupBox2.Controls.Add(this.txtApodo);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.lblSexo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtBuscarApellidoNombre);
            this.groupBox2.Controls.Add(this.lblDniOApellidoNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(180, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 549);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // lblIdJugador
            // 
            this.lblIdJugador.AutoSize = true;
            this.lblIdJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJugador.Location = new System.Drawing.Point(393, 90);
            this.lblIdJugador.Name = "lblIdJugador";
            this.lblIdJugador.Size = new System.Drawing.Size(25, 20);
            this.lblIdJugador.TabIndex = 65;
            this.lblIdJugador.Text = "@";
            this.lblIdJugador.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(305, 354);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 64;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeso.Location = new System.Drawing.Point(562, 403);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(269, 23);
            this.txtPeso.TabIndex = 9;
            this.txtPeso.Visible = false;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(117, 403);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(269, 23);
            this.txtAltura.TabIndex = 8;
            this.txtAltura.Visible = false;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Prode.Properties.Resources.error;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(439, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 51);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(903, 175);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(63, 20);
            this.lblImagen.TabIndex = 60;
            this.lblImagen.Text = "Imagen";
            this.lblImagen.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Prode.Properties.Resources.apoyo;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(526, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 51);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::Prode.Properties.Resources.boton_eliminar1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(353, 481);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 51);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.Image = global::Prode.Properties.Resources.subir;
            this.btnCargarImagen.Location = new System.Drawing.Point(913, 354);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(49, 39);
            this.btnCargarImagen.TabIndex = 10;
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Visible = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(862, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(46, 403);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(55, 20);
            this.lblAltura.TabIndex = 52;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(507, 403);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 51;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.Visible = false;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(562, 307);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(269, 23);
            this.dtFechaNacimiento.TabIndex = 7;
            this.dtFechaNacimiento.Visible = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(117, 223);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(269, 24);
            this.cmbSexo.TabIndex = 4;
            this.cmbSexo.Visible = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(393, 309);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(163, 20);
            this.lblFechaNacimiento.TabIndex = 48;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            this.lblFechaNacimiento.Visible = false;
            // 
            // lblApodo
            // 
            this.lblApodo.AutoSize = true;
            this.lblApodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApodo.Location = new System.Drawing.Point(51, 309);
            this.lblApodo.Name = "lblApodo";
            this.lblApodo.Size = new System.Drawing.Size(60, 20);
            this.lblApodo.TabIndex = 46;
            this.lblApodo.Text = "Apodo:";
            this.lblApodo.Visible = false;
            // 
            // txtApodo
            // 
            this.txtApodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApodo.Location = new System.Drawing.Point(117, 309);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(269, 23);
            this.txtApodo.TabIndex = 6;
            this.txtApodo.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(471, 141);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre(*):";
            this.lblNombre.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(562, 223);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(269, 23);
            this.txtDni.TabIndex = 5;
            this.txtDni.Visible = false;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(26, 141);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(85, 20);
            this.lblApellido.TabIndex = 42;
            this.lblApellido.Text = "Apellido(*):";
            this.lblApellido.Visible = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(46, 223);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(65, 20);
            this.lblSexo.TabIndex = 40;
            this.lblSexo.Text = "Sexo(*):";
            this.lblSexo.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(562, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(519, 223);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 20);
            this.lblDni.TabIndex = 38;
            this.lblDni.Text = "Dni:";
            this.lblDni.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(117, 141);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(269, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Prode.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(724, 23);
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
            this.txtBuscarApellidoNombre.Location = new System.Drawing.Point(317, 33);
            this.txtBuscarApellidoNombre.Name = "txtBuscarApellidoNombre";
            this.txtBuscarApellidoNombre.Size = new System.Drawing.Size(401, 23);
            this.txtBuscarApellidoNombre.TabIndex = 0;
            // 
            // lblDniOApellidoNombre
            // 
            this.lblDniOApellidoNombre.AutoSize = true;
            this.lblDniOApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniOApellidoNombre.Location = new System.Drawing.Point(155, 31);
            this.lblDniOApellidoNombre.Name = "lblDniOApellidoNombre";
            this.lblDniOApellidoNombre.Size = new System.Drawing.Size(156, 20);
            this.lblDniOApellidoNombre.TabIndex = 36;
            this.lblDniOApellidoNombre.Text = "Apellido y Nombre(*):";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(464, 65);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(298, 25);
            this.lblTexto.TabIndex = 37;
            this.lblTexto.Text = "Seleccione una función del Menú";
            // 
            // JugadoresWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JugadoresWF";
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.JugadoresWF_Load);
            this.Controls.SetChildIndex(this.lblTexto, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnJugador;
        private System.Windows.Forms.Button btnEliminarJugadorMenu;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarApellidoNombre;
        private System.Windows.Forms.Label lblDniOApellidoNombre;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApodo;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblIdJugador;
        private System.Windows.Forms.Button btnFutbol;
    }
}