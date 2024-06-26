﻿using System;
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
            if(usuarioActual==null) MessageBox.Show($"Por favor, ingrese sesión antes de agregar una nueva tarea");

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (usuarioActual == null) MessageBox.Show($"Por favor, ingrese sesión antes de agregar una nueva tarea");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                string tituloTareaSeleccionada = textBoxTitulo.Text;

                // Buscar la tarea en la lista de tareas del gestor
                Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada, usuarioActual.Username).FirstOrDefault();

                if (tareaSeleccionada != null)
                {
                    ListaTareas.Items.Remove(tareaSeleccionada.Titulo);
                    // Actualizar la tarea en el gestor de tareas
                    controladorTareas.EliminarTarea(tareaSeleccionada);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los datos del usuario desde los campos de texto
                string correo = textBoxCorreoNuevo.Text;
                string contraseña = textContraseñaNueva.Text;
                string nombreUsuario = textBoxUsuarioNuevo.Text;
                bool registroExitoso = true;
                // Llamar al método en el backend para registrar al usuario
                gestorUsuarios.RegistrarUsuario(correo, contraseña, nombreUsuario);
                Usuario usuarioRegistrado = gestorUsuarios.IniciarSesion(correo, contraseña);
                if(usuarioRegistrado==null) registroExitoso=false;
                if (registroExitoso == true)
                {
                    textBoxCorreoNuevo.Text = "";
                    textContraseñaNueva.Text = "";
                    textBoxUsuarioNuevo.Text = "";
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
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
                textBoxCorreo.Text = "";
                textBoxContraseña.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Tarea agregada exitosamente.");
                }
                else if (buttonAgregar.Text == "Modificar")
                {
                    // Obtener el título de la tarea seleccionada
                    string tituloTareaSeleccionada = ListaTareas.SelectedItem.ToString();

                    // Buscar la tarea en la lista de tareas del gestor
                    Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada, usuarioActual.Username).FirstOrDefault();

                    if (tareaSeleccionada != null)
                    {
                        // Crear una instancia actualizada de la tarea
                        Tarea tareaActualizada = new Tarea(titulo, descripcion, fechaVencimiento, prioridad, estado, usuarioActual.Username);

                        // Actualizar la tarea en el gestor de tareas
                        controladorTareas.ActualizarTarea(tareaSeleccionada, tareaActualizada);

                        // Actualizar la CheckedListBox
                        int index = ListaTareas.SelectedIndex;
                        ListaTareas.Items[index] = tareaActualizada.Titulo;
                        MessageBox.Show("Tarea modificada exitosamente.");
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
                    Tarea tareaSeleccionada = controladorTareas.BuscarTareas(tituloTareaSeleccionada, usuarioActual.Username).FirstOrDefault();

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
                        labelAgregaTarea.Text = "Modifica una tarea";
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
                    labelAgregaTarea.Text = "Agrega una tarea";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxUsuarioLogged.Text = "";
                textBoxCorreoLogged.Text = "";
                textBoxTitulo.Text = "";
                textBoxDescrip.Text = "";
                PickerFecha.Text = "";
                comboBoxEstado.Text = "";
                comboBoxPrioridad.Text = "";
                usuarioActual = null;

              
                ListaTareas.Items.Clear();
                MessageBox.Show("Cierre de sesión exitoso.");
            }   
            catch(Exception error)
            {
                MessageBox.Show($"Error: {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaTareas_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void ListaTareas_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            try
            {
                // Obtener el título de la tarea seleccionada
                string tituloTareaSeleccionada = ListaTareas.Items[e.Index].ToString();

                // Buscar la tarea en la lista de tareas del gestor
                Tarea tareaAnt = controladorTareas.BuscarTareas(tituloTareaSeleccionada, usuarioActual.Username).FirstOrDefault();

                if (tareaAnt != null)
                {
                    Tarea tareaSeleccionada = tareaAnt;
                    // Cambiar el estado de la tarea basado en el nuevo estado del check
                    if (e.NewValue == CheckState.Checked)
                    {
                        tareaSeleccionada.Estado = "Terminado";
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        tareaSeleccionada.Estado = "Por Hacer";
                    }

                    // Actualizar la tarea en el gestor de tareas
                    controladorTareas.ActualizarTarea(tareaAnt, tareaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string criterioBusqueda = textBoxBusqueda.Text;

                if (!string.IsNullOrEmpty(criterioBusqueda))
                {
                    // Obtener las tareas filtradas por el criterio de búsqueda
                    List<Tarea> tareasEncontradas = controladorTareas.BuscarTareas(criterioBusqueda, usuarioActual.Username);

                    // Limpiar la CheckedListBox
                    ListaTareas.Items.Clear();

                    // Agregar las tareas encontradas a la CheckedListBox
                    foreach (Tarea tarea in tareasEncontradas)
                    {
                        ListaTareas.Items.Add(tarea.Titulo, tarea.Estado == "Terminada");
                    }
                }
                else
                {
                    // Si el criterio de búsqueda está vacío, mostrar todas las tareas
                    List<Tarea> tareasUsuario = controladorTareas.ObtenerTareasPorUsuario(usuarioActual.Username);

                    // Limpiar la lista de tareas antes de cargar las nuevas tareas
                    ListaTareas.Items.Clear();

                    // Agregar las tareas del usuario a la CheckedListBox
                    foreach (Tarea tarea in tareasUsuario)
                    {
                        ListaTareas.Items.Add(tarea.Titulo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxMetodosOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string metodoOrdenamiento = comboBoxMetodosOrd.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(metodoOrdenamiento))
                {
                    // Ordenar las tareas según el método de ordenamiento seleccionado
                    controladorTareas.OrdenarTareas(metodoOrdenamiento);

                    // Actualizar la CheckedListBox con las tareas ordenadas
                    List<Tarea> tareasUsuario = controladorTareas.ObtenerTareasPorUsuario(usuarioActual.Username);

                    // Limpiar la lista de tareas antes de cargar las nuevas tareas
                    ListaTareas.Items.Clear();

                    // Agregar las tareas del usuario a la CheckedListBox
                    foreach (Tarea tarea in tareasUsuario)
                    {
                        ListaTareas.Items.Add(tarea.Titulo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PickerFecha_ValueChanged(object sender, EventArgs e)
        {
            if (usuarioActual == null) MessageBox.Show($"Por favor, ingrese sesión antes de agregar una nueva tarea");

        }

        private void comboBoxPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usuarioActual == null) MessageBox.Show($"Por favor, ingrese sesión antes de agregar una nueva tarea");

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usuarioActual == null) MessageBox.Show($"Por favor, ingrese sesión antes de agregar una nueva tarea");

        }
    }
}
