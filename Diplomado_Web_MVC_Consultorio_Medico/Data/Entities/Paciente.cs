using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_Web_MVC_Consultorio_Medico.Data.Entities
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}