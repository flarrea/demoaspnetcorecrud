using LoginDemoEmpleado.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemoEmpleado.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Busca algún empleado.
                if (context.Empleado.Any())
                {
                    return;   // La DB ha sido poblada
                }

                context.Empleado.AddRange(
                    new Empleado
                    {
                        Rut = "111111111-1",
                        FirstName = "Pedro",
                        LastName = "López",
                        Genero = "M",
                        FechaNacimiento = DateTime.Parse("1984-3-13"),
                        Profesion = "Ingeniero",
                        Experiencia = 5
                    },

                    new Empleado
                    {
                        Rut = "222222222-2",
                        FirstName = "Ana",
                        LastName = "Jara",
                        Genero = "F",
                        FechaNacimiento = DateTime.Parse("1988-4-10"),
                        Profesion = "Sicólogo",
                        Experiencia = 3
                    },

                    new Empleado
                    {
                        Rut = "333333333-3",
                        FirstName = "Diego",
                        LastName = "Salas",
                        Genero = "M",
                        FechaNacimiento = DateTime.Parse("1980-1-3"),
                        Profesion = "Ingeniero",
                        Experiencia = 12
                    },

                    new Empleado
                    {
                        Rut = "444444444-4",
                        FirstName = "Laura",
                        LastName = "Abásolo",
                        Genero = "F",
                        FechaNacimiento = DateTime.Parse("1989-10-11"),
                        Profesion = "Arquitecto",
                        Experiencia = 7
                    }
                );
                context.SaveChanges();
            }
        }

    }
}

