using System;
using System.Collections.Generic;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        public IList<Character> Housers { get; set; }
        public String Name { get; set; }
        public int NumberOfUnities { get; set; }

        public void AddHousers(Character c) {
            Housers.Add(c);
        }

        public House(String name ,int nb ) {
            Name = name;
            NumberOfUnities = nb;
        }
    }
}
