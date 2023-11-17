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
    public partial class RegistroAsistencia : Form
    {
        public DateTime fechaHoy = DateTime.Today;
        public RegistroAsistencia()
        {
            InitializeComponent();
            modelo.RegistroAsistenciaDAO registroAsistenciaDAO = new modelo.RegistroAsistenciaDAO();
            dgvAsistencia.DataSource = registroAsistenciaDAO.consultarDatos();
            this.btnActualizar.Enabled = false;
        }

        private void RegistroAsistencia_Load(object sender, EventArgs e)
        {
            txtMadreCom.Text = "Bienvenido " + ClsVariablesGlobales.nomUser + ":)";
            consultarNiños();
            consultarEstados();
        }

        public void consultarNiños()
        {
            modelo.NiñosDAO niñoDAO = new modelo.NiñosDAO();
            cmbNiño.DataSource = niñoDAO.consultarDatos();
            cmbNiño.ValueMember = "idNiño";
            cmbNiño.DisplayMember = "nombre";
        }

        public void consultarEstados()
        {
            modelo.EstadosDAO estadosDAO = new modelo.EstadosDAO();
            cmbEstado.DataSource = estadosDAO.consultarEstadosNiños();
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.DisplayMember = "nomEstado";
        }

        public void resetearCampos()
        {
            dateTimePicker1.ResetText();
            cmbNiño.ResetText();
            cmbEstado.ResetText();
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            idRegAsistencia.Text = dgvAsistencia.Rows[index].Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvAsistencia.Rows[index].Cells[2].Value.ToString());
            cmbEstado.Text = dgvAsistencia.Rows[index].Cells[4].Value.ToString();
            cmbNiño.Text = dgvAsistencia.Rows[index].Cells[3].Value.ToString();
            this.btnActualizar.Enabled = true;
            this.btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.registro_asistencia registroAsistencia = new modelo.registro_asistencia();
            modelo.RegistroAsistenciaDAO registroAsistenciaDAO = new modelo.RegistroAsistenciaDAO();

            registroAsistencia.fechaAsistencia = dateTimePicker1.Value;
            registroAsistencia.fk_idNiño = int.Parse(cmbNiño.SelectedValue.ToString());
            registroAsistencia.fk_idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            registroAsistenciaDAO.registrar(registroAsistencia);
            dgvAsistencia.DataSource = registroAsistenciaDAO.consultarDatos();
            resetearCampos();
            this.btnRegistrar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.registro_asistencia registroAsistencia = new modelo.registro_asistencia();
            modelo.RegistroAsistenciaDAO registroAsistenciaDAO = new modelo.RegistroAsistenciaDAO();
            registroAsistencia.idRegAsistencia = int.Parse(idRegAsistencia.Text);
            registroAsistencia.fechaAsistencia = dateTimePicker1.Value;
            registroAsistencia.fk_idNiño = int.Parse(cmbNiño.SelectedValue.ToString());
            registroAsistencia.fk_idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            registroAsistenciaDAO.actualizar(registroAsistencia);
            dgvAsistencia.DataSource = registroAsistenciaDAO.consultarDatos();
            resetearCampos();
            this.btnRegistrar.Enabled = true;
            this.btnActualizar.Enabled = false;
        }
    }

}      

