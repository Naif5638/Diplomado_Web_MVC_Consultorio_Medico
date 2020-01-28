namespace Diplomado_Web_MVC_Consultorio_Medico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsultorioDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Identificacion = c.String(),
                        Telefono = c.String(),
                        Celular = c.String(),
                        Direccion = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PacienteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pacientes");
        }
    }
}
