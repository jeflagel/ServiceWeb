namespace EntitiesLayer
{
    public class Fight : EntityObject
    {
        public House HouseChallenging1 { get; set; }
        public House HouseChallenging2 { get; set; }

        public House Winning { get; set; }
    }
}
