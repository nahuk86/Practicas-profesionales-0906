using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace BLL
{
    public class PersonajeService
    {
        private readonly Dictionary<int, int> _golpesSeguidos;
        private readonly Dictionary<int, Stack<Memento>> _historialSalud;

        public PersonajeService()
        {
            _golpesSeguidos = new Dictionary<int, int>();
            _historialSalud = new Dictionary<int, Stack<Memento>>();
        }

        public void IniciarPersonaje(Player personaje)
        {
            if (!_golpesSeguidos.ContainsKey(personaje.Id))
            {
                _golpesSeguidos[personaje.Id] = 0;
            }

            if (!_historialSalud.ContainsKey(personaje.Id))
            {
                _historialSalud[personaje.Id] = new Stack<Memento>();
            }

            GuardarEstado(personaje);
        }

        public void RecibirGolpe(Player personaje, TipoGolpe tipo)
        {
            int daño = (int)tipo;
            personaje.Salud -= daño;
            if (personaje.Salud < 0) personaje.Salud = 0;

            // Si el personaje recibe un golpe, resetear el contador de golpes seguidos
            _golpesSeguidos[personaje.Id] = 0;

            GuardarEstado(personaje);
        }
        public void Golpear(Player atacante, Player defensor, TipoGolpe tipo)
        {
            RecibirGolpe(defensor, tipo);
           
            if (!_golpesSeguidos.ContainsKey(atacante.Id))
            {
                _golpesSeguidos[atacante.Id] = 0;
            }

            _golpesSeguidos[atacante.Id]++;

            if (_golpesSeguidos[atacante.Id] >= 5)
            {
                RestaurarSalud(atacante);
                _golpesSeguidos[atacante.Id] = 0;
            }
        }

        private void GuardarEstado(Player personaje)
        {
            if (!_historialSalud.ContainsKey(personaje.Id))
            {
                _historialSalud[personaje.Id] = new Stack<Memento>();
            }

            _historialSalud[personaje.Id].Push(new Memento(personaje.Salud));
        }

        public void RestaurarSalud(Player personaje)
        {
            if (_historialSalud.ContainsKey(personaje.Id) && _historialSalud[personaje.Id].Count > 1)
            {
                _historialSalud[personaje.Id].Pop(); // Remover el estado actual
                personaje.Salud = _historialSalud[personaje.Id].Peek().Salud; // Restaurar al estado anterior
            }
        }
    }
}
