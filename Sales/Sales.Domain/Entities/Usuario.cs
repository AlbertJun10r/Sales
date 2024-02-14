using Sales.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entitites
{
    public class Usuario : Person
    {
        [Key]
        public int idUsuario { get; set; }
        public String? nombre{ get; set; }
        public String? correo { get; set; }
        public int Telefono { get; set; }
        public int? idRol { get; set; }
        public String? urlFoto { get; set; }
        public String? nombreFoto { get; set; }
        public String? Clave { get; set; }
    }
}
