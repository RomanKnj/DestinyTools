using System.Collections.ObjectModel;
using System.Dynamic;

namespace DestinyTools.Model
{
    internal class Guardian
    {
        public string Name { get; set; } = string.Empty;
        public Class Class { get; set; } = new Class();
        public ObservableCollection<Weapon> Weapons { get; set; } = new ObservableCollection<Weapon>();
        public ObservableCollection<Mod> Mods { get; set; } = new ObservableCollection<Mod>();
    }
}
