namespace aplicacionICBF
{
    partial class PanelMadre
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
            this.registrarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAvanceAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAsistenciaToolStripMenuItem,
            this.registrarAvanceAcademicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarAsistenciaToolStripMenuItem
            // 
            this.registrarAsistenciaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarAsistenciaToolStripMenuItem.Name = "registrarAsistenciaToolStripMenuItem";
            this.registrarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(228, 35);
            this.registrarAsistenciaToolStripMenuItem.Text = "Registrar Asistencia";
            this.registrarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarAsistenciaToolStripMenuItem_Click);
            // 
            // registrarAvanceAcademicoToolStripMenuItem
            // 
            this.registrarAvanceAcademicoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarAvanceAcademicoToolStripMenuItem.Name = "registrarAvanceAcademicoToolStripMenuItem";
            this.registrarAvanceAcademicoToolStripMenuItem.Size = new System.Drawing.Size(319, 35);
            this.registrarAvanceAcademicoToolStripMenuItem.Text = "Registrar Avance Academico";
            this.registrarAvanceAcademicoToolStripMenuItem.Click += new System.EventHandler(this.registrarAvanceAcademicoToolStripMenuItem_Click);
            // 
            // PanelMadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelMadre";
            this.Text = "PanelMadre";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAvanceAcademicoToolStripMenuItem;
    }
}