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
            var Names = new Dictionary<int, TextBox>(); 
            var Armor = new Dictionary<int, Label>();
            var ArmorPU = new Dictionary<int, Label>();
            var HP = new Dictionary<int, NumericUpDown>();
            var Weapon = new Dictionary<int, Label>();
            var Attack = new Dictionary<int, Button>();
            int Value = (int)PlayerCount.Value;
            if (Faction.Text == "Черти")
            {
                List<string> AvailableArmor = new List<string>();
                List<string> AvailableWeapon = new List<string>();
                int rnd;
                for (int i = 0; i < lengarmor; i++)
                {
                    if(Entity.Armor[i].ClassType != "Силовая броня" && (Entity.Armor[i].Faction == "Нет" || Entity.Armor[i].Faction == "Черти"))
                    {
                        AvailableArmor.Add(Entity.Armor[i].name);
                    }
                    
                }
                    Value = Value * 2;
                for (int i = 0; i < Value; i++)
                {
                    ////////Names///////////
                    Names.Add(i, new TextBox());
                    GeneratedField.Controls.Add(Names[i]);
                    Names[i].Text = "Черт" + i;
                    if (i == 0) {
                        Names[i].Location = new Point(GeneratedField.Location.X + 10, GeneratedField.Location.Y - 50);
                        continue; }
                    Names[i].Location = new Point(Names[i - 1].Location.X, Names[i - 1].Location.Y + 30);
                    ////////////////////////Armor/////////
                   
                }
            }
        }
    }
}
