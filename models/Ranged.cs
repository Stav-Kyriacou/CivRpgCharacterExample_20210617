namespace CivRpgCharacterExample_20210617.models
{
    public class Ranged : Weapon
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public Ranged() : base("LongBow", 10, 35, 15, 20)
        {
            this.MinRange = 0;
            this.MaxRange = 100;
        }
        public Ranged(string name, int weight, int value, int damage, int maxDurability, int minRange, int maxRange) 
                    : base (name, weight, value, damage, maxDurability)
        {
            this.MinRange = minRange;
            this.MaxRange = maxRange;
        }
    }
}