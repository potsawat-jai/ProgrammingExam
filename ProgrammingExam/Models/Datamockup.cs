using ProgrammingExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammingExam.Models
{
    public class Datamockup
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                // Look for any board games.
                if (context.Myhero.Any())
                {
                    return;   // Data was already seeded
                }

                context.Myhero.AddRange(
                    new Myheroes
                    {
                        id = 11,
                        name = "Dr Nice",
                    },
                    new Myheroes
                    {
                        id = 12,
                        name = "Necromancer",
                    },
                    new Myheroes
                    {
                        id = 13,
                        name = "Bombasto",
                    },
                    new Myheroes
                    {
                        id = 14,
                        name = "Celeritas",
                    },
                    new Myheroes
                    {
                        id = 15,
                        name = "Magneta",
                    },
                    new Myheroes
                    {
                        id = 16,
                        name = "RubberMan",
                    },
                    new Myheroes
                    {
                        id = 17,
                        name = "Dynama",
                    },
                    new Myheroes
                    {
                        id = 18,
                        name = "Dr IQ",
                    },
                    new Myheroes
                    {
                        id = 19,
                        name = "Magma",
                    },
                    new Myheroes
                    {
                        id = 20,
                        name = "Tornado",
                    });
                context.SaveChanges();
            }
        }
    }
}
