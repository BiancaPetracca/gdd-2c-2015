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
        private String username;
        private String password;
        private int intentosLogin;
        private DAOLogin dao;

        public Login()
        {
            InitializeComponent();
            dao = new DAOLogin();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (intentosLogin > 3)
            {
                MessageBox.Show(this,"Logueo incorrecto reiteradas veces, espere");
            }


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
                MessageBox.Show("Usuario o password incorrecto. Vuelva a intentar");
            }
        }

        private bool usuarioValido()
        {
            return dao.validarUsername("validar_usuario", username,password);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
