using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1
{
    public partial class LogIN : Form
    {
        Archivo Ingresar;
        string user_verificar;
        string contra_verificar;

        public LogIN()
        {
            InitializeComponent();
        }
        public void DatosP()
        {

            Ingresar = new Archivo();
            Ingresar.Show();
            this.Hide();

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (user.Text.Equals(""))
                    {

                        MessageBox.Show("Usuario incorrecto. Por favor, ingrese uno válido", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (password.Text.Equals(""))
                    {
                        MessageBox.Show("Contraseña incorrecta. Por favor, ingrese nuevamente", "Error de contrase�a", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        user_verificar = user.Text.Trim();
                        contra_verificar = password.Text.Trim();

                        StreamReader leer;
                        leer = File.OpenText("usuarios2.txt");
                        string cadena;
                        string[] arreglo = new string[2];
                        char[] separador = { '-' };
                        bool autorizado = false;
                        cadena = leer.ReadLine();
                        while (cadena != null && autorizado == false)
                        {
                            arreglo = cadena.Split(separador);
                            if (arreglo[0].Trim().Equals(user_verificar) && arreglo[1].Trim().Equals(contra_verificar))
                            {

                                DatosP();
                                autorizado = true;
                            }
                            else
                            {
                                cadena = leer.ReadLine();
                            }
                        }
                        if (autorizado == false)
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrectos", "Login Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }

            private void LogIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Register registroUsuario = new Register();
            this.Hide();
            registroUsuario.Show();
        }
    }
 }
    
   

