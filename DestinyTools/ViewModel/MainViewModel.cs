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
        public ObservableCollection<Buff> buffs { get; set; } = new ObservableCollection<Buff>();
        public ObservableCollection<Debuff> debuffs { get; set; } = new ObservableCollection<Debuff>();
        public ObservableCollection<Class> classes { get; set; } = new ObservableCollection<Class>();

        public MainViewModel()
        {
            fillClasses();
            //fillModifiers();
            fillBuffs();
            fillDebuffs();
        }

        private void fillClasses()
        {
            ObservableCollection<Subclass> sc1 = new ObservableCollection<Subclass>() { new Subclass { Name = "Solar" }, new Subclass { Name = "Void" }, new Subclass { Name = "Arc" } };
            Class c1 = new Class { Name = "Warlock", subclasses = sc1 };
            Class c2 = new Class { Name = "Titan", subclasses = sc1 };
            Class c3 = new Class { Name = "Hunter", subclasses = sc1 };

            classes.Add(c1);
            classes.Add(c2);
            classes.Add(c3);
        }

        private void fillModifiers()
        {
            //ObservableCollection<Modifier> m = new ObservableCollection<Modifier>() { new Modifier { Name = "Well", percentage = 25 } };

        }
        
        private void fillBuffs()
        {
            Buff b = new Buff { Name = "Well", percentage = 25, Stackable = true };

            buffs.Add(b);
        }

        private void fillDebuffs()
        {
            Debuff b = new Debuff { Name = "Well", percentage = 25, Stackable = true };

            debuffs.Add(b);
        }


    }
}
