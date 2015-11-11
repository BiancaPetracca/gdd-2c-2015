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
        private String username = "";
        private String password;
        private int intentosLogin;
      

        public Login()
        {
            InitializeComponent();
            intentosLogin = 0;
            
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (username != Usuario.Text) {
                username = Usuario.Text;
                // ASIGNARLE LOS INTENTOS AL USUARIO 
                intentosLogin = 0;
            }

                if (intentosLogin >= 3)
            {
                // TODO INHABILITAR AL USUARIO 
                MessageBox.Show("Usuario inhabilitado");
            }
            else

                    // asigna los intentos que tiene y permite o no correr la app
            {
                if (!this.validateNotNullForAll(this.Controls))
                {
                    username = Usuario.Text;
                    password = Contraseña.Text;
                }
                if (usuarioValido())
                {
                    intentosLogin = 0;
                    Application.Run(new MainMenu());
                }
                else
                {
                    intentosLogin++;
                    MessageBox.Show("Usuario o password incorrecto. Vuelva a intentar. Intentos restantes: " + (3 - intentosLogin));
                }
            }
        }

        private bool usuarioValido()
        {
            return this.validarUsername("validar_usuario", username,password);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            intentosLogin = 0;
        }

    }
}
