using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Usuario
    {
        public string? Nombre {get;set;}
        public string? Contraseña {get;set;} 
    }


    public class Venta
    {
        public int IdentificacionDProducto {get;set;}
        public string? NombreDProducto {get;set;}
        public string? DescripcionDProducto {get;set;}
        public decimal PrecioDProducto {get;set;}
        public int CantidadDProducto {get;set;}
    }
}