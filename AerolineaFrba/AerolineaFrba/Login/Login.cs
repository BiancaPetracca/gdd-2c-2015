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
            if (user.Username != this.Usuario.Text)
            {
                user.Intentos = 0;
                user.Username = this.Usuario.Text;
                user.Password = this.pass.Text;
                user.Estado = DAO.DAOLogin.getEstado(user);
                user.Rol = (DAO.DAOLogin.obtenerRolUsuario(user) == 1)? "Administrativo" : "Cliente";
                if (user.Estado == -1)
                {
                    MessageBox.Show("El usuario está inhabilitado!");
                    Extensions.cleanAll(this.Controls);
                    return;
                }
            }
            if (user.Intentos >= 3)
            {
                DAO.DAOLogin.inhabilitarUsuario(user);
                MessageBox.Show("Usuario inhabilitado");
                return;
            }

            if (this.validateNotNullForAll(this.Controls))
            {
                if (puedeAcceder(user.Rol) && (DAO.DAOLogin.validarUsername(user.Username, user.Password, this.Rol.value) == 1))
                {
                    user.Intentos = 0;

                    this.openInNewWindow(new MainMenu());
                    this.Close();
                    return;
                }
                
                    user.Intentos++;
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


        private Boolean puedeAcceder(String rol)
        {
            if (rol == "Administrativo") { return true; }
            return (this.Rol.SelectedItem.ToString() == "Cliente");
        }
    }
}
