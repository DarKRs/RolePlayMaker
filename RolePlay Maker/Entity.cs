using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Entity
    {
        public string Name;
        public int HP;
        public int KB;
        public string Damage;
        public string Description;

        public static List<Mob> MobList = new List<Mob>();
    }
}
