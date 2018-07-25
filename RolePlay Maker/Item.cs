using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Item
    {
        
        public static List<Item> Entitys = new List<Item>();
        public static List<Armor> ArmorList = new List<Armor>();
        public static List<Weapon> WeaponList = new List<Weapon>();
        public string Name;
        public string Type;
        public string Description;
        public string Fraction;

    }
}
