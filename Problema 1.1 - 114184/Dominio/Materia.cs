using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1___114184.Dominio
{
    internal class Materia
    {
        public int Id_materia { get; set; }
        public string Nombre { get; set; }
        public Materia()
        {
            Id_materia = 0;
            Nombre = "";
        }
        public Materia(int id,string nombre)
        {
            Id_materia = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
