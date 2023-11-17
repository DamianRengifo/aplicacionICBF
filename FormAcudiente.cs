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
    public partial class FormAcudiente : Form
    {
        public FormAcudiente()
        {
            InitializeComponent();
            modelo.UsuarioDAO acudiente = new modelo.UsuarioDAO();
            dgvAcudiente.DataSource = acudiente.consultarAcudiente();
        }

        private void dgvAcudiente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtIdMadre.Text = dgvAcudiente.Rows[index].Cells[1].Value.ToString();
            txtNombre.Text = dgvAcudiente.Rows[index].Cells[2].Value.ToString();
            txtIdentificacion.Text = dgvAcudiente.Rows[index].Cells[3].Value.ToString();
            txtTelefono.Text = dgvAcudiente.Rows[index].Cells[4].Value.ToString();
            txtCelular.Text = dgvAcudiente.Rows[index].Cells[5].Value.ToString();
            txtdireccion.Text = dgvAcudiente.Rows[index].Cells[6].Value.ToString();
            txtCorreo.Text = dgvAcudiente.Rows[index].Cells[7].Value.ToString();
        }

        public void resetearCampos() {
            txtCelular.ResetText();
            txtContraseña.ResetText();
            txtTelefono.ResetText();
            txtNombre.ResetText();
            txtIdentificacion.ResetText();
            txtdireccion.ResetText();
            txtCorreo.ResetText();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.UsuarioDAO acudienteDAO = new modelo.UsuarioDAO();
            modelo.usuarios acudiente = new modelo.usuarios();

            acudiente.nombre = txtNombre.Text;
            acudiente.numIdentificacion = txtIdentificacion.Text;
            acudiente.telefono = txtTelefono.Text;
            acudiente.celular = txtCelular.Text;
            acudiente.direccion = txtdireccion.Text;
            acudiente.email = txtCorreo.Text;
            acudiente.fechaNacimiento = dateTimePicker1.Value;
            acudiente.clave = txtContraseña.Text;
            acudienteDAO.registrarAcudiente(acudiente);
            dgvAcudiente.DataSource = acudienteDAO.consultarAcudiente();
            resetearCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.UsuarioDAO acudienteDAO = new modelo.UsuarioDAO();
            modelo.usuarios acudiente = new modelo.usuarios();

            acudiente.idUsuario = int.Parse(txtIdMadre.Text);
            acudiente.nombre = txtNombre.Text;
            acudiente.numIdentificacion = txtIdentificacion.Text;
            acudiente.telefono = txtTelefono.Text;
            acudiente.celular = txtCelular.Text;
            acudiente.direccion = txtdireccion.Text;
            acudiente.email = txtCorreo.Text;
            acudiente.fechaNacimiento = dateTimePicker1.Value;
            if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                acudiente.clave = txtContraseña.Text;
            }
            else
            {
                // Si txtContraseña está vacío, mantener la contraseña existente
                acudiente.clave = ""; // O bien, podrías asignar madre.clave = null; dependiendo de cómo se manejan los valores en la base de datos
            }
            acudienteDAO.actualizarAcudiente(acudiente);
            dgvAcudiente.DataSource = acudienteDAO.consultarAcudiente();
            resetearCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modelo.UsuarioDAO acudienteDAO = new UsuarioDAO();
            int idAcudiente = int.Parse(txtIdMadre.Text);
            acudienteDAO.eliminarUsuario(idAcudiente);
            dgvAcudiente.DataSource = acudienteDAO.consultarAcudiente();
            resetearCampos();
        }
    }
}
