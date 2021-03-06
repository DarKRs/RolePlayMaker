﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    [DataContract]
    class Weapon : Item
    {
        [DataMember]
        public string Class;
        [DataMember]
        public string Subclass;
        [DataMember]
        public int PermanentDamage;
        [DataMember]
        public DRoll RandomDamage;
        [DataMember]
        public string AmmoType;
        [DataMember]
        public int Magazine;
        [DataMember]
        public int Price;

        public Weapon()//Кулаки
        {
            this.Type = "";
            this.Class = "";
            this.Subclass = "";
            this.Name = "Нет";
            this.PermanentDamage = 2;
            this.RandomDamage = new DRoll(2);
            this.Description = "";
            this.AmmoType = "";
            this.Magazine = 0;
            this.Price = 0;
            this.Fraction = "";
        }

        public Weapon(string Subclass, IList<object> values, string Class)
        {
            this.Type = "Weapon";
            this.Subclass = Subclass;
            this.Class = Class;
            this.Name = values[0].ToString();
            if (Class == "EnergyWeapon" || Class == "LightWeapon" || Class == "HeavyWeapon")
            {
                string[] Damage = values[1].ToString().Split('+');
                this.PermanentDamage = Int32.Parse(Damage[1]);
                this.RandomDamage = new DRoll(Damage[0]);
                //
                this.Description = values[2].ToString();
                this.AmmoType = values[3].ToString();
                this.Magazine = Int32.Parse(values[4].ToString());
                this.Price = Int32.Parse(values[5].ToString());
                this.Fraction = values[6].ToString();
            }
            else if(Class == "ColdWeapon")
            {
                string[] Damage = values[1].ToString().Split('+');
                this.PermanentDamage = Int32.Parse(Damage[1]);
                this.RandomDamage = new DRoll(Damage[0]);
                //
                this.Description = values[2].ToString();
                this.AmmoType = "NaN";
                this.Magazine = 0;
                this.Price = Int32.Parse(values[3].ToString());
                this.Fraction = values[4].ToString();
            }
        }


    }
}
