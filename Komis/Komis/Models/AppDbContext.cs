using Microsoft.EntityFrameworkCore;

namespace Komis.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            new Samochod { Id = 1, Cena = 12500, JestSamochodemTygodnia = false, Marka = "BMW", MiniaturkaUrl = "/images/e46.jpg", Moc = "150KM", Model = "E46", Opis = "Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "220000km", RodzajPaliwa = "Benzyna", RokProdukcji = 2002, ZdjecieUrl = "" },
            new Samochod { Id = 2, Cena = 7500, JestSamochodemTygodnia = true, Marka = "Ford", MiniaturkaUrl = "/images/mondeo.jpg", Moc = "110KM", Model = "Mondeo", Opis = "Żabojad płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "180000km", RodzajPaliwa = "Benzyna + Gaz", RokProdukcji = 1999, ZdjecieUrl = "" },
            new Samochod { Id = 3, Cena = 20000, JestSamochodemTygodnia = false, Marka = "Mercedes", MiniaturkaUrl = "/images/clk200.jpg", Moc = "205KM", Model = "CLK200", Opis = "Znowu Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "240000km", RodzajPaliwa = "Diesel", RokProdukcji = 2007, ZdjecieUrl = "" },
            new Samochod { Id = 4, Cena = 9000, JestSamochodemTygodnia = false, Marka = "Peugeot", MiniaturkaUrl = "/images/e46.jpg", Moc = "133KM", Model = "406", Opis = "Marzy mi się to autko", Pojemnosc = "2,0l", Przebieg = "220000km", RodzajPaliwa = "Benzyna+Gaz", RokProdukcji = "1999", ZdjecieUrl = "" },
            new Samochod { Id = 5, Cena = 1500, JestSamochodemTygodnia = false, Marka = "Ford", MiniaturkaUrl = "/images/mondeo.jpg", Moc = "110KM", Model = "Mondeo", Opis = "Żabojad płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "180000km", RodzajPaliwa = "Benzyna + Gaz", RokProdukcji = 1999, ZdjecieUrl = "" },
            new Samochod { Id = 6, Cena = 2500, JestSamochodemTygodnia = false, Marka = "Mercedes", MiniaturkaUrl = "/images/clk200.jpg", Moc = "205KM", Model = "CLK200", Opis = "Znowu Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "240000km", RodzajPaliwa = "Diesel", RokProdukcji = 2007, ZdjecieUrl = "" },
            new Samochod { Id = 7, Cena = 10000, JestSamochodemTygodnia = false, Marka = "BMW", MiniaturkaUrl = "/images/e46.jpg", Moc = "150KM", Model = "E46", Opis = "Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "220000km", RodzajPaliwa = "Benzyna", RokProdukcji = 2002, ZdjecieUrl = "" },
            new Samochod { Id = 8, Cena = 8999, JestSamochodemTygodnia = false, Marka = "Ford", MiniaturkaUrl = "/images/mondeo.jpg", Moc = "110KM", Model = "Mondeo", Opis = "Żabojad płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "180000km", RodzajPaliwa = "Benzyna + Gaz", RokProdukcji = 1999, ZdjecieUrl = "" },
            new Samochod { Id = 9, Cena = 15000, JestSamochodemTygodnia = false, Marka = "Mercedes", MiniaturkaUrl = "/images/clk200.jpg", Moc = "205KM", Model = "CLK200", Opis = "Znowu Niemiec płakał jak sprzedawał", Pojemnosc = "2,5l", Przebieg = "240000km", RodzajPaliwa = "Diesel", RokProdukcji = 2007, ZdjecieUrl = "" }
        };

        public DbSet<Samochod> Samochody { get; set; }
    }
}
