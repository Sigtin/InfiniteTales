using System;
using System.Collections.Generic;
using System.Text;

namespace InfiniteTales.Models
{
    public class Player : Person
    {
        public override string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public override List<Item> Inventory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<Spell> SpellBook { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Str { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Mag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Dex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Spd { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Lck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Def { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Res { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Cha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentExp { get; set; }
        public int ExpToNextLevelUp { get; set; }
    }
}
