using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DestinyTools.Model;

namespace DestinyTools.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<Weapon> weapons { get; set; } = new ObservableCollection<Weapon>();
        public ObservableCollection<Modifier> modifiers { get; set; } = new ObservableCollection<Modifier>();
        public ObservableCollection<Class> classes { get; set; } = new ObservableCollection<Class>();

        public MainViewModel()
        {
            fillClasses();
        }

        private void fillClasses()
        {
            ObservableCollection<Subclass> sc1 = new ObservableCollection<Subclass>() { new Subclass { Name = "Solar" }, new Subclass { Name = "Void" }, new Subclass { Name = "Arc" } };
            Class c1 = new Class { Name = "Warlock", subclasses = sc1 };

            classes.Add(c1);
        }


    }
}
