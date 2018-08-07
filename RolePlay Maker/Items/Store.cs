using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker.Items
{
    [DataContract]
    class Store
    {
        [DataMember]
        public List<Item> Entities = new List<Item>();
        [DataMember]
        public List<Armor> ArmorList = new List<Armor>();
        [DataMember]
        public List<Weapon> WeaponList = new List<Weapon>();
    }
}
