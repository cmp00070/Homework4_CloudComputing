namespace Homework4_CloudComputing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ContactoId = c.Int(nullable: false, identity: true),
                        NIF = c.String(),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Email = c.String(),
                        Telefono = c.Int(nullable: false),
                        Direccion = c.String(),
                        CodPostal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contactoes");
        }
    }
}
