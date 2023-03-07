using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsVentas
    {
    
    
        public String Pago(Ventas ven)


        {
            double AplicarDesc = ven.PrecioProducto * ven.CantidadProducto;

            if (AplicarDesc > 50)
            {
                ven.DescuentoNuevo = AplicarDesc - 10;
                return $"Descuento de 10% su total es ${ven.DescuentoNuevo}";
            }
            else
            {
                return $"Lo sentimos mucho no aplica el descuento ya que no compra lo establecido no cumple el requisito para recibir descuento ${AplicarDesc}";
            }
        }
        
    }
}