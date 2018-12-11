﻿using System.Collections.Generic;

namespace Komis.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();

        Samochod PobierzSamochodId(int samochodId);

        void DodajSamochod(Samochod samochod);

        void EdytujSamochod(Samochod samochod);

        void UsunSamochod(Samochod samochod);
    }
}
