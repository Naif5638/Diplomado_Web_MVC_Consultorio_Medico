using Diplomado_Web_MVC_Consultorio_Medico.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Diplomado_Web_MVC_Consultorio_Medico.Data
{
    public class ConsultorioDB : DbContext
    {
        public ConsultorioDB(): base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}