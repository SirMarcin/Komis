using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis.Models
{
    public class MockSamochodRepository : ISamochodRepository
    {
        private List<Samochod> samochody;

        public MockSamochodRepository()
        {
            if(samochody == null)
            {
                ZaladujSamochody();
            }
        }

        private void ZaladujSamochody()
        {
            samochody = new List<Samochod>
            {
                new Samochod {Id=1, Cena=12500, JestSamochodemTygodnia=false, Marka="BMW", MiniaturkaUrl="", Moc= "150KM", Model="E46", Opis="Niemiec płakał jak sprzedawał", Pojemnosc="2,5l", Przebieg="220000km", RodzajPaliwa="Benzyna", RokProdukcji=2002, ZdjecieUrl=""  },
                new Samochod {Id=2, Cena=7500, JestSamochodemTygodnia=true, Marka="Ford", MiniaturkaUrl="", Moc= "110KM", Model="Mondeo", Opis="Żabojad płakał jak sprzedawał", Pojemnosc="2,5l", Przebieg="180000km", RodzajPaliwa="Benzyna + Gaz", RokProdukcji=1999, ZdjecieUrl=""  },
                new Samochod {Id=3, Cena=20000, JestSamochodemTygodnia=false, Marka="Mercedes", MiniaturkaUrl="", Moc= "205KM", Model="CLK200", Opis="Znowu Niemiec płakał jak sprzedawał", Pojemnosc="2,5l", Przebieg="240000km", RodzajPaliwa="Diesel", RokProdukcji=2007, ZdjecieUrl=""  }

            };
        }

        public Samochod PobierzSamochodId(int samochodId)
        {
            return samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return samochody;
        }
    }
}
