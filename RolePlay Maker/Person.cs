using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RolePlay_Maker
{
    public class Person
    {

        public string Name { get; set; }
        public string Class { get; set; }
        public string Trait { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int XP { get; set; }
        public int LvL { get; set; }
        public int KB { get; set; }
        public int KBArmor { get; set; } //КБ от брони

        //Атрибуты
        public int Strength { get; set; }
        public int Perception { get; set; } //Восприятие
        public int Endurance { get; set; } //Выносливость
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }

        //Наыки
        public double LightWeapons { get; set; }
        public double HeavyWeapons { get; set; }
        public double EnergyWeapons { get; set; }
        public double Unarmed { get; set; } //Без оружия
        public double ColdWeapons { get; set; } //Холодное оружие
        public double ThrowingWeapons { get; set; }
        public double Medic { get; set; }
        public double Repair { get; set; }
        public double Science { get; set; }
        public double Oratory { get; set; }
        public double Barter { get; set; }
        public double Survival { get; set; }
        public double Lockpick { get; set; } //Взлом
        public double Theft { get; set; } //Кража
        public double Stealth { get; set; } //Скрытность
        public double SabotageExplosives { get; set; }

        //Одето на персонаже
        public string Head { get; set; }
        public string Neck { get; set; }
        public string Shoulders { get; set; }
        public string Spine { get; set; }
        public string Chest { get; set; }
        public string Hand { get; set; }
        public string Gloves { get; set; }
        public string Belt { get; set; }
        public string Pants { get; set; }
        public string Shoes { get; set; }
        public string Finger1 { get; set; }
        public string Finger2 { get; set; }
        public string Finger3 { get; set; }
        public string Finger4 { get; set; }
        public string Other { get; set; }
        public string RightHand { get; set; }
        public string LeftHand { get; set; }
        public string Replacement { get; set; }



        public string backpack;
        public string Perks;
        public string Effects;

        public Person(string name, string Class, string Trait,int KBArm,int Strengt, int Perception, int Endurance, int Charisma,
            int Intelligence, int Agility, int Luck, string Head, string Neck, string Shoulders, string Spine,string Chest, string Hand, string Gloves, string Belt,
            string Pants, string Shoes, string Finger1, string Finger2,string Finger3,string Finger4, string Other, string RightHand, string LeftHand, string Replacement,
            string BackPack) //+, List<string> BackPack
        {
            this.Name = name;
            this.Class = Class;
            this.Trait = Trait; //Черта
            this.MaxHP = 10 + Strengt + (Endurance * 2);
            HP = MaxHP;
            XP = 0;
            LvL = 1;
            KB = 5 + Agility + KBArmor;
            KBArmor = KBArm;
            ////////////////////////
            this.Strength = Strengt;
            this.Perception = Perception;
            this.Endurance = Endurance;
            this.Charisma = Charisma;
            this.Intelligence = Intelligence;
            this.Agility = Agility;
            this.Luck = Luck;
            ///////////////////////
            this.LightWeapons = 30 + Agility + Luck / 2;
            this.HeavyWeapons = 15 + Strength + Agility / 2 + Luck / 2;
            this.EnergyWeapons = 10 + Agility + (Intelligence / 2) + Luck / 2;
            this.Unarmed = 30 + 2 * (Strength + Agility) + Luck / 2;
            this.ColdWeapons = 20 + 2 * (Strength + Agility) + Luck / 2;
            this.ThrowingWeapons = 30 + Agility + Luck / 2;
            this.Medic = 15 + (Perception + Intelligence) * 2 + Luck / 2;
            this.Repair = 20 + Intelligence + Luck / 2;
            this.Science = 20 + (2 * Intelligence) + Luck / 2;
            this.Oratory = 25 + 2 * Charisma + Luck / 2;
            this.Barter = 20 + 2 * Charisma + Luck / 2;
            this.Survival = 10 + 2 * (Endurance + Intelligence) + Luck / 2;
            this.Lockpick=20+(0.5*Perception)+(0.5*Agility)+Luck/2;
            this.Theft = 20 + Agility + Luck / 2;
            this.Stealth = 25 + Agility + Luck / 2;
            this.SabotageExplosives = 20 + 0.5 * (Perception + Agility) + Luck / 2;
            /////////////////////////
            this.Head = Head;
            this.Neck = Neck;
            this.Shoulders = Shoulders;
            this.Spine = Spine;
            this.Chest = Chest;
            this.Hand = Hand;
            this.Gloves = Gloves;
            this.Belt = Belt;
            this.Pants = Pants;
            this.Shoes = Shoes;
            this.Finger1 = Finger1;
            this.Finger2 = Finger2;
            this.Finger3 = Finger3;
            this.Finger4 = Finger4;
            this.Other = Other;
            this.RightHand = RightHand;
            this.LeftHand = LeftHand;
            this.Replacement = Replacement;
            /////////////////////////
            this.backpack = BackPack;
            this.Perks = "";
            this.Effects = "";
        }

        public Person()
            : this(string.Empty, string.Empty, string.Empty,0, 0, 0, 0, 0, 0, 0, 0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }


        public void Save(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            using (BinaryWriter binWriter = new BinaryWriter(fs))
            {
                binWriter.Write(Name);
                binWriter.Write(Class);//(string)
                binWriter.Write(Trait);
                binWriter.Write(HP);
                binWriter.Write(MaxHP);
                binWriter.Write(XP);
                binWriter.Write(LvL);
                binWriter.Write(KB);
                binWriter.Write(KBArmor);
                //////////////////////
                binWriter.Write(this.Strength);
                binWriter.Write(Perception);
                binWriter.Write(Endurance);
                binWriter.Write(Charisma);
                binWriter.Write(Intelligence);
                binWriter.Write(Agility);
                binWriter.Write(Luck);
                /////////////////////////////
                binWriter.Write(LightWeapons);
                binWriter.Write(HeavyWeapons);
                binWriter.Write(EnergyWeapons);
                binWriter.Write(Unarmed);
                binWriter.Write(ColdWeapons);
                binWriter.Write(ThrowingWeapons);
                binWriter.Write(Medic);
                binWriter.Write(Repair);
                binWriter.Write(Science);
                binWriter.Write(Oratory);
                binWriter.Write(Barter);
                binWriter.Write(Survival);
                binWriter.Write(Lockpick);
                binWriter.Write(Theft);
                binWriter.Write(Stealth);
                binWriter.Write(SabotageExplosives);
                ///////////////////////////
                binWriter.Write(Head);
                binWriter.Write(Neck);
                binWriter.Write(Shoulders);
                binWriter.Write(Spine);
                binWriter.Write(Chest);
                binWriter.Write(Hand);
                binWriter.Write(Gloves);
                binWriter.Write(Belt);
                binWriter.Write(Pants);
                binWriter.Write(Shoes);
                binWriter.Write(Finger1);
                binWriter.Write(Finger2);
                binWriter.Write(Finger3);
                binWriter.Write(Finger4);
                binWriter.Write(Other);
                binWriter.Write(RightHand);
                binWriter.Write(LeftHand);
                binWriter.Write(Replacement);
                binWriter.Write(backpack);
                //////////////////////////////
                binWriter.Write(Perks);
                binWriter.Write(Effects);
            }
        }

        

        public void Load(string path)
        {
            
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BinaryReader binReader = new BinaryReader(fs))
            {                  
                this.Name = binReader.ReadString();
                this.Class = binReader.ReadString();
                this.Trait = binReader.ReadString();
                this.HP = binReader.ReadInt32();
                this.MaxHP = binReader.ReadInt32();
                this.XP = binReader.ReadInt32();
                this.LvL = binReader.ReadInt32();
                this.KB = binReader.ReadInt32();
                this.KBArmor = binReader.ReadInt32();
                ////////////////////////////////////////
                this.Strength = binReader.ReadInt32();
                this.Perception = binReader.ReadInt32();
                this.Endurance = binReader.ReadInt32();
                this.Charisma = binReader.ReadInt32();
                this.Intelligence = binReader.ReadInt32();
                this.Agility = binReader.ReadInt32();
                this.Luck = binReader.ReadInt32();
                /////////////////////////////////////////
                this.LightWeapons = binReader.ReadDouble();
                this.HeavyWeapons = binReader.ReadDouble();
                this.EnergyWeapons = binReader.ReadDouble();
                this.Unarmed = binReader.ReadDouble();
                this.ColdWeapons = binReader.ReadDouble();
                this.ThrowingWeapons = binReader.ReadDouble();
                this.Medic = binReader.ReadDouble();
                this.Repair = binReader.ReadDouble();
                this.Science = binReader.ReadDouble();
                this.Oratory = binReader.ReadDouble();
                this.Barter = binReader.ReadDouble();
                this.Survival = binReader.ReadDouble();
                this.Lockpick = binReader.ReadDouble();
                this.Theft = binReader.ReadDouble();
                this.Stealth = binReader.ReadDouble();
                this.SabotageExplosives = binReader.ReadDouble();
                //////////////////////////////////////////
                this.Head = binReader.ReadString();
                this.Neck = binReader.ReadString();
                this.Shoulders = binReader.ReadString();
                this.Spine = binReader.ReadString();
                this.Chest = binReader.ReadString();
                this.Hand = binReader.ReadString();
                this.Gloves = binReader.ReadString();
                this.Belt = binReader.ReadString();
                this.Pants = binReader.ReadString();
                this.Shoes = binReader.ReadString();
                this.Finger1 = binReader.ReadString();
                this.Finger2 = binReader.ReadString();
                this.Finger3 = binReader.ReadString();
                this.Finger4 = binReader.ReadString();
                this.Other = binReader.ReadString();
                this.RightHand = binReader.ReadString();
                this.LeftHand = binReader.ReadString();
                this.Replacement = binReader.ReadString();
                this.backpack = binReader.ReadString();
                //////////////////////////////////////////////////////
                this.Perks = binReader.ReadString();
                this.Effects = binReader.ReadString();
            }

        }

    }
}
