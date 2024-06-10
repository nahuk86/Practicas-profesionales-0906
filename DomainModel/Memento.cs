using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Memento
    {
        public int Salud { get; private set; }

        // Constructor con parámetro
        public Memento(int salud)
        {
            Salud = salud;
        }
    }
}
