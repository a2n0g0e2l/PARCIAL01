using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsVentas
    {
    
    
        public String Cobro(Ventas ven)


        {
            double AplicarDesc = ven.PrecioProducto * ven.CantidadProducto;

            if (AplicarDesc > 50)
            {
                ven.DescuentoNuevo = AplicarDesc - 10;
                return $"Descuento de 10% su total es ${ven.DescuentoNuevo}";
            }
            else
            {
                return $"Lo sentimos mucho no aplica el descuento ya que no compra no cumple el requisito a pagar ${AplicarDesc}";
            }
        }
        
    }
}