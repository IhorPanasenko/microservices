﻿using PlatformServices.Models;

namespace PlatformServices.Data
{
    public static class PrepDb
    {

        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData (AppDbContext context)
        {
            if (!context.Platfroms.Any())
            {
                Console.WriteLine("--> Seeding data...");

                context.Platfroms.AddRange(
                    new Platform() { Name = "Dot net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publisher ="Microsoft", Cost = "Free"},
                    new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free"}
                    );

                context.SaveChanges();

            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }

    }
}
