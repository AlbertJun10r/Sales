using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace SalesOnline.Domain.Entities
{
    public class Menu : BaseEntity
    {
        [Key]
        public int idMenu { get; set; }
        public String? descripcion { get; set; }
        public int idMenuPadre { get; set; }
        public String icono { get; set; }
        public String? controlador { get; set; }
        public String? paginaAccion { get; set; }
    }
}
