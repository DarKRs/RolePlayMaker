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
        int ArmorCount = Entity.Armor.Count();
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
            int PlayersCount = (int)PlayerCount.Value;
            int PlayersLevel = (int)PlayerLevel.Value;

            if (Fraction.Text == "Черти")
            {
                List<string> AvailableArmor = new List<string>();
                List<string> AvailableWeapon = new List<string>();
                for (int i = 0; i < ArmorCount; i++)
                {
                    if(Entity.Armor[i].ClassType != "Силовая броня" && (Entity.Armor[i].Fraction == "Нет" || Entity.Armor[i].Fraction == "Черти"))
                    {
                        AvailableArmor.Add(Entity.Armor[i].name);
                    }
                    
                }

                double rnd = new Random().NextDouble();
                int EnemiesCount = (int)(PlayersCount * PlayersLevel / 2 * (rnd + 0.5));
                for (int i = 0; i < EnemiesCount; i++)
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
            else if(Fraction.Text == "")
            {

            }
        }

        private void NPCGeneratorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
