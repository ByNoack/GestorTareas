using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaGestorTareas.Clases
{
    internal class GestorTareas
    {

        private List<Tarea> tareas; // Lista de tareas gestionadas por el gestor

        // Eventos para notificar cambios en las tareas
        public event EventHandler<TareaEventArgs> TareaCreada;
        public event EventHandler<TareaEventArgs> TareaActualizada;
        public event EventHandler<TareaEventArgs> TareaEliminada;

        public GestorTareas()
        {
            tareas = new List<Tarea>();
        }

        // Método para agregar una nueva tarea al gestor
        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
            TareaCreada?.Invoke(this, new TareaEventArgs(tarea));

        }

        // Método para eliminar una tarea del gestor
        public void EliminarTarea(Tarea tarea)
        {
            tareas.Remove(tarea);
            TareaEliminada?.Invoke(this, new TareaEventArgs(tarea));
        }

        // Método para actualizar una tarea en el gestor
        public void ActualizarTarea(Tarea tareaActualizada)
        {
          Tarea tarea = tareas.FirstOrDefault(t => t.Titulo == tareaActualizada.Titulo);
            if (tarea != null)
            {
                tarea.Descripcion = tareaActualizada.Descripcion;
                tarea.FechaVencimiento = tareaActualizada.FechaVencimiento;
                tarea.Prioridad = tareaActualizada.Prioridad;
                tarea.Estado = tareaActualizada.Estado;
                TareaActualizada?.Invoke(this, new TareaEventArgs(tarea));

            }
            else
            {
                throw new ArgumentException("La tarea especificada no existe.");
            }
        }

        // Método para buscar tareas según un criterio (palabra del título)
        public List<Tarea> BuscarTareas(string criterio)
        {
            return tareas.Where(t => t.Titulo.Contains(criterio)).ToList();
        }

        // Método para ordenar las tareas según un método de ordenamiento
        public void OrdenarTareas(string metodoOrdenamiento)
        {
            switch (metodoOrdenamiento)
            {
                case "PorTitulo":
                    tareas = tareas.OrderBy(t => t.Titulo).ToList(); 
                    break;
                case "PorPrioridad":
                    tareas = tareas.OrderBy(t => t.Prioridad).ToList();
                    break;
                case "PorFechaVencimiento":
                    tareas = tareas.OrderBy(t => t.FechaVenc).ToList();
                    break;
                case "PorEstado":
                    tareas = tareas.OrderBy(t => t.Estado).ToList(); 
                    break;
                default:
                    throw new ArgumentException("Método de " +
                        "ordenamiento no válido.");
            }
        }

    }
}
