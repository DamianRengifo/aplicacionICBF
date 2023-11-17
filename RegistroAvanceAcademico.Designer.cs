namespace aplicacionICBF
{
    partial class RegistroAvanceAcademico
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
            this.idRegAsistencia = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbNiño = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMadreCom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtAñoEscolar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // idRegAsistencia
            // 
            this.idRegAsistencia.AutoSize = true;
            this.idRegAsistencia.Location = new System.Drawing.Point(841, 34);
            this.idRegAsistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idRegAsistencia.Name = "idRegAsistencia";
            this.idRegAsistencia.Size = new System.Drawing.Size(44, 16);
            this.idRegAsistencia.TabIndex = 21;
            this.idRegAsistencia.Text = "label4";
            this.idRegAsistencia.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(732, 255);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 57);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Editar Asistencia";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(257, 255);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 57);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbNiño
            // 
            this.cmbNiño.FormattingEnabled = true;
            this.cmbNiño.Location = new System.Drawing.Point(108, 66);
            this.cmbNiño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNiño.Name = "cmbNiño";
            this.cmbNiño.Size = new System.Drawing.Size(160, 24);
            this.cmbNiño.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtMadreCom
            // 
            this.txtMadreCom.AutoSize = true;
            this.txtMadreCom.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadreCom.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtMadreCom.Location = new System.Drawing.Point(451, 15);
            this.txtMadreCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMadreCom.Name = "txtMadreCom";
            this.txtMadreCom.Size = new System.Drawing.Size(91, 37);
            this.txtMadreCom.TabIndex = 14;
            this.txtMadreCom.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Niño: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de Entrega de Notas";
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvAsistencia.Location = new System.Drawing.Point(37, 336);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.Size = new System.Drawing.Size(997, 203);
            this.dgvAsistencia.TabIndex = 9;
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 125;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 117);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(439, 130);
            this.txtDescripcion.TabIndex = 22;
            this.txtDescripcion.Text = "";
            // 
            // txtAñoEscolar
            // 
            this.txtAñoEscolar.Location = new System.Drawing.Point(845, 70);
            this.txtAñoEscolar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAñoEscolar.Mask = "9999";
            this.txtAñoEscolar.Name = "txtAñoEscolar";
            this.txtAñoEscolar.Size = new System.Drawing.Size(132, 22);
            this.txtAñoEscolar.TabIndex = 23;
            this.txtAñoEscolar.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Año Escolar: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Notas: ";
            // 
            // cmbNotas
            // 
            this.cmbNotas.FormattingEnabled = true;
            this.cmbNotas.Location = new System.Drawing.Point(752, 118);
            this.cmbNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNotas.Name = "cmbNotas";
            this.cmbNotas.Size = new System.Drawing.Size(160, 24);
            this.cmbNotas.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nivel: ";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(752, 166);
            this.cmbNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(160, 24);
            this.cmbNivel.TabIndex = 16;
            // 
            // RegistroAvanceAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(216)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAñoEscolar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.idRegAsistencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbNotas);
            this.Controls.Add(this.cmbNiño);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMadreCom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsistencia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroAvanceAcademico";
            this.Text = "RegistroAvanceAcademico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idRegAsistencia;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbNiño;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtMadreCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox txtAñoEscolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNivel;
    }
}