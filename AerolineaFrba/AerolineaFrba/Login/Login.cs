using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.DAO;
using AerolineaFrba.Generics;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.Login
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();

        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (this.validateNotNullForAll(Controls))
            {
                if (!DAO.DAOLogin.existeUsuario(Usuario.value))
                {
                    MessageBox.Show("El usuario no es válido");
                    return;
                }



                Model.Usuario user = new Model.Usuario(Usuario.value, pass.value);
                user.Intentos = DAO.DAOLogin.getIntentos(user);
                user.Estado = user.Intentos >= 3 ? false : true;
                user.Rol = DAO.DAOLogin.obtenerRolUsuario(user);
                user.IDRol = DAO.DAOLogin.obtenerIDRolUsuario(user);

               


                if (!user.Estado)
                {
                    MessageBox.Show("El usuario está inhabilitado!");
                    Extensions.cleanAll(this.Controls);
                    return;
                }

                if (user.IDRol != 0) {
                    MessageBox.Show("El usuario no es administrativo, por lo tanto no puede loguearse");
                    return;
                }


                if (DAO.DAOLogin.validarUsername(user.Username, user.Password) == 1)
                {
                    user.Intentos = DAO.DAOLogin.vaciarIntentos(user);
                    List<Decimal> funcionalidades = DAO.DAORol.getIdFuncionalidades(user.IDRol);
                    this.openInNewWindow(new MainMenu(funcionalidades, user.IDRol));
                    this.Close();
                    return;
                }

                user.Intentos = DAO.DAOLogin.aumentarIntentos(user);
                if (user.Intentos == 3) { MessageBox.Show("Usuario inhabilitado!"); return; }
                MessageBox.Show("Usuario o password incorrecto. Vuelva a intentar. Intentos restantes: " + (3 - user.Intentos));



            }
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            user = new Model.Usuario(this.Usuario.Text, this.pass.Text);

        }

        private Model.Usuario user;

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.allowAlphanumericOnly(e);
        }

    }
}
