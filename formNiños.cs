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
            cargarJardines();
            cargarCiudad();
            cargarTipoSangre();
            cargarAcudiente();
            cargarEps();
        }

        public void cargarJardines()
        {
            RegistroJardinDAO registroJardinDAO = new RegistroJardinDAO();
            cmbJardin.DataSource = registroJardinDAO.consultarTodos();
            cmbJardin.ValueMember = "idJardin";
            cmbJardin.DisplayMember = "nomJardin";
        }

        public void cargarCiudad()
        {
            CiudadDAO ciudadDao = new CiudadDAO();
            cmbCiudad.DataSource = ciudadDao.consultarTodos();
            cmbCiudad.ValueMember = "idCiudad";
            cmbCiudad.DisplayMember = "nomCiudad";
        }

        public void cargarTipoSangre()
        { 
            TipoSangreDAO tipoSangreDAO = new TipoSangreDAO();
            cmbTipSangre.DataSource = tipoSangreDAO.consultarTodos();
            cmbTipSangre.ValueMember = "idTipoSangre";
            cmbTipSangre.DisplayMember = "nomTipoSangre";
        }

        public void cargarAcudiente() { 
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            cmbAcudiente.DataSource = usuarioDAO.consultarAcudiente();
            cmbAcudiente.ValueMember = "idUsuario";
            cmbAcudiente.DisplayMember = "nombre";
        }

        public void cargarEps() {
            EpsDAO epsDAO = new EpsDAO();
            cmbEps.DataSource = epsDAO.consultarTodos();
            cmbEps.ValueMember = "idEps";
            cmbEps.DisplayMember = "nomEps";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbJardin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            modelo.NiñosDAO niños = new modelo.NiñosDAO();
            NiñosDAO niñosDAO = new NiñosDAO();
            

        }
    }
}
