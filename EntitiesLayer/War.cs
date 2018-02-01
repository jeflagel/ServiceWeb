using System.Collections.Generic;

namespace EntitiesLayer
{
    public class War : EntityObject
    {
        public string WarName { get; set; }
        public IList<Fight> FightList { get; set; }

    }
}
