namespace aplicacionICBF
{
    partial class formNiños
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
            this.lblnomUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvNiños = new System.Windows.Forms.DataGridView();
            this.Seleccione = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jardin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecNacimientoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEps = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTipSangre = new System.Windows.Forms.ComboBox();
            this.cmbJardin = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbAcudiente = new System.Windows.Forms.ComboBox();
            this.btnAcudiente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtIdNiño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiños)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnomUser
            // 
            this.lblnomUser.AutoSize = true;
            this.lblnomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblnomUser.Location = new System.Drawing.Point(452, 9);
            this.lblnomUser.Name = "lblnomUser";
            this.lblnomUser.Size = new System.Drawing.Size(0, 31);
            this.lblnomUser.TabIndex = 45;
            this.lblnomUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // fecNacimiento
            // 
            this.fecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecNacimiento.Location = new System.Drawing.Point(206, 533);
            this.fecNacimiento.MinDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.fecNacimiento.Name = "fecNacimiento";
            this.fecNacimiento.Size = new System.Drawing.Size(93, 20);
            this.fecNacimiento.TabIndex = 43;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 176);
            this.txtTelefono.Mask = "999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(166, 20);
            this.txtTelefono.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-162, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telefono";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(298, 581);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 48);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(151, 581);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 48);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvNiños
            // 
            this.dgvNiños.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvNiños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccione,
            this.id,
            this.Nombre,
            this.numIdentificacion,
            this.Telefono,
            this.Direccion,
            this.Ciudad,
            this.Eps,
            this.tipoSangre,
            this.acudiente,
            this.jardin,
            this.fecNacimientoGrid});
            this.dgvNiños.Location = new System.Drawing.Point(350, 67);
            this.dgvNiños.Name = "dgvNiños";
            this.dgvNiños.RowHeadersWidth = 51;
            this.dgvNiños.Size = new System.Drawing.Size(987, 486);
            this.dgvNiños.TabIndex = 38;
            this.dgvNiños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNiños_CellContentClick);
            // 
            // Seleccione
            // 
            this.Seleccione.DataPropertyName = "(ninguno)";
            this.Seleccione.HeaderText = "Seleccionar";
            this.Seleccione.Name = "Seleccione";
            // 
            // id
            // 
            this.id.DataPropertyName = "idNiño";
            this.id.HeaderText = "Codigo del Niño";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numIdentificacion
            // 
            this.numIdentificacion.DataPropertyName = "numidentificacion";
            this.numIdentificacion.HeaderText = "Numero de Identificacion";
            this.numIdentificacion.Name = "numIdentificacion";
            this.numIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefonoNiño";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccionNiño";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "fk_idCiudad";
            this.Ciudad.HeaderText = "Ciudad de nacimiento";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ciudad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Eps
            // 
            this.Eps.DataPropertyName = "fk_idEps";
            this.Eps.HeaderText = "EPS";
            this.Eps.Name = "Eps";
            // 
            // tipoSangre
            // 
            this.tipoSangre.DataPropertyName = "fk_idTipSangre";
            this.tipoSangre.HeaderText = "Tipo de Sangre";
            this.tipoSangre.Name = "tipoSangre";
            // 
            // acudiente
            // 
            this.acudiente.DataPropertyName = "fk_idAcudiente";
            this.acudiente.HeaderText = "Acudiente";
            this.acudiente.Name = "acudiente";
            // 
            // jardin
            // 
            this.jardin.DataPropertyName = "fk_idJardin";
            this.jardin.HeaderText = "Jardin";
            this.jardin.Name = "jardin";
            // 
            // fecNacimientoGrid
            // 
            this.fecNacimientoGrid.DataPropertyName = "fechaNac";
            this.fecNacimientoGrid.HeaderText = "Fecha de nacimiento";
            this.fecNacimientoGrid.Name = "fecNacimientoGrid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-162, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID Madre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(-158, 415);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(109, 48);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(125, 120);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(166, 20);
            this.txtIdentificacion.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-162, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-162, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-162, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Identificacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Direccion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 24);
            this.label12.TabIndex = 46;
            this.label12.Text = "Ciudad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 24);
            this.label13.TabIndex = 46;
            this.label13.Text = "EPS";
            // 
            // cmbEps
            // 
            this.cmbEps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEps.FormattingEnabled = true;
            this.cmbEps.Location = new System.Drawing.Point(125, 357);
            this.cmbEps.Name = "cmbEps";
            this.cmbEps.Size = new System.Drawing.Size(166, 21);
            this.cmbEps.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 442);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 24);
            this.label14.TabIndex = 46;
            this.label14.Text = "Acudiente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 400);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 24);
            this.label15.TabIndex = 46;
            this.label15.Text = "Tipo de Sangre";
            // 
            // cmbTipSangre
            // 
            this.cmbTipSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipSangre.FormattingEnabled = true;
            this.cmbTipSangre.Location = new System.Drawing.Point(151, 400);
            this.cmbTipSangre.Name = "cmbTipSangre";
            this.cmbTipSangre.Size = new System.Drawing.Size(166, 21);
            this.cmbTipSangre.TabIndex = 47;
            // 
            // cmbJardin
            // 
            this.cmbJardin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJardin.FormattingEnabled = true;
            this.cmbJardin.Location = new System.Drawing.Point(125, 488);
            this.cmbJardin.Name = "cmbJardin";
            this.cmbJardin.Size = new System.Drawing.Size(166, 21);
            this.cmbJardin.TabIndex = 49;
            this.cmbJardin.SelectedIndexChanged += new System.EventHandler(this.cmbJardin_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 486);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 24);
            this.label16.TabIndex = 48;
            this.label16.Text = "Jardin";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Lime;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(16, 581);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(109, 48);
            this.btnRegistro.TabIndex = 39;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(125, 299);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(166, 21);
            this.cmbCiudad.TabIndex = 32;
            // 
            // cmbAcudiente
            // 
            this.cmbAcudiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcudiente.FormattingEnabled = true;
            this.cmbAcudiente.Location = new System.Drawing.Point(125, 442);
            this.cmbAcudiente.Name = "cmbAcudiente";
            this.cmbAcudiente.Size = new System.Drawing.Size(192, 21);
            this.cmbAcudiente.TabIndex = 50;
            // 
            // btnAcudiente
            // 
            this.btnAcudiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAcudiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcudiente.Location = new System.Drawing.Point(576, 581);
            this.btnAcudiente.Name = "btnAcudiente";
            this.btnAcudiente.Size = new System.Drawing.Size(216, 48);
            this.btnAcudiente.TabIndex = 39;
            this.btnAcudiente.Text = "Registrar Acudiente";
            this.btnAcudiente.UseVisualStyleBackColor = false;
            this.btnAcudiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 236);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(166, 20);
            this.txtDireccion.TabIndex = 51;
            // 
            // txtIdNiño
            // 
            this.txtIdNiño.AutoSize = true;
            this.txtIdNiño.Location = new System.Drawing.Point(371, 26);
            this.txtIdNiño.Name = "txtIdNiño";
            this.txtIdNiño.Size = new System.Drawing.Size(35, 13);
            this.txtIdNiño.TabIndex = 52;
            this.txtIdNiño.Text = "label7";
            // 
            // formNiños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 656);
            this.Controls.Add(this.txtIdNiño);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbAcudiente);
            this.Controls.Add(this.cmbJardin);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbTipSangre);
            this.Controls.Add(this.cmbEps);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblnomUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fecNacimiento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAcudiente);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvNiños);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNiños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fomNiños";
            this.Load += new System.EventHandler(this.formNiños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecNacimiento;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvNiños;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTipSangre;
        private System.Windows.Forms.ComboBox cmbJardin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbAcudiente;
        private System.Windows.Forms.Button btnAcudiente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccione;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eps;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn jardin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecNacimientoGrid;
        private System.Windows.Forms.Label txtIdNiño;
    }
}