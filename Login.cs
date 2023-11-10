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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            modelo.ORMDataContext bd = new modelo.ORMDataContext();
            
            var user = (from j in bd.login(txtDocumento.Text, txtClave.Text) select j).FirstOrDefault();
            if (user != null)
            {
                if (user.fk_idRol == 1)
                {
                    ClsVariablesGlobales.idUser = user.idUsuario;
                    ClsVariablesGlobales.fk_idRol = user.fk_idRol;
                    ClsVariablesGlobales.nomUser = user.nombre;
                    ClsVariablesGlobales.docUser = user.numIdentificacion;
                    MessageBox.Show(ClsVariablesGlobales.nomUser);
                    PanelAdmin panelAdmin = new PanelAdmin();
                    panelAdmin.Show();
                    this.Hide();
                }
                if (user.fk_idRol == 2) {
                    MessageBox.Show("Bienvenida Madre Comunitaria" + user.nombre + " rol: " + user.fk_idRol);
                }

                if (user.fk_idRol == 3) {
                    MessageBox.Show("Bienvenido Administrador" + user.nombre + " rol: " + user.fk_idRol);
                }
            }
            
            
            else {
                MessageBox.Show("Usuario o la contraseña esta incorrecta");
            }
        }
    }
}
