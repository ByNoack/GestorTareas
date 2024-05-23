using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorTareas.Clases;

namespace GestorTareas
{
    public partial class Form1 : Form
    {
        private GestorUsuarios gestorUsuarios = new GestorUsuarios();
        private ControladorTareas controladorTareas = new ControladorTareas();
        private Usuario usuarioActual;
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
        private void ListaTareas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                // Obtener el título de la tarea seleccionada
                string tituloTareaSeleccionada = ListaTareas.Items[e.Index].ToString();

                // Buscar la tarea en la lista de tareas del gestor
                Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada).FirstOrDefault();

                if (tareaSeleccionada != null)
                {
                    // Cambiar el estado de la tarea basado en el nuevo estado del check
                    if (e.NewValue == CheckState.Checked)
                    {
                        tareaSeleccionada.Estado = "Terminada";
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        tareaSeleccionada.Estado = "Por Hacer";
                    }

                    // Actualizar la tarea en el gestor de tareas
                    controladorTareas.ActualizarTarea(tareaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                usuarioActual = usuario;
                
                List<Tarea> tareasUsuario = controladorTareas.ObtenerTareasPorUsuario(usuario.Username);

                // Limpiar la lista de tareas antes de cargar las nuevas tareas
                ListaTareas.Items.Clear();

                // Agregar las tareas del usuario a la CheckedListBox
                foreach (Tarea tarea in tareasUsuario)
                {
                    ListaTareas.Items.Add(tarea.Titulo);
                }

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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = textBoxTitulo.Text;
                string descripcion = textBoxDescrip.Text;
                DateTime fechaVencimiento = PickerFecha.Value;
                string prioridad = comboBoxPrioridad.SelectedItem?.ToString();
                string estado = comboBoxEstado.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(prioridad) || string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (buttonAgregar.Text == "Agregar")
                {
                    // Crear una nueva instancia de la tarea con los datos ingresados
                    Tarea nuevaTarea = new Tarea(titulo, descripcion, fechaVencimiento, prioridad, estado, usuarioActual.Username);

                    // Agregar la nueva tarea al gestor de tareas
                    controladorTareas.AgregarTarea(nuevaTarea);

                    // Actualizar la CheckedListBox con la nueva tarea
                    ListaTareas.Items.Add(nuevaTarea.Titulo);
                }
                else if (buttonAgregar.Text == "Modificar")
                {
                    // Obtener el título de la tarea seleccionada
                    string tituloTareaSeleccionada = ListaTareas.SelectedItem.ToString();

                    // Buscar la tarea en la lista de tareas del gestor
                    Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada).FirstOrDefault();

                    if (tareaSeleccionada != null)
                    {
                        // Crear una instancia actualizada de la tarea
                        Tarea tareaActualizada = new Tarea(titulo, descripcion, fechaVencimiento, prioridad, estado, usuarioActual.Username);

                        // Actualizar la tarea en el gestor de tareas
                        controladorTareas.ActualizarTarea(tareaActualizada);

                        // Actualizar la CheckedListBox
                        int index = ListaTareas.SelectedIndex;
                        ListaTareas.Items[index] = tareaActualizada.Titulo;
                    }
                }

                // Limpiar los controles de entrada
                textBoxTitulo.Clear();
                textBoxDescrip.Clear();
                PickerFecha.Value = DateTime.Now;
                comboBoxPrioridad.SelectedIndex = -1;
                comboBoxEstado.SelectedIndex = -1;

                // Cambiar el texto del botón a "Agregar"
                buttonAgregar.Text = "Agregar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ListaTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListaTareas.SelectedIndex != -1)
                {
                    // Obtener el título de la tarea seleccionada
                    string tituloTareaSeleccionada = ListaTareas.SelectedItem.ToString();

                    // Buscar la tarea en la lista de tareas del gestor
                    Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada).FirstOrDefault();

                    if (tareaSeleccionada != null)
                    {
                        // Mostrar la información de la tarea en los controles
                        textBoxTitulo.Text = tareaSeleccionada.Titulo;
                        textBoxDescrip.Text = tareaSeleccionada.Descripcion;
                        PickerFecha.Value = tareaSeleccionada.FechaVenc;
                        comboBoxPrioridad.SelectedItem = tareaSeleccionada.Prioridad;
                        comboBoxEstado.SelectedItem = tareaSeleccionada.Estado;

                        // Cambiar el texto del botón a "Modificar"
                        buttonAgregar.Text = "Modificar";
                    }
                }
                else
                {
                    // Si no hay tarea seleccionada, limpiar los controles
                    textBoxTitulo.Clear();
                    textBoxDescrip.Clear();
                    PickerFecha.Value = DateTime.Now;
                    comboBoxPrioridad.SelectedIndex = -1;
                    comboBoxEstado.SelectedIndex = -1;

                    // Cambiar el texto del botón a "Agregar"
                    buttonAgregar.Text = "Agregar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
