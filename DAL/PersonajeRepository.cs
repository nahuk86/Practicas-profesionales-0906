using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DAL
{
    public class PersonajeRepository
    {
        // Método ficticio para obtener personajes (simula la obtención de datos)
        public List<Player> ObtenerPersonajes()
        {
            return new List<Player>
            {
                new Player("Jugador1", 8),
                new Player("Jugador2", 7)
            };
        }
    }
}
