using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Player
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Velocidad { get; set; }
        public int Salud { get; set; }

        public Player() { }

        public Player(string nombre, int velocidad)
        {
            Nombre = nombre;
            Velocidad = velocidad;
            Salud = 100;
        }
    }

}
