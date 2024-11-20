using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Modelo_de_datos
{
    public class InformacionAdicional
    {
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Medicamentos { get; set; }
        public string RequerimientoDeSala { get; set; }
        public string TipoDeSala { get; set; }

        public InformacionAdicional(string sintomas, string diagnostico, string medicamentos, string requerimientodesala, string tipodesala)
        {
            Sintomas = sintomas;
            Diagnostico = diagnostico;
            Medicamentos = medicamentos;
            RequerimientoDeSala = requerimientodesala;
            TipoDeSala = tipodesala;
        }

    }
}
