using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasAccessLayer
{
    public class DalManager : IDAL
    {
       
        public IList<Character> GetAllCharactere()
        {
            throw new NotImplementedException();
        }

        public IList<Character> GetCharactere(int id)
        {
            throw new NotImplementedException();
        }

        public IList<House> GetHouses()
        {
            throw new NotImplementedException();
        }

        public IList<Territory> GetTerritory()
        {
            throw new NotImplementedException();
        }
    }
}
