using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsUsuario
    {

      public bool Acreditacion(Usuario user)

        {
            if (user.Nombre.Equals("TUNOMBRE") && user.Contraseña.Equals("123"))
            {
                return true;
            }
            return false;
        } 
    }
}