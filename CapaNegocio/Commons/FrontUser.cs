using CapaDatos;
using CapaNegocio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Commons
{
    public class FrontUser
    {
        public static USUARIO Get()
        {
            return new USUARIO().Obtener(SessionHelper.GetUser());
        }
    }
}
