using System;
using System.Collections.Generic;

namespace EntitiesLayer
{
    public class Character : EntityObject
    {
        public int Bravoury { get; set; }
        public int Crazyness { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PV { get; set; }
        public IDictionary<Character, RelationshipEnum> Relationships { get; set; }

        public void AddRelatives(Character c , RelationshipEnum rel) {
            Relationships.Add(c, rel);
        }

        public Character( int Brav, int Crazy, String Name, String surname, int Pvs) {
            Bravoury = Brav;
            Crazyness = Crazy;
            FirstName = Name;
            LastName = surname;
            PV = Pvs; 
        }
        override public String ToString (){
            return "My name is "+FirstName+" "+LastName+" and I have "+PV+" PV"; 
        }
    }
}
