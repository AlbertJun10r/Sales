using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace SalesOnline.Domain.Entities
{
    public class MenuRol : BaseEntity
    {
        [Key]
        public int idMenuRol { get; set; }
        public int idMenu { get; set; }
        public int idRol { get; set; }

    }
}
