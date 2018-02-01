using BusinessLayer;
using System;

namespace ThronesTournamentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThronesTournamentManager business = new ThronesTournamentManager();
            bool End = false;
            while (!End)
            {
                Console.WriteLine("que voulez vous faire ?");
                Console.WriteLine("1:afficher liste maisons");
                Console.WriteLine("2:afficher liste territoires");
                Console.WriteLine("3:afficher liste top persos");
                Console.WriteLine("4:afficher liste maisons avec + de 200 units");
                bool IsValid = false;
                int choix = -1;
                while (!IsValid)
                {
                    Console.WriteLine("Veuillez saisir votre choix");
                    string saisie = Console.ReadLine();
                    if (int.TryParse(saisie, out choix) && (choix>0) )
                        IsValid = true;
                    else
                    {
                        IsValid = false;
                        Console.WriteLine("Le choix que vous avez saisi est incorrect ...");
                    }
                }
                switch (choix)
                {
                    case 1:
                        business.DisplayHouses();
                        break;
                    case 2:
                        business.DisplayTerritory();
                        break;
                    case 3:
                        business.DisplayTopCharactere();
                        break;
                    case 4:
                        business.DisplayHouses200();
                        break;
                    default:
                        End = true;
                        break;
                }
            }
        }
    }
}
