using DestinyTools.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DestinyTools.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {

#region Fields
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Guardian> guardians { get; set; } = new ObservableCollection<Guardian>();
        public ObservableCollection<Class> classes { get; set; } = new ObservableCollection<Class>();
        public ObservableCollection<Subclass> subclasses { get; set; } = new ObservableCollection<Subclass>();
        public ObservableCollection<Weapon> weapons { get; set; } = new ObservableCollection<Weapon>();
        //public ObservableCollection<Modifier> modifiers { get; set; } = new ObservableCollection<Modifier>();
        public ObservableCollection<Mod> mods { get; set; } = new ObservableCollection<Mod>();
        public ObservableCollection<Buff> buffs { get; set; } = new ObservableCollection<Buff>();
        public ObservableCollection<Debuff> debuffs { get; set; } = new ObservableCollection<Debuff>();

        public ObservableCollection<Weapon> primaryWeapons
        {
            get { return new ObservableCollection<Weapon>(weapons.Where(r => r.Slot == (int)Slot.Primary)); }
        }
        public ObservableCollection<Weapon> secondaryWeapons
        {
            get { return new ObservableCollection<Weapon>(weapons.Where(r => r.Slot == (int)Slot.Secondary)); }
        }
        public ObservableCollection<Weapon> heavyWeapons 
        { 
            get { return new ObservableCollection<Weapon>(weapons.Where(r => r.Slot == (int)Slot.Heavy)); }
        }


        private enum Slot
        {
            Primary, Secondary, Heavy
        }
        private enum Rarity
        {
            Common, Uncommon, Rare, Legendary, Exotic
        }


        #endregion

        #region Properties

        private Guardian? _selectedGuardian;
        public Guardian? selectedGuardian
        {
            get { return _selectedGuardian; }
            set 
            {
                if(value != null)
                {
                    _selectedGuardian = value; 
                    OnPropertyChanged("selectedGuardian");
                }
            }
        }

        public int selectedGuardianIndex { get; set; } = 0;

        private Weapon? _selectedPrimaryWeapon;
        public Weapon selectedPrimaryWeapon
        {
            get { return _selectedPrimaryWeapon; }
            set
            {
                if(value != null)
                {
                    _selectedPrimaryWeapon = value;
                    OnPropertyChanged("selectedPrimaryWeapon");
                }
            }
        }

        private Weapon? _selectedSecondaryWeapon;
        public Weapon selectedSecondaryWeapon
        {
            get { return _selectedSecondaryWeapon; }
            set
            {
                if (value != null)
                {
                    _selectedSecondaryWeapon = value;
                    OnPropertyChanged("selectedSecondaryWeapon");
                }
            }
        }

        private Weapon? _selectedHeavyWeapon;
        public Weapon selectedHeavyWeapon
        {
            get { return _selectedHeavyWeapon; }
            set
            {
                if (value != null)
                {
                    _selectedHeavyWeapon = value;
                    OnPropertyChanged("selectedHeavyWeapon");
                }
            }
        }

        public Class selectedClass { get; set; }
        public Subclass selectedSubclass { get; set; }





        #endregion
        #region Commands

        public ICommand SaveGuardianCommand { get; set; }

        #endregion


        public MainViewModel()
        {
            init();
        }

        private void init()
        {
            SaveGuardianCommand = new RelayCommand(Execute_SaveGuardian);

            fillGuardians();
            fillClasses();
            //fillModifiers();
            fillMods();
            fillBuffs();
            fillDebuffs();
            fillWeapons();
        }

        private void Execute_SaveGuardian()
        {
            if (new List<Weapon> { selectedPrimaryWeapon, selectedSecondaryWeapon, selectedHeavyWeapon }.Where(r => r.Rarity == (int)Rarity.Exotic).Count() > 1)
                MessageBox.Show("Mehr als ein Exotic gleichzeitig ausgerüstet\nBitte nur ein Exotic auswählen");
            else
            {
                if(selectedGuardian != null)
                {
                    
                }
                else
                {
                    if(selectedPrimaryWeapon != null && selectedSecondaryWeapon != null && 
                        selectedHeavyWeapon != null &&  selectedClass != null && selectedSubclass != null)
                    {
                        guardians[selectedGuardianIndex].Weapons.Add(selectedPrimaryWeapon);
                        guardians[selectedGuardianIndex].Weapons.Add(selectedSecondaryWeapon);
                        guardians[selectedGuardianIndex].Weapons.Add(selectedHeavyWeapon);
                        guardians[selectedGuardianIndex].Class = selectedClass;
                        guardians[selectedGuardianIndex].Class.subclass = selectedSubclass;

                    }


                }
            }
        }

        private void fillWeapons()
        {
            weapons.Add(new Weapon { Name = "Izanagi", Slot = (int)Slot.Primary, Rarity = (int)Rarity.Exotic });
            weapons.Add(new Weapon { Name = "Calus Multi-Tool", Slot = (int)Slot.Secondary});
            weapons.Add(new Weapon { Name = "Cold Front", Slot = (int)Slot.Heavy });
            weapons.Add(new Weapon { Name = "Gjallarhorn", Slot = (int)Slot.Heavy, Rarity = (int)Rarity.Exotic });
        }

        private void fillGuardians()
        {
            for (int i = 1; i <= 6; i++)
            {
                guardians.Add(new Guardian { Name = "Guardian " + i });
            }
        }

        private void fillClasses()
        {
            subclasses = new ObservableCollection<Subclass>() 
            { 
                new Subclass { Name = "Solar" }, 
                new Subclass { Name = "Void" }, 
                new Subclass { Name = "Arc" },
                new Subclass { Name = "Stasis" },
                new Subclass { Name = "Strand" }
            };

            classes = new ObservableCollection<Class>()
            {
                new Class { Name = "Warlock" },
                new Class { Name = "Hunter" },
                new Class { Name = "Titan" }
            };
        }

        //private void fillModifiers()
        //{
        //    //ObservableCollection<Modifier> m = new ObservableCollection<Modifier>() { new Modifier { Name = "Well", percentage = 25 } };
        //}

        private void fillMods()
        {
            mods = new ObservableCollection<Mod>
            {
                new Mod { Name = "Breach'n Clear", Description = "Gegner wird um 15% weakened"},
                new Mod { Name = "Breach'n Clear", Description = "Gegner wird um 15% weakened"},
                new Mod { Name = "Breach'n Clear", Description = "Gegner wird um 15% weakened"},
                new Mod { Name = "Breach'n Clear", Description = "Gegner wird um 15% weakened"},
                new Mod { Name = "Breach'n Clear", Description = "Gegner wird um 15% weakened"}
            };
        }

        private void fillBuffs()
        {
            buffs = new ObservableCollection<Buff>()
            {
                new Buff { Name = "Well", percentage = 25, Stackable = true },
                new Buff { Name = "Well", percentage = 25, Stackable = true },
                new Buff { Name = "Well", percentage = 25, Stackable = true },
                new Buff { Name = "Well", percentage = 25, Stackable = true },
                new Buff { Name = "Well", percentage = 25, Stackable = true },
                new Buff { Name = "Well", percentage = 25, Stackable = true }
            };
        }

        private void fillDebuffs()
        {
            debuffs = new ObservableCollection<Debuff>()
            {
                new Debuff { Name = "Tether", percentage = 25, Stackable = true },
                new Debuff { Name = "Weaken", percentage = 15, Stackable = true },
                new Debuff { Name = "Weaken", percentage = 15, Stackable = true },
                new Debuff { Name = "Weaken", percentage = 15, Stackable = true },
                new Debuff { Name = "Weaken", percentage = 15, Stackable = true }
            };
        }


        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
