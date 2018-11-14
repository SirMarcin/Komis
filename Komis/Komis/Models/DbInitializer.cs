using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Samochody.Any())
            {
                context.AddRange(

                new Samochod { Cena = 12500, JestSamochodemTygodnia = false, Marka = "BMW", MiniaturkaUrl = "/images/e46.jpg", Moc = "150KM", Model = "E46", Opis = "Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "220000km", RodzajPaliwa = "Benzyna", RokProdukcji = 2002, ZdjecieUrl = "" },
                new Samochod { Cena = 7500, JestSamochodemTygodnia = true, Marka = "Ford", MiniaturkaUrl = "/images/mondeo.jpg", Moc = "110KM", Model = "Mondeo", Opis = "Żabojad płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "180000km", RodzajPaliwa = "Benzyna + Gaz", RokProdukcji = 1999, ZdjecieUrl = "" },
                new Samochod { Cena = 20000, JestSamochodemTygodnia = false, Marka = "Mercedes", MiniaturkaUrl = "/images/clk200.jpg", Moc = "205KM", Model = "CLK200", Opis = "Znowu Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "240000km", RodzajPaliwa = "Diesel", RokProdukcji = 2007, ZdjecieUrl = "" },
                new Samochod { Cena = 9000, JestSamochodemTygodnia = false, Marka = "Peugeot", MiniaturkaUrl = "/images/e46.jpg", Moc = "133KM", Model = "406", Opis = "Marzy mi się to autko", Pojemnosc = "2,0l", Przebieg = "220000km", RodzajPaliwa = "Benzyna+Gaz", RokProdukcji = 1999, ZdjecieUrl = "" },
                new Samochod { Cena = 1500, JestSamochodemTygodnia = false, Marka = "Ford", MiniaturkaUrl = "/images/mondeo.jpg", Moc = "110KM", Model = "Mondeo", Opis = "Żabojad płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "180000km", RodzajPaliwa = "Benzyna + Gaz", RokProdukcji = 1999, ZdjecieUrl = "" }

                    );
            }

            context.SaveChanges();
        }
    }
}
