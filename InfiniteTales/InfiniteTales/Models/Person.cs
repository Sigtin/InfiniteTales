using System.Collections.Generic;

namespace InfiniteTales.Models
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract List<Item> Inventory { get; set; }
        public abstract List<Spell> SpellBook { get; set; }
        public abstract int HP { get; set; }
        public abstract int Str { get; set; }
        public abstract int Mag { get; set; }
        public abstract int Dex { get; set; }
        public abstract int Spd { get; set; }
        public abstract int Lck { get; set; }
        public abstract int Def { get; set; }
        public abstract int Res { get; set; }
        public abstract int Cha { get; set; }
        public abstract int Mana { get; set; }
        public abstract int Level { get; set; }
    }
}
