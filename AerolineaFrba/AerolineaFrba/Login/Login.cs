using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Login
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
            String username;
            String password;

            if (usernameText.Text == "")
            {
                MessageBox.Show("Ingrese usuario");
            }
            else
            {
                {
                    username = usernameText.Text;

                    if (false/*TODO levantar si el username no está en la base*/)
                    {
                        MessageBox.Show("El usuario no se encuentra registrado en la base de datos");
                    }
                    else if (passwordText.Text == "")
                    {
                        MessageBox.Show("Ingrese password");
                    }
                    else
                    {
                        password = passwordText.Text;

                        int tries = 0;//TODO levantar la cantidad de intentos de la base

                        if (!password.Equals("w23e", StringComparison.Ordinal))
                        {
                            MessageBox.Show("Contraseña incorrecta. Intente nuevamente");
                            tries = 3;
                        }
                        else
                        {
                            MessageBox.Show("Password correcta. Bienvenido");
                        }
                        //TODO generar el HASH con el password y validar que sea igual a la registrada

                        if (tries == 3)
                        {
                            MessageBox.Show("La contraseña se ingresó incorrectamente 3 veces. Se bloqueará el usuario");
                            //TODO setear el usuario a invalidado
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
}
