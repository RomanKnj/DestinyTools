using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyTools.Model
{
    internal class Weapon
    {
        private string Name { get; set; } = string.Empty;
        private float magazine { get; set; }
        private float totalReserves { get; set; }
        private float roundsPerMinute { get; set; }
        private float dmgPerShot { get; set; }
        private float dmgPerHeadshot { get; set; }
        private float dmgModifier { get; set; }
        private float reloadTimeInSeconds { get; set; }
    }
}
