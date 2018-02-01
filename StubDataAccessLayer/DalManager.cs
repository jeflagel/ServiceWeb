using EntitiesLayer;
using System.Collections.Generic;

namespace StubDataAccessLayer
{
    public class DalManager 
    {
        public IList<House> GetHouses(){
            House Lannister = new House("Lannister", 5000);
            House Stark = new House("Stark", 3000);
            House Baratheon = new House("Baratheon", 2000);
            House Tyrell = new House("Tyrell", 1000);
            House Martell = new House("Martell", 500);
            House Tully = new House("Tully", 100);
            House Arryn = new House("Arryn", 200);
            House Greyjoy = new House("Greyjoy", 400);
            House Bolton = new House("Bolton", 2000);
            House Clegane = new House("Clegane", 20);
            House Targaryen = new House("Targaryen", 8000);
            IList<House> Liste= new List<House>();
            Liste.Add(Lannister);
            Liste.Add(Stark);
            Liste.Add(Baratheon);
            Liste.Add(Tyrell);
            Liste.Add(Martell);
            Liste.Add(Tully);
            Liste.Add(Arryn);
            Liste.Add(Greyjoy);
            Liste.Add(Bolton);
            Liste.Add(Clegane);
            Liste.Add(Targaryen);

            return Liste;

        }
        public IList<House> GetHouses200()
        {
            IList<House> ListeGrande = new List<House>();
            foreach(House i in GetHouses())
            {
                if (i.NumberOfUnities > 200)
                {
                    ListeGrande.Add(i);
                }
            }
            return ListeGrande; 
        }

        public IList<Territory> GetTerritory()
        {
            Character John = new Character(90, 50, "John", "Snow", 100);
            Territory North = new Territory(John, TerritoryTypeEnum.MOUNTAIN);
            Character Cersei = new Character(40, 80, "Cersei", "Lannister", 100);
            Territory South = new Territory(Cersei, TerritoryTypeEnum.LAND);
            Character Daenerys = new Character(90, 60, "Daenerys", "Targaryen", 100);
            Territory Westeros = new Territory(Daenerys, TerritoryTypeEnum.DESERT);
            IList<Territory> Liste = new List<Territory>();
            Liste.Add(North);
            Liste.Add(South);
            Liste.Add(Westeros);
            return Liste;
        }

        public IList<Character> GetCharactere()
        {
            Character John = new Character(90, 50, "John", "Snow", 100);
            Character Cersei = new Character(40, 80, "Cersei", "Lannister", 100);
            Character Daenerys = new Character(90, 60, "Daenerys", "Targaryen", 100);
            IList<Character> Liste = new List<Character>();
            Liste.Add(John);
            Liste.Add(Cersei);
            Liste.Add(Daenerys);
            return Liste;
        }

        public IDictionary<Character, IList<int>> GetProperties()
        {
            Character John = new Character(90, 50, "John", "Snow", 100);
            Character Cersei = new Character(40, 80, "Cersei", "Lannister", 100);
            Character Daenerys = new Character(90, 60, "Daenerys", "Targaryen", 100);
            IDictionary<Character,IList<int>> DICT = new Dictionary<Character,IList<int>>();
            IList<int> LJ = new List<int>
            {
                John.Bravoury,
                John.PV,
                John.Crazyness
            };
            DICT.Add(John,LJ);
            IList<int> LC = new List<int>
            {
                Cersei.Bravoury,
                Cersei.PV,
                Cersei.Crazyness
            };
            DICT.Add(Cersei, LC);
            IList<int> LD = new List<int>
            {
                Daenerys.Bravoury,
                Daenerys.PV,
                Daenerys.Crazyness
            };
            DICT.Add(Daenerys, LD);
            return DICT;
        }
    }
}
