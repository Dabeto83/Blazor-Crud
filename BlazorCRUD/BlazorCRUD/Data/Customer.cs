using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Wrong Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telephone is mandatory")]
        public string Telefono { get; set; }

        public DateTime FechaAlta { get; set; }
    }
}
