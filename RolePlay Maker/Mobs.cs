using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Mob : Entity
    {
        public int PermanentDamage;
        public DRoll RandomDamage;
        public Mob(IList<object> values)
        {
            this.Name = values[0].ToString();
            this.KB = Int32.Parse(values[1].ToString());
            this.HP = Int32.Parse(values[2].ToString());
            this.Description = values[3].ToString();
            this.Damage = values[4].ToString();
            string[] Dmg = values[4].ToString().Split('+');
            this.PermanentDamage = Int32.Parse(Dmg[1]);
            this.RandomDamage = new DRoll(Dmg[0]);
        }

    }
}
