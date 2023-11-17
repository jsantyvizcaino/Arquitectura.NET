using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public AppSettings()
        {
            ConnectionStrings = new ConnectionStrings();
        }
    }

    public class ConnectionStrings
    {
        /// <summary>
        /// CatalogoDb
        /// </summary>
        public string Default { get; set; }

        /// <summary>
        /// ConnectionStrings
        /// </summary>
        public ConnectionStrings()
        {
            Default = string.Empty;
        }
    }
}
