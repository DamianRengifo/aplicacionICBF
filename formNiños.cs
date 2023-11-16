using aplicacionICBF.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aplicacionICBF
{
    public partial class formNiños : Form
    {

        public formNiños()
        {
            InitializeComponent();
            NiñosDAO niño = new NiñosDAO();
            // var datos = niño.consultarDatos();
            dgvNiños.DataSource = niño.consultarDatos();
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

        public void cargarAcudiente()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            cmbAcudiente.DataSource = usuarioDAO.consultarAcudiente();
            cmbAcudiente.ValueMember = "idUsuario";
            cmbAcudiente.DisplayMember = "nombre";
        }

        public void cargarEps()
        {
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
            modelo.niños niños = new modelo.niños();
            modelo.NiñosDAO niñosDao = new modelo.NiñosDAO();
            modelo.eps eps = new modelo.eps();
            modelo.usuarios acudiente = new modelo.usuarios();
            modelo.tipo_sangre tipSangre = new modelo.tipo_sangre();
            modelo.registro_jardin jardin = new modelo.registro_jardin();
            modelo.ciudad_nacimiento ciudad = new modelo.ciudad_nacimiento();

            niños.nombre = txtNombre.Text;
            niños.numIdentificacion = txtIdentificacion.Text;
            niños.telefonoNiño = txtTelefono.Text;
            niños.direccionNiño = txtDireccion.Text;
            niños.fechaNac = fecNacimiento.Value;
            niños.fk_idEps = int.Parse(cmbEps.SelectedValue.ToString());
            eps.nomEps = cmbEps.Text;
            niños.fk_idAcudiente = int.Parse(cmbAcudiente.SelectedValue.ToString());
            acudiente.nombre = cmbAcudiente.Text;
            niños.fk_idTipSangre = int.Parse(cmbTipSangre.SelectedValue.ToString());
            tipSangre.nomTipoSangre = cmbTipSangre.Text;
            niños.fk_idJardin = int.Parse(cmbJardin.SelectedValue.ToString());
            jardin.nomJardin = cmbJardin.Text;
            niños.fk_idCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            ciudad.nomCiudad = cmbCiudad.Text;
            niñosDao.registrarNiños(niños);
            dgvNiños.DataSource = niñosDao.consultarDatos();
            reiniciarVariables();
        }

        private void dgvNiños_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            int index = e.RowIndex;
            txtIdNiño.Text = txtNombre.Text = dgvNiños.Rows[index].Cells[1].Value.ToString();
            txtNombre.Text = dgvNiños.Rows[index].Cells[2].Value.ToString();
            txtIdentificacion.Text = dgvNiños.Rows[index].Cells[3].Value.ToString();
            txtTelefono.Text = dgvNiños.Rows[index].Cells[4].Value.ToString();
            txtDireccion.Text = dgvNiños.Rows[index].Cells[5].Value.ToString();
            cmbCiudad.SelectedIndex = cmbCiudad.FindStringExact(dgvNiños.Rows[index].Cells[6].Value.ToString());
            cmbEps.SelectedIndex = cmbEps.FindStringExact(dgvNiños.Rows[index].Cells[7].Value.ToString());
            cmbTipSangre.SelectedIndex = cmbTipSangre.FindStringExact(dgvNiños.Rows[index].Cells[8].Value.ToString());
            cmbAcudiente.SelectedIndex = cmbAcudiente.FindStringExact(dgvNiños.Rows[index].Cells[9].Value.ToString());
            cmbJardin.SelectedIndex = cmbJardin.FindStringExact(dgvNiños.Rows[index].Cells[10].Value.ToString());
            fecNacimiento.Value = Convert.ToDateTime(dgvNiños.Rows[index].Cells[11].Value.ToString());
        }
        public void reiniciarVariables()
        {
            txtNombre.ResetText();
            txtIdentificacion.ResetText();
            txtTelefono.ResetText();
            txtDireccion.ResetText();
            fecNacimiento.ResetText();
            cmbAcudiente.ResetText();

        }

        public void activarBotones(int numero)
        {
            this.btnRegistro.Enabled = numero == 1;
            this.btnActualizar.Enabled = numero == 0;
            this.btnBorrar.Enabled = numero == 0;
        }

        public void comprobarVariables()
        {
            if (txtNombre.Text == "" || txtIdentificacion.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                activarBotones(0);
            }
            else
            {
                activarBotones(1);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.niños niños = new modelo.niños();
            modelo.NiñosDAO niñosDao = new modelo.NiñosDAO();
            modelo.eps eps = new modelo.eps();
            modelo.usuarios acudiente = new modelo.usuarios();
            modelo.tipo_sangre tipSangre = new modelo.tipo_sangre();
            modelo.registro_jardin jardin = new modelo.registro_jardin();
            modelo.ciudad_nacimiento ciudad = new modelo.ciudad_nacimiento();

            niños.idNiño = int.Parse(txtIdNiño.Text);
            niños.nombre = txtNombre.Text;
            niños.numIdentificacion = txtIdentificacion.Text;
            niños.telefonoNiño = txtTelefono.Text;
            niños.direccionNiño = txtDireccion.Text;
            niños.fechaNac = fecNacimiento.Value;
            niños.fk_idEps = int.Parse(cmbEps.SelectedValue.ToString());
            eps.nomEps = cmbEps.Text;
            niños.fk_idAcudiente = int.Parse(cmbAcudiente.SelectedValue.ToString());
            acudiente.nombre = cmbAcudiente.Text;
            niños.fk_idTipSangre = int.Parse(cmbTipSangre.SelectedValue.ToString());
            tipSangre.nomTipoSangre = cmbTipSangre.Text;
            niños.fk_idJardin = int.Parse(cmbJardin.SelectedValue.ToString());
            jardin.nomJardin = cmbJardin.Text;
            niños.fk_idCiudad = int.Parse(cmbCiudad.SelectedValue.ToString());
            ciudad.nomCiudad = cmbCiudad.Text;
            niñosDao.editarNiño(niños);
            dgvNiños.DataSource = niñosDao.consultarDatos();
            reiniciarVariables();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modelo.NiñosDAO niñosDao = new modelo.NiñosDAO();
            int idNiño = int.Parse(txtIdNiño.Text);
            niñosDao.eliminarNiño(idNiño);
            dgvNiños.DataSource = niñosDao.consultarDatos();
            reiniciarVariables();
        }
    }

}
