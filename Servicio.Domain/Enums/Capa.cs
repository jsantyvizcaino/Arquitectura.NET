using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Domain.Enums
{
    public enum Capa : short
    {
        Dominio = 100,
        Aplicacion = 200,
        Infraestructura = 300,
        API = 400,
        UI = 500
    }
}
