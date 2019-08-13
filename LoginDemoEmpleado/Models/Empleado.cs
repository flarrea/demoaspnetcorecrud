using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemoEmpleado.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        public string Rut { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string Profesion { get; set; }

        public int Experiencia { get; set; }
    }
}
