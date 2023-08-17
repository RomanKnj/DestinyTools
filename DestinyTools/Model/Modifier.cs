using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyTools.Model
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
