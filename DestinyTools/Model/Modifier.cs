﻿namespace DestinyTools.Model
{
    internal class Modifier
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int percentage { get; set; }
        public bool Stackable { get; set; }
        public bool isBuff { get; set; }
    }
}
