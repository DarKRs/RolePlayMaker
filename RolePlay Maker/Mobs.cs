using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Mob : Item
    {
        public int HP;
        public int KB;
        public int Damage;

        public Mob(string Name,int HP,int KB, int Damage, string Description)
        {
            this.Type = "Mob";
            this.Name = Name;
            this.HP = HP;
            this.KB = KB;
            this.Damage = Damage;
            this.Description = Description;
        }

     

    }
}
