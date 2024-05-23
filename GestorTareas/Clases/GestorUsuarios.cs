using GestorTareas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GestorTareas.Clases
{
    internal class GestorUsuarios
    {
        private List<Usuario> listaUsuarios;
        private string rutaArchivoUsuarios = "usuarios.txt"; // Ruta del archivo de texto para almacenar los usuarios

        public GestorUsuarios()
        {
            // Inicializar la lista de usuarios
            listaUsuarios = new List<Usuario>();

            // Cargar los usuarios desde el archivo de texto al iniciar la aplicación
            CargarUsuariosDesdeArchivo();
        }

        public void RegistrarUsuario(string correo, string contraseña, string nombreUsuario)
        {
            try
            {
                // Verificar si el correo electrónico ya está en uso
                if (ExisteUsuario(correo))
                {
                    throw new ArgumentException("El correo electrónico ya está en uso.");
                }

                // Crear una instancia de Usuario con los datos proporcionados
                Usuario nuevoUsuario = new Usuario(nombreUsuario, correo, contraseña);

                // Agregar el nuevo usuario a la lista de usuarios
                listaUsuarios.Add(nuevoUsuario);

                // Guardar la lista actualizada de usuarios en el archivo de texto
                GuardarUsuariosEnArchivo();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private bool ExisteUsuario(string correo)
        {
            try
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.Email == correo)
                    {
                        return true; // El usuario ya existe
                    }
                }
                return false; // El usuario no existe
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Buscar si ya existe un usuario con el mismo correo electrónico en la lista de usuarios
            
        }

        private void CargarUsuariosDesdeArchivo()
        {
            try
            {
                if (File.Exists(rutaArchivoUsuarios))
                {
                    // Leer los usuarios desde el archivo de texto
                    string[] lineas = File.ReadAllLines(rutaArchivoUsuarios);
                    foreach (string linea in lineas)
                    {
                        string[] datosUsuario = linea.Split(';');
                        if (datosUsuario.Length == 3)
                        {
                            string nombreUsuario = datosUsuario[0];
                            string correo = datosUsuario[1];
                            string contraseña = datosUsuario[2];
                            listaUsuarios.Add(new Usuario(nombreUsuario, correo, contraseña));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Verificar si el archivo de usuarios existe
            
        }
        public Usuario IniciarSesion(string correo, string contraseña)
        {
            try
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.Email == correo && usuario.Password == contraseña)
                    {
                        return usuario; // Las credenciales son válidas, devolver el usuario
                    }
                }
                return null; // No se encontró ningún usuario con las credenciales proporcionadas
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // Buscar si existe un usuario con las credenciales proporcionadas
            
        }

        private void GuardarUsuariosEnArchivo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivoUsuarios))
                {
                    foreach (Usuario usuario in listaUsuarios)
                    {
                        writer.WriteLine($"{usuario.Username};{usuario.Email};{usuario.Password}");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            // Escribir los usuarios en el archivo de texto
            
        }
    }
}
