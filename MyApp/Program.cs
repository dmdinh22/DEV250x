using System;
using MyApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new sakilaContext();
            var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            foreach (var record in records) {
                System.Console.WriteLine($"Film: {record.Title}");
                var counter = 1;
                foreach (var fa in record.FilmActor) {
                    System.Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
                }
            }

            var city = new City() { CityId = 1001, City1 = "Redmond", CountryId = 103 };
            dbContext.Add(city);
            dbContext.SaveChanges();

            
        }
    }
}
