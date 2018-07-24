using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Entity
    {
       public string name;
       public static List<Entity> Entitys = new List<Entity>();
        public static List<Armor> ArmorList = new List<Armor>();
        public static List<Weapon> WeaponList = new List<Weapon>();
        public string Type;
        public string Description;
        public string Effects;
        public string Fraction;

    }
}
