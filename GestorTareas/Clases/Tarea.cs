using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaGestorTareas.Clases
{
    internal class Tarea
    {
        private int tareaId;
        private string titulo;
        private string descripcion;
        private DateTime fechaVencimiento;
        private string prioridad;
        private string estado;
        private Usuario usuarioCreador; 

        public Tarea(string titulo, string descripcion,
            DateTime fechaVencimiento, string prioridad,
            string estado, Usuario usuarioCreador)
        {
            TareaId = GenerarIdAleatorio();
            Titulo = titulo;
            Descripcion = descripcion;
            FechaVenc = fechaVencimiento;
            Prioridad = prioridad;
            Estado = estado;
            UsuarioCreador = usuarioCreador;
        }

        public int TareaId { get => tareaId;
            private set => tareaId = value; }
        public string Titulo { get => titulo;
            set => titulo = value; }
        public string Descripcion { get => descripcion;
            set => descripcion = value; }
        public DateTime FechaVenc { get => fechaVencimiento;
            set => fechaVencimiento = value; }

        public string Prioridad
        {
            get => prioridad;
            set
            {
                if (value == "Baja" || value == "Media" || 
                    value == "Alta")
                    prioridad = value;
                else
                    throw new ArgumentException("El valor de" +
                        "prioridad no es válido.");
            }
        }

        public string Estado
        {
            get => estado;
            set
            {
                if (value == "Por Hacer" || 
                    value == "En Progreso" ||
                    value == "Terminado")
                    estado = value;
                else
                    throw new ArgumentException("El valor " +
                        "de estado no es válido.");
            }
        }

        public Usuario UsuarioCreador { get => usuarioCreador;
            set => usuarioCreador = value; }

        private int GenerarIdAleatorio()
        {
            Random random = new Random();
            return random.Next(1000, 10000); // Generar un ID aleatorio de 4 dígitos
        }
    }

}
