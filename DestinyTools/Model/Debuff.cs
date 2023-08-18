namespace DestinyTools.Model
{
    internal class Debuff
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int percentage { get; set; }
        public bool Stackable { get; set; }
    }
}
