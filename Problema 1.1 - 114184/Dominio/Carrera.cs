using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1___114184.Dominio
{
    internal class Carrera
    {
        public int Id_carrera { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public List<DetalleCarrera> Detalle { get; set; }
        public Carrera()
        {
            Detalle = new List<DetalleCarrera>();
        }
        public Carrera(int id_carrera,string nombre, List<DetalleCarrera> detalle)
        {
            Id_carrera = id_carrera;
            Nombre = nombre;
            Detalle = new List<DetalleCarrera>();
        }
        public void AgregarDetalle(DetalleCarrera detalle)
        {
            if (detalle != null)
                Detalle.Add(detalle); //System.NullReferenceException ERROR
        }
        public void QuitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
        public void LimpiarDetalle()
        {
            Detalle.Clear();
        }
        public override string ToString()
        {
            return Nombre + " |Titulo: " + Titulo;
        }
    }
}
