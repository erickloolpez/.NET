using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DTO
{
    public class DTOAwita
    {
        public string id { get; set; }
        public string cuenta_id { get; set; }
        public decimal monto { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
