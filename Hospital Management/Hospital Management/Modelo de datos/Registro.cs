using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Modelo_de_datos
{
    public class Registro
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ncontacto { get; set; }
        public string Edad { get; set; }
        public string Genero { get; set; }
        public string Tiposangre { get; set; }
        public string Enfermedadanterior { get; set; }

        public Registro(string id, string nombre, string direccion, string ncontacto, string edad, string genero, string tiposangre, string enfermedadanterior)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Ncontacto = ncontacto;
            Edad = edad;
            Genero = genero;
            Tiposangre = tiposangre;
            Enfermedadanterior = enfermedadanterior;

        }
    }
}
