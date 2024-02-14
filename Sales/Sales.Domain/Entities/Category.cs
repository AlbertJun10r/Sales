
using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace SalesOnline.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Key]
        public int idCategoria { get; set; }
        public String? descripcion { get; set; }
        public List<Producto> productos { get; set; }


    }
}
