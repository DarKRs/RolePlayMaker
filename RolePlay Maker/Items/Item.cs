using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    [DataContract]
    class Item
    {
        public static List<Item> Entities = new List<Item>();
        public static List<Armor> ArmorList = new List<Armor>();
        public static List<Weapon> WeaponList = new List<Weapon>();

        [DataMember]
        public string Name;
        [DataMember]
        public string Type;
        [DataMember]
        public string Description;
        [DataMember]
        public string Fraction;

    }
}
