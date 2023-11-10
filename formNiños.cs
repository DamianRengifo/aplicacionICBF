using aplicacionICBF.modelo;
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
    public partial class formNiños : Form
    {
        
        public formNiños()
        {
            InitializeComponent();
            NiñosDAO niño = new NiñosDAO();
            dgvNiños.DataSource = niño.consultarNiños();
        }

        

        private void formNiños_Load(object sender, EventArgs e)
        {   
            RegistroJardinDAO registroJardinDAO = new RegistroJardinDAO();
            cmbJardin.DataSource = registroJardinDAO.consultarTodos();
            cmbJardin.ValueMember = "idJardin";
            cmbJardin.DisplayMember = "nomJardin";
            lblnomUser.Text = ClsVariablesGlobales.nomUser.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbJardin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
