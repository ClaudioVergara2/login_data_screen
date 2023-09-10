using System.Data;

namespace Evaluacion1.Models
{
    public class Datos
    {
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string? correo { get; set; }

        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Now;
                int edad = hoy.Year - fechaNacimiento.Year;
                if (hoy.Month < fechaNacimiento.Month || (hoy.Month == fechaNacimiento.Month && hoy.Day < fechaNacimiento.Day))
                {
                    edad--;
                }
                return edad;
            }
        }
    }
}
