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
<<<<<<< HEAD
        public static List<Item> Entities = new List<Item>();
=======
        
        public static List<Item> Entitys = new List<Item>(); //TODO DELETE
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630
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
