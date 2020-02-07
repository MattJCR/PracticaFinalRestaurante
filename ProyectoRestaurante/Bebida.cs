using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class Bebida
    {
        public String nombre;
        public double precio;

        public Bebida(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
