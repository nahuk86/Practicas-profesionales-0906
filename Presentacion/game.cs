using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DomainModel;

namespace Presentacion
{
    public partial class game : Form
    {

        private Player _jugador1;
        private Player _jugador2;
        private PersonajeService _personajeService;

        public game()
        {
            InitializeComponent();
            _personajeService = new PersonajeService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {
            _jugador1 = new Player("Jugador1", 8) { Id = 1 };
            _jugador2 = new Player("Jugador2", 7) { Id = 2 };

            _personajeService.IniciarPersonaje(_jugador1);
            _personajeService.IniciarPersonaje(_jugador2);

            ActualizarSalud();
        }

        private void ActualizarSalud()
        {
            label1.Text = _jugador1.Salud.ToString();
            label4.Text = _jugador2.Salud.ToString();
        }

        private void p1_low_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador1, _jugador2, TipoGolpe.Debil);
            ActualizarSalud();
        }

        private void p1_high_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador1, _jugador2, TipoGolpe.Fuerte);
            ActualizarSalud();
        }

        private void p1_medium_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador1, _jugador2, TipoGolpe.Intermedio);
            ActualizarSalud();
        }

        private void p2_low_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador2, _jugador1, TipoGolpe.Debil);
            ActualizarSalud();
        }

        private void p2_medium_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador2, _jugador1, TipoGolpe.Intermedio);
            ActualizarSalud();
        }

        private void p2_high_Click(object sender, EventArgs e)
        {
            _personajeService.Golpear(_jugador2, _jugador1, TipoGolpe.Fuerte);
            ActualizarSalud();
        }
    }
}
