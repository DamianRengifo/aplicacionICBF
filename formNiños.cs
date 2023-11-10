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
            lblnomUser.Text = ClsVariablesGlobales.nomUser.ToString();

        }
    }
}
