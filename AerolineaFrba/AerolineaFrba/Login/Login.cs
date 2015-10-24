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

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {
            if (intentosLogin > 3)
            {
                MessageBox.Show(this,"Logueo incorrecto reiteradas veces, espere");
            }

            try
            {
                if ((textBox_Username.Text == String.Empty) || (textBox_password.Text == String.Empty))
                {
                    throw new Exception("Debe Ingresar todos los campos");
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

            username = textBox_Username.Text;
            password = textBox_password.Text;

            if (usuarioValido())
            {
                intentosLogin = 0;
                Application.Run(new Inicio());
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

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_IniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
