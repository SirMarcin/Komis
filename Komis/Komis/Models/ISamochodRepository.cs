using System.Collections.Generic;

namespace Komis.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();

        Samochod PobierzSamochodId(int samochodId);
    }
}
