using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Examen_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario Usuario = new Usuario();

            Usuario = usuarioDA.Login(CodigoTextBox.Text , ClaveTextBox.Text);

            if (Usuario == null)
            {
                MessageBox.Show("Codigo o Contraseña Incorrecta, Intentelo de nuevo");
                return;

            }

            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide(); 



        }
    }
}
