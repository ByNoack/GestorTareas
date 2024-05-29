using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareas.Clases
{
    internal class ControladorTareas
    {

        private List<Tarea> tareas; // Lista de tareas gestionadas por el gestor
        private string rutaArchivoTareas = "tareas.txt";

        // Eventos para notificar cambios en las tareas
        public event EventHandler<TareaEventArgs> TareaCreada;
        public event EventHandler<TareaEventArgs> TareaActualizada;
        public event EventHandler<TareaEventArgs> TareaEliminada;

        public ControladorTareas()
        {
            tareas = new List<Tarea>();
            CargarTareasDesdeArchivo();
        }

        // Método para agregar una nueva tarea al controlador
        public void AgregarTarea(Tarea tarea)
        {
            try
            {
                tareas.Add(tarea);
                TareaCreada?.Invoke(this, new TareaEventArgs(tarea));
                GuardarTareasEnArchivo();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        // Método para eliminar una tarea del controlador
        public void EliminarTarea(Tarea tarea)
        {
            try
            {
                tareas.Remove(tarea);
                TareaEliminada?.Invoke(this, new TareaEventArgs(tarea));
                GuardarTareasEnArchivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para actualizar una tarea en el gestor
        public void ActualizarTarea(Tarea tareaAnterior, Tarea tareaActualizada)
        {
            try {
                Tarea tarea = tareas.FirstOrDefault(t => t.Titulo == tareaAnterior.Titulo);
                if (tarea != null)
                {
                    tarea.Titulo = tareaActualizada.Titulo;
                    tarea.Descripcion = tareaActualizada.Descripcion;
                    tarea.FechaVenc = tareaActualizada.FechaVenc;
                    tarea.Prioridad = tareaActualizada.Prioridad;
                    tarea.Estado = tareaActualizada.Estado;
                    TareaActualizada?.Invoke(this, new TareaEventArgs(tarea));
                    GuardarTareasEnArchivo();

                }
                else
                {
                    throw new ArgumentException("La tarea especificada no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Método para buscar tareas según un criterio (palabra del título)
        public List<Tarea> BuscarTareas(string criterio, string usuario)
        {
            try
            {
                return tareas.Where(t => t.Titulo.Contains(criterio) && t.UsuarioCreador == usuario).ToList();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        // Método para ordenar las tareas según un método de ordenamiento
        public void OrdenarTareas(string metodoOrdenamiento)
        {
            try
            {
                switch (metodoOrdenamiento)
                {
                    case "Por título":
                        tareas = tareas.OrderBy(t => t.Titulo).ToList();
                        break;
                    case "Por prioridad":
                        tareas = tareas.OrderBy(t => t.Prioridad).ToList();
                        break;
                    case "Por fecha de vencimiento":
                        tareas = tareas.OrderBy(t => t.FechaVenc).ToList();
                        break;
                    case "Por estado":
                        tareas = tareas.OrderBy(t => t.Estado).ToList();
                        break;
                    default:
                        throw new ArgumentException("Método de " +
                            "ordenamiento no válido.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public List<Tarea> ObtenerTareasPorUsuario(string usuario)
        {
            try
            {
                return tareas.Where(t => t.UsuarioCreador == usuario).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        private void CargarTareasDesdeArchivo()
        {
            try
            {
                if (File.Exists(rutaArchivoTareas))
                {
                    string[] lineas = File.ReadAllLines(rutaArchivoTareas);
                    foreach (string linea in lineas)
                    {
                        string[] datosTarea = linea.Split(';');
                        if (datosTarea.Length == 6)
                        {
                            string titulo = datosTarea[0];
                            string descripcion = datosTarea[1];
                            DateTime fechaVenc = DateTime.Parse(datosTarea[2]);
                            string prioridad = datosTarea[3];
                            string estado = datosTarea[4];
                            string usuario = datosTarea[5];
                            tareas.Add(new Tarea(titulo, descripcion, fechaVenc, prioridad, estado, usuario));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Método para guardar las tareas en el archivo de texto
        private void GuardarTareasEnArchivo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivoTareas))
                {
                    foreach (Tarea tarea in tareas)
                    {
                        writer.WriteLine($"{tarea.Titulo};{tarea.Descripcion};{tarea.FechaVenc};{tarea.Prioridad};{tarea.Estado};{tarea.UsuarioCreador}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }


}
