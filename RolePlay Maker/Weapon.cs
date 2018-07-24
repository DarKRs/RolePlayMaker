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
        public int PermanentDamage;
        public string RandomDamage;
        public string AmmoType;
        public int Magazine;
        public int Price;
        public static List<Weapon> Weapons = new List<Weapon>();

        public Weapon()
        {
            this.Type = "";
            this.Class = "";
            this.name = "";
            this.PermanentDamage = 0;
            this.RandomDamage = "D0";
            this.Description = "";
            this.AmmoType = "";
            this.Magazine = 0;
            this.Price = 0;
            this.Fraction = "";
        }

        public Weapon(string Class,string Name, int Damage, string Ammo, int Price, string Description)
        {
            this.Type = "Weapon";
            this.Class = Class.Trim();
            this.name = Name;
            this.Price = Price;
            this.AmmoType = Ammo;
            this.PermanentDamage = Damage;
            this.Description = Description;
        }

        public Weapon(string ClassType, IList<object> values)
        {
            this.Type = "Weapon";
            this.Class = ClassType;
            this.name = values[0].ToString();
            //
            string[] Damage = values[1].ToString().Split('+');
            this.PermanentDamage = Int32.Parse(Damage[1]);
            this.RandomDamage = Damage[0];
            //
            this.Description = values[2].ToString();
            this.AmmoType = values[3].ToString();
            this.Magazine = Int32.Parse(values[4].ToString());
            this.Price = Int32.Parse(values[5].ToString());
            this.Fraction = values[6].ToString();
        }
    }
}
