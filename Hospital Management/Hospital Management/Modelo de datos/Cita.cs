using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Modelo_de_datos
{
    [Serializable]
    public class Cita
    {
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Doctor { get; set; }
        public string Consultorio { get; set; }
        public string Motivo { get; set; }
        public string Comentarios { get; set; }

        public Cita(DateTime fecha, string hora, string doctor, string consultorio, string motivo, string comentarios)
        {
            Fecha = fecha;
            Hora = hora;
            Doctor = doctor;
            Consultorio = consultorio;
            Motivo = motivo;
            Comentarios = comentarios;

        }
    }
}
