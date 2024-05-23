using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorTareas.Clases
{
    internal class TareaEventArgs
    {
        public Tarea Tarea { get; }

        public TareaEventArgs(Tarea tarea)
        {
            Tarea = tarea;
        }

    }
}
