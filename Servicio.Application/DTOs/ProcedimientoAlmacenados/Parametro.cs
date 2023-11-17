using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs.ProcedimientoAlmacenados
{
    public class Parametro
    {
        public string Nombre { get; set; }
        public object? Valor { get; set; }
        public bool Input { get; set; }
        public int Tamanio { get; set; }

        public Parametro(string nombre, object valor, bool input = true, int tamanio = 0)
        {
            Nombre = nombre;
            Valor = valor;
            Input = input;
            Tamanio = tamanio;
        }
    }
}
