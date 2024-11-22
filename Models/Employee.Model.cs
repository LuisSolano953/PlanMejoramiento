using System.ComponentModel.DataAnnotations;

namespace PlanMejoramiento.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id_Employee { get; set; }
        public string Nombre_Employee { get; set; }
        public string Apellido_Employee { get; set; }
        public string Cargo_Employee { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

    }
}
