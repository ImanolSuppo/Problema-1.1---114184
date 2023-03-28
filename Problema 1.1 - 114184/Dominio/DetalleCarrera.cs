using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1___114184.Dominio
{
    internal class DetalleCarrera
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Materia Materia { get; set; }

        public DetalleCarrera()
        {
            AnioCursado = 0;
            Cuatrimestre = 0;
            Materia = new Materia();
        }
        public DetalleCarrera(int anioCursado, int cuatrimestre, Materia materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }
        public override string ToString()
        {
            return Materia.Nombre + " | Cuatrimestre: " + Cuatrimestre + " | Año: " + AnioCursado;
        }
    }
}
