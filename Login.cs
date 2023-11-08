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
            var rol = (from j in bd.obtenerRol(txtDocumento.Text, txtClave.Text) select j)
                .FirstOrDefault();
            var rolUser = rol.fk_idRol;
            if (user != null)
            {
                
                MessageBox.Show("Bienvenido " + user.nombre + " rol: " + rolUser.GetType());
            }
            else {
                MessageBox.Show(".i.");
            }
        }
    }
}
