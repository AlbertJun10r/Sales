using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace SalesOnline.Domain.Entities
{
    public class Rol : BaseEntity
    {
        [Key]
        public int idRol { get; set; }
        public String? descripcion { get; set; }


    }
}
