using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntitiesLayer;

namespace DataAccessLayer
{
    public interface IDAL
    {
        IList<House> GetHouses();
        IList<Territory> GetTerritory();
        IList<Character> GetCharactere(int id);
        IList<Character> GetAllCharactere();

    }
}