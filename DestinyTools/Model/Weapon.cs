namespace DestinyTools.Model
{
    internal class Weapon
    {
        public string Name { get; set; } = string.Empty;
        public string Perk1 { get; set; } = string.Empty;
        public string Perk2 { get; set; } = string.Empty;
        public string Perk3 { get; set; } = string.Empty;
        public string Perk4 { get; set; } = string.Empty;
        public int Slot { get; set; }
        public int Rarity { get; set; }

        //private float magazine { get; set; }
        //private float totalReserves { get; set; }
        //private float roundsPerMinute { get; set; }
        //private float dmgPerShot { get; set; }
        //private float dmgPerHeadshot { get; set; }
        //private float dmgModifier { get; set; }
        //private float reloadTimeInSeconds { get; set; }
    }
}
