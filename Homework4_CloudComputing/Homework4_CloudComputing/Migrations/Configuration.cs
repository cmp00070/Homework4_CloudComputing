namespace Homework4_CloudComputing.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Homework4_CloudComputing.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Homework4_CloudComputing.Data.Homework4_CloudComputingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Homework4_CloudComputing.Data.Homework4_CloudComputingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Contactoes.AddOrUpdate(p => p.Nombre,
                new Contacto
                {
                    NIF = "3097888G",
                    Nombre = "Juan",
                    Apellidos = "Rodriguez Galisteo",
                    Email = "juanrodriguez@gmail.com",
                    Telefono = 665259825,
                    Direccion = "Bulevar Carol I 8",
                    CodPostal = 700502


                },

                new Contacto
                {
                    NIF = "25110335Q",
                    Nombre = "Matilde",
                    Apellidos = "Real Rivas",
                    Email = "matildereal@gmail.com",
                    Telefono = 756216068,
                    Direccion = "CARRERA DE ESPAÑA, 65",
                    CodPostal = 28626


                },

                new Contacto
                {
                    NIF = "05895753W",
                    Nombre = "Cristobal",
                    Apellidos = "Rojo Macias",
                    Email = "cristobalrojo@gmail.com",
                    Telefono = 615400259,
                    Direccion = "PASSEIG REAL, 40",
                    CodPostal = 40013


                }

                );
        }
    }
}
