using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Ventas
    {
        public int IdentificadorProducto { get; set; }
        public String? NombreProducto { get; set; }
        public String? DescripcionProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

        
        public double DescuentoNuevo { get; set; }
    }
}