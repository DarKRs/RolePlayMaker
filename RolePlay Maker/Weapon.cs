using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Weapon : Entity
    {
        public string Class;
        public int Damage;
        public string Ammo;
        public int Price;
        public static List<Weapon> Weapons = new List<Weapon>();

        public Weapon(string Class,string Name, int Damage, string Ammo, int Price, string Description)
        {
            this.Type = "Weapon";
            this.Class = Class.Trim();
            this.name = Name;
            this.Price = Price;
            this.Ammo = Ammo;
            this.Damage = Damage;
            this.Description = Description;
        }

        public static explicit operator Weapon(List<Entity> v)
        {
            throw new NotImplementedException();
        }
    }
}
