using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class Comida
    {
        public String nombre;
        public double precio;

        public Comida(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
