namespace aplicacionICBF
{
    partial class RegistroAsistencia
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
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMadreCom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNiño = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.idRegAsistencia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvAsistencia.Location = new System.Drawing.Point(28, 274);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(748, 165);
            this.dgvAsistencia.TabIndex = 0;
            this.dgvAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Asistencia";
            // 
            // txtMadreCom
            // 
            this.txtMadreCom.AutoSize = true;
            this.txtMadreCom.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadreCom.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtMadreCom.Location = new System.Drawing.Point(338, 13);
            this.txtMadreCom.Name = "txtMadreCom";
            this.txtMadreCom.Size = new System.Drawing.Size(71, 30);
            this.txtMadreCom.TabIndex = 2;
            this.txtMadreCom.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niño: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado del niño: ";
            // 
            // cmbNiño
            // 
            this.cmbNiño.FormattingEnabled = true;
            this.cmbNiño.Location = new System.Drawing.Point(357, 57);
            this.cmbNiño.Name = "cmbNiño";
            this.cmbNiño.Size = new System.Drawing.Size(121, 21);
            this.cmbNiño.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(655, 56);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(245, 173);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 46);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Gold;
            this.btnActualizar.Location = new System.Drawing.Point(457, 173);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 46);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Editar Asistencia";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // idRegAsistencia
            // 
            this.idRegAsistencia.AutoSize = true;
            this.idRegAsistencia.Location = new System.Drawing.Point(631, 29);
            this.idRegAsistencia.Name = "idRegAsistencia";
            this.idRegAsistencia.Size = new System.Drawing.Size(35, 13);
            this.idRegAsistencia.TabIndex = 7;
            this.idRegAsistencia.Text = "label4";
            this.idRegAsistencia.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Consultar todas ",
            "Consultar Asistencias anteriores",
            "Consultas mis Registros"});
            this.comboBox1.Location = new System.Drawing.Point(357, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Consultar por: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(484, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.idRegAsistencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbNiño);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMadreCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsistencia);
            this.Name = "RegistroAsistencia";
            this.Text = "RegistroAsistencia";
            this.Load += new System.EventHandler(this.RegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMadreCom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNiño;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label idRegAsistencia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}