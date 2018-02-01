namespace EntitiesLayer
{
    public class Territory : EntityObject
    {
        public Character Owner{ get; set; }

        public TerritoryTypeEnum TerritoryType { get; set; }

        public Territory(Character c, TerritoryTypeEnum t) {
            Owner = c;
            TerritoryType = t ;
        }
    }
}
