using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ForestIA
{
    public class Person
    {
        private Point coordenadas;
        private bool objetivo;

        public Person()
        {
            objetivo = false;
        }

        public void ubicar(Point coordenada)
        {
            coordenadas = coordenada;
        }

        public Point posicion()
        {
            return coordenadas;
        }

        public bool tieneElObjectivo()
        {
            return objetivo;
        }

        public void mover(Point siguienteMovimiento, ref int[,] mapa)
        {
            if (mapa[siguienteMovimiento.X, siguienteMovimiento.Y].Equals(0))
            {
                mapa[siguienteMovimiento.X, siguienteMovimiento.Y] = 2;
                mapa[coordenadas.X, coordenadas.Y] = 0;
                coordenadas = siguienteMovimiento;

            }
            else if (mapa[siguienteMovimiento.X, siguienteMovimiento.Y].Equals(3))
                objetivo = true;
        }
    }
}
