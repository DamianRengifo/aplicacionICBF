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
                switch (user.fk_idRol) {
                    case 1:
                        MessageBox.Show("Bienvenido Acudiente" + user.nombre + " rol: " + user.fk_idRol);
                    break;

                    case 2:
                        ClsVariablesGlobales.idUser = user.idUsuario;
                        ClsVariablesGlobales.fk_idRol = user.fk_idRol;
                        ClsVariablesGlobales.nomUser = user.nombre;
                        ClsVariablesGlobales.docUser = user.numIdentificacion;
                        MessageBox.Show("Bienvenida Madre Comunitaria" + user.nombre + " rol: " + user.fk_idRol);
                        PanelMadre panelMadre = new PanelMadre();
                        panelMadre.Show();
                        this.Hide();
                    break;

                    case 3:
                        ClsVariablesGlobales.idUser = user.idUsuario;
                        ClsVariablesGlobales.fk_idRol = user.fk_idRol;
                        ClsVariablesGlobales.nomUser = user.nombre;
                        ClsVariablesGlobales.docUser = user.numIdentificacion;
                        MessageBox.Show("Bienvenido " + ClsVariablesGlobales.nomUser + ":)");
                        PanelAdmin panelAdmin = new PanelAdmin();
                        panelAdmin.Show();
                        this.Hide();
                    break;
                }
            }
            
            
            else {
                MessageBox.Show("Usuario o la contraseña esta incorrecta");
            }
        }

    }
}
