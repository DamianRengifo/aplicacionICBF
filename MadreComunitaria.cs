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
    public partial class MadreComunitaria : Form
    {
        public MadreComunitaria()
        {
            InitializeComponent();
            UsuarioDAO madre = new UsuarioDAO();
            dgvMadreCom.DataSource = madre.consultarMadreComunitaria();
        }

        public void reiniciarCampos()
        {
            txtNombre.ResetText();
            txtIdentificacion.ResetText();
            txtTelefono.ResetText();
            txtdireccion.ResetText();
            txtContraseña.ResetText();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.usuarios madre = new modelo.usuarios();
            modelo.UsuarioDAO madreDAO = new modelo.UsuarioDAO();
            madre.numIdentificacion = txtIdentificacion.Text;
            madre.nombre = txtNombre.Text;
            madre.celular = txtTelefono.Text;
            madre.direccion = txtdireccion.Text;
            madre.fechaNacimiento = dateTimePicker1.Value;
            madre.clave = txtContraseña.Text;
            madreDAO.registrarMadre(madre);
            dgvMadreCom.DataSource = madreDAO.consultarMadreComunitaria();
            reiniciarCampos();
        }

        private void dgvMadreCom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtIdMadre.Text = dgvMadreCom.Rows[index].Cells[1].Value.ToString();
            txtIdentificacion.Text = dgvMadreCom.Rows[index].Cells[3].Value.ToString();
            txtNombre.Text = dgvMadreCom.Rows[index].Cells[2].Value.ToString();
            txtTelefono.Text = dgvMadreCom.Rows[index].Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvMadreCom.Rows[index].Cells[6].Value.ToString());
            txtdireccion.Text = dgvMadreCom.Rows[index].Cells[5].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.usuarios madre = new modelo.usuarios();
            modelo.UsuarioDAO madreDAO = new modelo.UsuarioDAO();
            madre.idUsuario = int.Parse(txtIdMadre.Text);
            madre.nombre = txtNombre.Text;
            madre.numIdentificacion = txtIdentificacion.Text;
            madre.celular = txtTelefono.Text;
            madre.direccion = txtdireccion.Text;
            madre.fechaNacimiento = dateTimePicker1.Value;
            if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                madre.clave = txtContraseña.Text;
            }
            else
            {
                // Si txtContraseña está vacío, mantener la contraseña existente
                madre.clave = ""; // O bien, podrías asignar madre.clave = null; dependiendo de cómo se manejan los valores en la base de datos
            }
            madreDAO.actualizarMadre(madre);
            dgvMadreCom.DataSource = madreDAO.consultarMadreComunitaria();
            reiniciarCampos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modelo.UsuarioDAO madreDAO = new UsuarioDAO();
            int idMadre = int.Parse(txtIdMadre.Text);
            madreDAO.eliminarUsuario(idMadre);
            dgvMadreCom.DataSource = madreDAO.consultarMadreComunitaria();
            reiniciarCampos();
        }
    }
}
