using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace SalesOnline.Domain.Entities
{
    public class Empleado : Person
    {
        [Key]
        public decimal sueldo { get; set; }
        public String? DepartamentoPertenece { get; set; }
        public String? Supervisor { get; set; }


    }
}
