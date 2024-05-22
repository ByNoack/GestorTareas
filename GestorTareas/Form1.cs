using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaGestorTareas.Clases;

namespace GestorTareas
{
    public partial class Form1 : Form
    {
        private GestorUsuarios gestorUsuarios = new GestorUsuarios();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarTarea_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            // Capturar los datos del usuario desde los campos de texto
            string correo = textBoxCorreoNuevo.Text;
            string contraseña = textContraseñaNueva.Text;
            string nombreUsuario = textBoxUsuarioNuevo.Text;

            // Llamar al método en el backend para registrar al usuario
            // Suponiendo que tienes una instancia de la clase GestorUsuarios llamada gestorUsuarios
            gestorUsuarios.RegistrarUsuario(correo, contraseña, nombreUsuario);
            textBoxCorreoNuevo.Text = "";
            textContraseñaNueva.Text = "";
            textBoxUsuarioNuevo.Text = "";
            // Actualizar la interfaz de usuario u ofrecer retroalimentación al usuario, si es necesario
            MessageBox.Show("Usuario registrado exitosamente.");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Capturar los datos del usuario desde los campos de texto
            string correo = textBoxCorreo.Text;
            string contraseña = textBoxContraseña.Text;

            // Verificar las credenciales del usuario
            Usuario usuario = gestorUsuarios.IniciarSesion(correo, contraseña);
           
            if (usuario != null)
            {
                // Las credenciales son válidas, permitir el acceso a la aplicación
                MessageBox.Show($"¡Bienvenido, {usuario.Username}!");
                textBoxUsuarioLogged.Text = usuario.Username;
                textBoxCorreoLogged.Text = usuario.Email; 
            }
            else
            {
                // Las credenciales son inválidas, mostrar un mensaje de error
                MessageBox.Show("Correo electrónico o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            }

        }

        private void textBoxUsuarioLogged_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
