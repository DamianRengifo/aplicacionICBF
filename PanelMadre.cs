using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionICBF
{
    public partial class PanelMadre : Form
    {
        public PanelMadre()
        {
            InitializeComponent();

        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAsistencia registroAsistencia = new RegistroAsistencia();
            registroAsistencia.ShowDialog();
        }

        private void registrarAvanceAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAvanceAcademico registroAvanceAcademico = new RegistroAvanceAcademico();
            registroAvanceAcademico.ShowDialog();
            this.Hide();    
        }
    }
}
