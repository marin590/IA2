using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA2
{
    class Punto
    {
        public Point coordenada;
        public int tipo;

        public Punto(Point coordenada, int tipo)
        {
            this.coordenada = coordenada;
            this.tipo = tipo;
        }
    }
}
