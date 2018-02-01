using System.Collections.Generic;
using System.Linq;
using DatasAccessLayer;
using EntitiesLayer;
namespace BusinessLayer
{
    public class ThronesTournamentManager
    {
        DalManager dal = new DalManager();

        public void DisplayHouses()
        {
            IList<House> Liste = dal.GetHouses();
            foreach (House element in Liste)
            {
                System.Console.WriteLine("la maison : {0} possède {1} unités",element.Name, element.NumberOfUnities);
            }
            System.Console.WriteLine();
        }

        public void DisplayHouses200()
        {
            IList<House> Liste = dal.GetHouses200();
            foreach (House element in Liste)
            {
                System.Console.WriteLine("la maison : {0} possède {1} unités", element.Name, element.NumberOfUnities);
            }
            System.Console.WriteLine();
        }

        public void DisplayTopCharactere()
        {
            IList<Character> Liste = dal.GetCharactere();
            IList<Character> TopListe = (from el in Liste where el.Bravoury > 3 where el.PV > 50 select el).ToList();
            foreach (Character element in TopListe)
            {
                System.Console.WriteLine("le perso : {0} possède {1} pts de force(bravoury) et {2} PV", element.FirstName, element.Bravoury,element.PV);
            }
            System.Console.WriteLine();
        }

        public void DisplayTerritory()
        {
            IList<Territory> Liste = dal.GetTerritory();
            foreach (Territory element in Liste)
            {
                System.Console.WriteLine("le terrain : {0} appartient à {1} ", element.TerritoryType, element.Owner);
            }
            System.Console.WriteLine();
        }
    }
}
