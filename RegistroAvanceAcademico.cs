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
    public partial class RegistroAvanceAcademico : Form
    {
        public RegistroAvanceAcademico()
        {
            InitializeComponent();
            modelo.RegistroAvanceAcademico registroAvanceAcademico = new modelo.RegistroAvanceAcademico();
            txtMadreCom.Text = "Bienvenido " + ClsVariablesGlobales.nomUser + ":)";
            consultarNiños();
            consultarNotas();
            consultarNivel();
            dgvAsistencia.DataSource = registroAvanceAcademico.consultarDatos();
        }

        public void consultarNiños()
        {
            modelo.NiñosDAO niñoDAO = new modelo.NiñosDAO();
            cmbNiño.DataSource = niñoDAO.consultarDatos();
            cmbNiño.ValueMember = "idNiño";
            cmbNiño.DisplayMember = "nombre";
        }

        public void consultarNotas()
        {
            modelo.Notas notas = new modelo.Notas();
            cmbNotas.DataSource = notas.consultarTodos();
            cmbNotas.ValueMember = "idNotas";
            cmbNotas.DisplayMember = "nomNotas";
        }

        public void consultarNivel()
        {
            modelo.Nivel nivelDAO = new modelo.Nivel();
            cmbNivel.DataSource = nivelDAO.consultarTodos();
            cmbNivel.ValueMember = "idNivel";
            cmbNivel.DisplayMember = "nomNivel";
        }

        public void resetearCampos() {
            txtAñoEscolar.ResetText();
            txtDescripcion.ResetText();
            dateTimePicker1.ResetText();
            cmbNivel.ResetText();
            cmbNiño.ResetText();
            cmbNotas.ResetText();
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            idRegAsistencia.Text = dgvAsistencia.Rows[index].Cells[1].Value.ToString();
            cmbNiño.Text = dgvAsistencia.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvAsistencia.Rows[index].Cells[3].Value.ToString());
            txtAñoEscolar.Text = dgvAsistencia.Rows[index].Cells[4].Value.ToString();
            txtDescripcion.Text = dgvAsistencia.Rows[index].Cells[5].Value.ToString();
            cmbNotas.Text = dgvAsistencia.Rows[index].Cells[6].Value.ToString();
            cmbNivel.Text = dgvAsistencia.Rows[index].Cells[7].Value.ToString();
            
            this.btnActualizar.Enabled = true;
            this.btnRegistrar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.RegistroAvanceAcademico registroAvanceAcademico = new modelo.RegistroAvanceAcademico();
            modelo.registro_avance_academico registro_Avance_Academico = new modelo.registro_avance_academico();

            registro_Avance_Academico.fk_idNiño = int.Parse(cmbNiño.SelectedValue.ToString());
            registro_Avance_Academico.fecEntregaNotas = dateTimePicker1.Value;
            registro_Avance_Academico.añoEscolar = int.Parse(txtAñoEscolar.Text);
            registro_Avance_Academico.descripcion = txtDescripcion.Text;
            registro_Avance_Academico.fk_idNivel = int.Parse(cmbNivel.SelectedValue.ToString());
            registro_Avance_Academico.fk_idNotas = int.Parse(cmbNotas.SelectedValue.ToString());
            registroAvanceAcademico.registrar(registro_Avance_Academico);
            dgvAsistencia.DataSource = registroAvanceAcademico.consultarDatos();
            resetearCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelo.RegistroAvanceAcademico registroAvanceAcademico = new modelo.RegistroAvanceAcademico();
            modelo.registro_avance_academico registro_Avance_Academico = new modelo.registro_avance_academico();

            registro_Avance_Academico.idRegAvAcademico = int.Parse(idRegAsistencia.Text);
            registro_Avance_Academico.fk_idNiño = int.Parse(cmbNiño.SelectedValue.ToString());
            registro_Avance_Academico.fecEntregaNotas = dateTimePicker1.Value;
            registro_Avance_Academico.añoEscolar = int.Parse(txtAñoEscolar.Text);
            registro_Avance_Academico.descripcion = txtDescripcion.Text;
            registro_Avance_Academico.fk_idNivel = int.Parse(cmbNivel.SelectedValue.ToString());
            registro_Avance_Academico.fk_idNotas = int.Parse(cmbNotas.SelectedValue.ToString());
            registroAvanceAcademico.editarAvance(registro_Avance_Academico);
            dgvAsistencia.DataSource = registroAvanceAcademico.consultarDatos();
            resetearCampos();
        }
    }
}
