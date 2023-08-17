using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinyTools.Model
{
    internal class Class
    {
        public string Name { get; set; } = string.Empty;
        public ObservableCollection<Subclass> subclasses { get; set; } = new ObservableCollection<Subclass>();
    }
}
