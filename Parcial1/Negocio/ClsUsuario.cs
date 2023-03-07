using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsUsuario
    {
        public bool Acceso(string Nombre, string Contraseña)
        {
            return Nombre == "Tunombre" && Contraseña == "123";
        }
    }

    public class ClsVenta
    {
        public void Cobro(Venta venta)
        {
            decimal total = venta.PrecioDProducto * venta.CantidadDProducto;

            if (total > 50)
            {
                total -= 10;
                Console.WriteLine($"Precio original: ${venta.PrecioDProducto * venta.CantidadDProducto}");
                Console.WriteLine($"Descuento que se aplico: $10");
                Console.WriteLine($"Total a cancelar: ${total}");
            }
            else
            {
                Console.WriteLine($"Total a pagar. ${total}");
            }
        }
    }
}