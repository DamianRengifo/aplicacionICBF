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
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MadreComunitaria madreComunitaria = new MadreComunitaria();
            madreComunitaria.ShowDialog();
        }

        private void consultarJardinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formJardin formJardin = new formJardin();
            formJardin.ShowDialog();
        }

        private void consultarNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNiños formNiños = new formNiños();
            formNiños.ShowDialog();
        }

        private void consultarMadresComunitariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MadreComunitaria formMadres = new MadreComunitaria();
            formMadres.ShowDialog();
        }

        private void consultarAcudientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcudiente frmAcudiente = new FormAcudiente();
            frmAcudiente.ShowDialog();
        }
    }
}
