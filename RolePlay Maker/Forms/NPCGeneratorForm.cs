using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RolePlay_Maker.Forms;

namespace RolePlay_Maker.Forms
{
    public partial class NPCGeneratorForm : Form
    {
        int lengarmor = Item.ArmorList.Count();
        
        public NPCGeneratorForm()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GeneratedField.Controls.Clear();
            CheckDataAndCallFunciton(Faction.Text, (int)PlayerLevel.Value, (int)PlayerCount.Value);  
        }

        private void CheckDataAndCallFunciton(string Fraction, int PlayersLevel, int PlayersCount)
        {
            switch (Fraction)
            {
                case "Черти":
                    List<Armor> AvailableArmor = new List<Armor>();
                    List<Armor> AvailableHats = new List<Armor>();
                    AvailableArmor.Add(new Armor());
                    AvailableHats.Add(new Armor());
                    List<Weapon> AvailableWeapon = new List<Weapon>();
                    List<Weapon> AvailableSecondaryWeapon = new List<Weapon>();
                    AvailableWeapon.Add(new Weapon());
                    AvailableSecondaryWeapon.Add(new Weapon());

                    for (int i = 0; i < Item.ArmorList.Count; i++)
                    {
                        if (Item.ArmorList[i].Class != "Силовая броня" && Item.ArmorList[i].Class != "Шлемы и головные уборы" && (Item.ArmorList[i].Fraction == "Нет" || Item.ArmorList[i].Fraction == "Черт"))
                        {
                            AvailableArmor.Add(Item.ArmorList[i]);
                        }
                        if (Item.ArmorList[i].Class == "Шлемы и головные уборы" && (Item.ArmorList[i].Fraction == "Нет" || Item.ArmorList[i].Fraction == "Черт"))
                        {
                            AvailableHats.Add(Item.ArmorList[i]);
                        }
                    }
                    for (int i = 0; i < Item.WeaponList.Count; i++)
                    {
                        if (Item.WeaponList[i].Class != "EnergyWeapon" && Item.WeaponList[i].Class != "ColdWeapon")
                        {
                            AvailableWeapon.Add(Item.WeaponList[i]);
                        }
                        if (Item.WeaponList[i].Class == "ColdWeapon")
                        {
                            AvailableSecondaryWeapon.Add(Item.WeaponList[i]);
                        }
                    }
                    int EnimiesCount = PlayersCount * PlayersLevel / 2;// * (rnd + 0.5));
                    NPCGenerator GUI = new NPCGenerator(AvailableArmor, AvailableHats, AvailableWeapon, AvailableSecondaryWeapon);
                    GUI.SetParams_Human(Fraction, EnimiesCount);
                    Draw(GUI,EnimiesCount);
                    break;
                case "Рейдеры": //TODO
                default: break;
            }

        }

        private void Draw(NPCGenerator GUI, int count)
        {
            for(int i=0; i< count; i++)
            {
                GeneratedField.Controls.Add(GUI.Names[i]);
                if (i == 0)
                {
                    GUI.Names[i].Location = new Point(GeneratedField.Location.X + 5, GeneratedField.Location.Y - 50);
                }
                else
                {
                    GUI.Names[i].Location = new Point(GUI.Names[i - 1].Location.X, GUI.Names[i - 1].Location.Y + 30);
                }
                //
                GeneratedField.Controls.Add(GUI.Armor[i]);
                GUI.Armor[i].Location = new Point(GUI.Names[i].Location.X + 110, GUI.Names[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.Hats[i]);
                GUI.Hats[i].Location = new Point(GUI.Armor[i].Location.X + 130, GUI.Armor[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.KB[i]);
                GUI.KB[i].Location = new Point(GUI.Hats[i].Location.X + 130, GUI.Hats[i].Location.Y + 5);
                //
                GeneratedField.Controls.Add(GUI.ArmorPU[i]);
                GUI.ArmorPU[i].Location = new Point(GUI.KB[i].Location.X + 20, GUI.KB[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.HP[i]);
                GUI.HP[i].Location = new Point(GUI.ArmorPU[i].Location.X + 20, GUI.Hats[i].Location.Y); //Наследование позиции Y от Hats т.к. label чуть завышены.
                //
                GeneratedField.Controls.Add(GUI.Weapon[i]);
                GUI.Weapon[i].Location = new Point(GUI.HP[i].Location.X + 70, GUI.HP[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.SecondaryWeapon[i]);
                GUI.SecondaryWeapon[i].Location = new Point(GUI.Weapon[i].Location.X + 140, GUI.Weapon[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.AttackMainWeapon[i]);
                GUI.AttackMainWeapon[i].Location = new Point(GUI.SecondaryWeapon[i].Location.X + 140, GUI.SecondaryWeapon[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.AttackSecondaryWeapon[i]);
                GUI.AttackSecondaryWeapon[i].Location = new Point(GUI.AttackMainWeapon[i].Location.X + 160, GUI.AttackMainWeapon[i].Location.Y);
                //
                GeneratedField.Controls.Add(GUI.Refresh[i]);
                GUI.Refresh[i].Location = new Point(GUI.AttackSecondaryWeapon[i].Location.X + 180, GUI.AttackSecondaryWeapon[i].Location.Y);
            }
           
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            Logs f = new Logs();
            f.Owner = this;
            f.Show();
        }
    }
}
