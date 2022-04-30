using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Homework4_CloudComputing.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int CodPostal { get; set; }


    }
}