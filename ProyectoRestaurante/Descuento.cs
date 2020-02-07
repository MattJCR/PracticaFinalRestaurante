using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class Descuento
    {
        public String codigo;
        public int descuento;

        public Descuento(string codigo, int descuento)
        {
            this.codigo = codigo;
            this.descuento = descuento;
        }
    }
}
