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
        int lengarmor = Entity.Armor.Count();
        public NPCGeneratorForm()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GeneratedField.Controls.Clear();
            /////////Словари для объектов формы//////
            var Names = new Dictionary<int, TextBox>(); 
            var Armor = new Dictionary<int, ComboBox>();
            var Hats = new Dictionary<int, ComboBox>();
            var KB = new Dictionary<int, Label>();
            var ArmorPU = new Dictionary<int, Label>();
            var HP = new Dictionary<int, NumericUpDown>();
            var Weapon = new Dictionary<int, Label>();
            var Attack = new Dictionary<int, Button>();
            /////Словари для хранения объектов по имени/////
            var ArmorObj = new Dictionary<string, Armor>();
            var WeaponObj = new Dictionary<string, Weapon>();
            ///
            int Value = (int)PlayerCount.Value;
            int rnd;
            if (Faction.Text == "Черти")
            {
                List<string> AvailableArmor = new List<string>();
                List<string> AvailableHats = new List<string>();
                List<string> AvailableWeapon = new List<string>();
                AvailableArmor.Add("Нет");
                ArmorObj.Add("Нет", new Armor());
                AvailableHats.Add("Нет");
                for (int i = 0; i < lengarmor; i++)
                {
                    if(Entity.Armor[i].ClassType != "Силовая броня" && Entity.Armor[i].ClassType != "Шлемы и головные уборы" && (Entity.Armor[i].Faction == "Нет" || Entity.Armor[i].Faction == "Черти"))
                    {
                        AvailableArmor.Add(Entity.Armor[i].name);
                        ArmorObj.Add(Entity.Armor[i].name, Entity.Armor[i]);
                    }
                    if (Entity.Armor[i].ClassType == "Шлемы и головные уборы" && (Entity.Armor[i].Faction == "Нет" || Entity.Armor[i].Faction == "Черт"))
                    {
                        AvailableHats.Add(Entity.Armor[i].name);
                        ArmorObj.Add(Entity.Armor[i].name, Entity.Armor[i]);
                    }
                }

                    Value = Value * 2;
                for (int i = 0; i < Value; i++)
                {
                    ////////Names///////////
                    Names.Add(i, new TextBox());
                    GeneratedField.Controls.Add(Names[i]);
                    Names[i].Text = "Черт" + (i+1);
                    if (i == 0)
                    {
                        Names[i].Location = new Point(GeneratedField.Location.X + 10, GeneratedField.Location.Y - 50);
                    }
                    else
                    {
                        Names[i].Location = new Point(Names[i - 1].Location.X, Names[i - 1].Location.Y + 30);
                    }
                    ////////////////////////Armor/////////
                    Armor.Add(i, new ComboBox());
                    Armor[i].Items.AddRange(AvailableArmor.ToArray());
                    GeneratedField.Controls.Add(Armor[i]);
                    rnd = new Random().Next(0, AvailableArmor.Count);
                    Armor[i].Text = AvailableArmor[rnd];
                    Armor[i].Location = new Point(Names[i].Location.X + 110, Names[i].Location.Y);
                    ////////////////////////Hat/////////
                    Hats.Add(i, new ComboBox());
                    Hats[i].Items.AddRange(AvailableHats.ToArray());
                    GeneratedField.Controls.Add(Hats[i]);
                    rnd = new Random().Next(0, AvailableHats.Count);
                    Hats[i].Text = AvailableHats[rnd];
                    Hats[i].Location = new Point(Armor[i].Location.X + 130, Armor[i].Location.Y);
                    //////////////////KB////////////////////
                    KB.Add(i, new Label());
                    GeneratedField.Controls.Add(KB[i]);
                    KB[i].AutoSize = true;
                    KB[i].Text = (ArmorObj[Armor[i].Text].KB + ArmorObj[Hats[i].Text].KB).ToString();
                    KB[i].Location = new Point(Hats[i].Location.X + 130, Hats[i].Location.Y+5);
                    ////////////////PU////////////////////////////
                    ArmorPU.Add(i, new Label());
                    GeneratedField.Controls.Add(ArmorPU[i]);
                    ArmorPU[i].AutoSize = true;
                    ArmorPU[i].Text = (ArmorObj[Armor[i].Text].AP + ArmorObj[Hats[i].Text].AP).ToString();
                    ArmorPU[i].Location = new Point(KB[i].Location.X + 50, KB[i].Location.Y);
                    /////////////////HP////////////////
                    HP.Add(i, new NumericUpDown());
                    GeneratedField.Controls.Add(HP[i]);
                    HP[i].AutoSize = true;
                    HP[i].Value = new Random().Next(30, 75);
                    HP[i].Location = new Point(ArmorPU[i].Location.X + 50, ArmorPU[i].Location.Y);



                }
            }
        }

    }
}
