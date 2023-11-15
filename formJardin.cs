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
    public partial class formJardin : Form
    {
        public formJardin()
        {
            InitializeComponent();
        }

        private void formJardin_Load(object sender, EventArgs e)
        {
            modelo.RegistroJardinDAO registrojardinDAO = new modelo.RegistroJardinDAO();
            modelo.EstadosDAO estadosDAO = new modelo.EstadosDAO();
            dgvJardines.DataSource = registrojardinDAO.consultarTodos();
            cmbEstado.DataSource = estadosDAO.consultarTodos();
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.DisplayMember = "nomEstado";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.registro_jardin jardin = new modelo.registro_jardin();
            modelo.estados estados = new modelo.estados();
            modelo.RegistroJardinDAO registrojardinDAO = new modelo.RegistroJardinDAO();
            estados.idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            estados.nomEstado = cmbEstado.Text;
            jardin.nomJardin = tbNombre.Text;
            jardin.direccionJardin = tbDireccion.Text;
            jardin.fk_idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            registrojardinDAO.registrar(jardin);
            dgvJardines.DataSource = registrojardinDAO.consultarTodos();
            tbNombre.Text = "";
            tbDireccion.Text = "";
        }

        private void dgvJardines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtId.Text = dgvJardines.Rows[index].Cells[1].Value.ToString();
            tbNombre.Text = dgvJardines.Rows[index].Cells[2].Value.ToString();
            tbDireccion.Text = dgvJardines.Rows[index].Cells[3].Value.ToString();
            cmbEstado.SelectedValue = dgvJardines.Rows[index].Cells[4].ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.registro_jardin jardin = new modelo.registro_jardin();
            modelo.estados estados = new modelo.estados();
            modelo.RegistroJardinDAO registrojardinDAO = new modelo.RegistroJardinDAO();
            estados.idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            estados.nomEstado = cmbEstado.Text;
            jardin.idJardin = int.Parse(txtId.Text);
            jardin.nomJardin = tbNombre.Text;
            jardin.direccionJardin = tbDireccion.Text;
            jardin.fk_idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            registrojardinDAO.editar(jardin);
            dgvJardines.DataSource = registrojardinDAO.consultarTodos();
            tbNombre.Text = "";
            tbDireccion.Text = "";
            txtId.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modelo.RegistroJardinDAO registrojardinDAO = new modelo.RegistroJardinDAO();
            int idJardin = int.Parse(txtId.Text);

            registrojardinDAO.eliminar(idJardin);
            dgvJardines.DataSource = registrojardinDAO.consultarTodos();
            tbNombre.Text = "";
            tbDireccion.Text = "";
        }
    }
}
