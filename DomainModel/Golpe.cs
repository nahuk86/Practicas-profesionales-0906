using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Golpe
    {
        public string Nombre { get; set; } // Nombre descriptivo del golpe (por ejemplo, "Debil", "Intermedio", "Fuerte")
        public int Daño { get; set; } // Daño que causa el golpe

        // Constructor sin parámetros
        public Golpe() { }

        // Constructor con parámetros
        public Golpe(string nombre, int daño)
        {
            Nombre = nombre;
            Daño = daño;
        }
    }
}
